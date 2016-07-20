/***********************************************************************

** Author:      Q-WHai
** Create Date: 2016/7/15 14:23:07
** Last Modify: 2016/7/20
** desc：       尚未编写描述
** Ver.:        V0.1.0

************************************************************************/

using System;
using System.Drawing.Imaging;
using System.Drawing;
using System.Text;
using System.Drawing.Drawing2D;
using System.Runtime.InteropServices;

namespace FoundSimilarPicture.Utils
{
    public class ImageHelper
    {
        public readonly static String ROOTPATH = System.AppDomain.CurrentDomain.BaseDirectory;

        public enum AnchorPosition
        {
            Top,
            Center,
            Bottom,
            Left,
            Right
        }

        # region Save Thumbnail

        /// <summary>
        /// 无损压缩图片
        /// </summary>
        /// <param name="originalImageFullName">原图片</param>
        /// <param name="targetImageFullName">压缩后保存位置</param>
        /// <param name="targetHeight">高度</param>
        /// <param name="targetWidth">宽度</param>
        /// <param name="quality">压缩质量 1-100</param>
        /// <returns></returns>
        public static bool saveThumbnail(string originalImageFullName, string targetImageFullName, int targetWidth, int targetHeight, int quality)
        {
            Image iSource = Image.FromFile(originalImageFullName);
            ImageFormat tFormat = iSource.RawFormat;
            int sW = 0, sH = 0;

            // 按比例缩放
            Size tem_size = new Size(iSource.Width, iSource.Height);
            if (tem_size.Width > targetHeight || tem_size.Width > targetWidth) // 将**改成 c# 中的或者操作符号
            {
                if ((tem_size.Width * targetHeight) > (tem_size.Height * targetWidth))
                {
                    sW = targetWidth;
                    sH = (targetWidth * tem_size.Height) / tem_size.Width;
                }
                else
                {
                    sH = targetHeight;
                    sW = (tem_size.Width * targetHeight) / tem_size.Height;
                }
            }
            else
            {
                sW = tem_size.Width;
                sH = tem_size.Height;
            }

            Bitmap targetBitmap = new Bitmap(targetWidth, targetHeight);
            Graphics graphics = Graphics.FromImage(targetBitmap);
            graphics.Clear(Color.WhiteSmoke);
            graphics.CompositingQuality = CompositingQuality.HighQuality;
            graphics.SmoothingMode = SmoothingMode.HighQuality;
            graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
            graphics.DrawImage(iSource, new Rectangle((targetWidth - sW) / 2, (targetHeight - sH) / 2, sW, sH), 0, 0, iSource.Width, iSource.Height, GraphicsUnit.Pixel);
            graphics.Dispose();

            // 以下代码为保存图片时，设置压缩质量
            EncoderParameters ep = new EncoderParameters();
            long[] qy = new long[1];
            qy[0] = quality; // 设置压缩的比例 1-100
            EncoderParameter eParam = new EncoderParameter(System.Drawing.Imaging.Encoder.Quality, qy);
            ep.Param[0] = eParam;
            try
            {
                ImageCodecInfo[] arrayICI = ImageCodecInfo.GetImageEncoders();
                ImageCodecInfo jpegICIinfo = null;
                for (int x = 0; x < arrayICI.Length; x++)
                {
                    if (arrayICI[x].FormatDescription.Equals("JPEG"))
                    {
                        jpegICIinfo = arrayICI[x];
                        break;
                    }
                }
                if (jpegICIinfo != null)
                {
                    targetBitmap.Save(targetImageFullName, jpegICIinfo, ep); // targetImageFullName 是压缩后的新路径
                }
                else
                {
                    targetBitmap.Save(targetImageFullName, tFormat);
                }
                return true;
            }
            catch
            {
                return false;
            }
            finally
            {
                iSource.Dispose();
                targetBitmap.Dispose();
            }
        }

        # endregion

        # region Get Thumbnail Bitmap

        public static Bitmap getThumbnailBitmap1(string originalImageFullName, int targetWidth, int targetHeight)
        {
            Image iSource = Image.FromFile(originalImageFullName);
            ImageFormat tFormat = iSource.RawFormat;
            int sW = 0, sH = 0;

            // 按比例缩放
            Size tem_size = new Size(iSource.Width, iSource.Height);
            if (tem_size.Width > targetHeight || tem_size.Width > targetWidth) // 将**改成 c# 中的或者操作符号
            {
                if ((tem_size.Width * targetHeight) > (tem_size.Height * targetWidth))
                {
                    sW = targetWidth;
                    sH = (targetWidth * tem_size.Height) / tem_size.Width;
                }
                else
                {
                    sH = targetHeight;
                    sW = (tem_size.Width * targetHeight) / tem_size.Height;
                }
            }
            else
            {
                sW = tem_size.Width;
                sH = tem_size.Height;
            }

            Bitmap targetBitmap = new Bitmap(targetWidth, targetHeight);
            Graphics graphics = Graphics.FromImage(targetBitmap);
            graphics.Clear(Color.WhiteSmoke);
            graphics.CompositingQuality = CompositingQuality.HighQuality;
            graphics.SmoothingMode = SmoothingMode.HighQuality;
            graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
            graphics.DrawImage(iSource, new Rectangle((targetWidth - sW) / 2, (targetHeight - sH) / 2, sW, sH), 0, 0, iSource.Width, iSource.Height, GraphicsUnit.Pixel);
            graphics.Dispose();

            return targetBitmap;
        }
        # endregion

        # region Get Thumbnail Bitmap

        public static Bitmap getThumbnailBitmap2(string originalImageFullName, int targetWidth, int targetHeight, AnchorPosition Anchor)
        {
            Image imgPhoto = Image.FromFile(originalImageFullName);
            int sourceWidth = imgPhoto.Width;
            int sourceHeight = imgPhoto.Height;
            int sourceX = 0;
            int sourceY = 0;
            int destX = 0;
            int destY = 0;

            float nPercent = 0;
            float nPercentW = 0;
            float nPercentH = 0;

            nPercentW = ((float)targetWidth / (float)sourceWidth);
            nPercentH = ((float)targetHeight / (float)sourceHeight);

            if (nPercentH < nPercentW)
            {
                nPercent = nPercentW;
                switch (Anchor)
                {
                    case AnchorPosition.Top:
                        destY = 0;
                        break;
                    case AnchorPosition.Bottom:
                        destY = (int)(targetHeight - (sourceHeight * nPercent));
                        break;
                    default:
                        destY = (int)((targetHeight - (sourceHeight * nPercent)) / 2);
                        break;
                }
            }
            else
            {
                nPercent = nPercentH;
                switch (Anchor)
                {
                    case AnchorPosition.Left:
                        destX = 0;
                        break;
                    case AnchorPosition.Right:
                        destX = (int)(targetWidth - (sourceWidth * nPercent));
                        break;
                    default:
                        destX = (int)((targetWidth - (sourceWidth * nPercent)) / 2);
                        break;
                }
            }

            int destWidth = (int)(sourceWidth * nPercent);
            int destHeight = (int)(sourceHeight * nPercent);

            Bitmap bmPhoto = new Bitmap(targetWidth, targetHeight, PixelFormat.Format24bppRgb);
            bmPhoto.SetResolution(imgPhoto.HorizontalResolution, imgPhoto.VerticalResolution);

            Graphics grPhoto = Graphics.FromImage(bmPhoto);
            grPhoto.InterpolationMode = InterpolationMode.HighQualityBicubic;

            grPhoto.DrawImage(imgPhoto,
                new Rectangle(destX, destY, destWidth, destHeight),
                new Rectangle(sourceX, sourceY, sourceWidth, sourceHeight),
                GraphicsUnit.Pixel);

            grPhoto.Dispose();

            return bmPhoto;
        }

        # endregion

        # region Get Thumbnail Bitmap

        public static Bitmap getThumbnailBitmap3(string oldImagePath, int newWidth, int newHeight)
        {
            string originalFilename = oldImagePath;

            //从文件取得图片对象
            Image image = Image.FromFile(originalFilename);

            //取得图片大小
            Size size = new Size(newWidth, newHeight);

            //新建一个bmp图片
            Bitmap bitmap = new Bitmap(size.Width, size.Height);

            //新建一个画板
            System.Drawing.Graphics g = System.Drawing.Graphics.FromImage(bitmap);

            //设置高质量插值法
            g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.High;

            //设置高质量,低速度呈现平滑程度
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;

            //清空一下画布
            g.Clear(Color.Transparent);

            //在指定位置画图
            g.DrawImage(image, new Rectangle(0, 0, bitmap.Width, bitmap.Height), new Rectangle(0, 0, image.Width, image.Height), GraphicsUnit.Pixel);
            image.Dispose();

            //释放
            image.Dispose();
            g.Dispose();

            return bitmap;
        }

        # endregion

        # region 简化色彩

        /// <summary>
        /// 简化色彩
        /// </summary>
        /// <param name="width">图片宽</param>
        /// <param name="height">图片高</param>
        /// <param name="bitmap">图片</param>
        /// <returns>简化后的色彩值</returns>
        public static int[] getSimplifyPixels(int width, int height, Bitmap bitmap)
        {

            int[] pixels = new int[width * height];
            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < height; j++)
                {
                    // pixels[i * height + j] = rgbToGray(bitmap.GetPixel(i, j).ToArgb());
                    pixels[i * height + j] = colorToGray(bitmap.GetPixel(i, j));
                }
            }

            return pixels;
        }

        # endregion

        # region 图像灰度化

        /// <summary>
        /// 图像灰度化
        /// </summary>
        public static Bitmap toGray(Bitmap bmp)
        {
            for (int i = 0; i < bmp.Width; i++)
            {
                for (int j = 0; j < bmp.Height; j++)
                {
                    //获取该点的像素的RGB的颜色
                    Color color = bmp.GetPixel(i, j);
                    //利用公式计算灰度值
                    int gray = (int)(color.R * 0.3 + color.G * 0.59 + color.B * 0.11);
                    Color newColor = Color.FromArgb(gray, gray, gray);
                    bmp.SetPixel(i, j, newColor);
                }
            }
            return bmp;
        }

        # endregion

        # region 图像灰度反转

        /// <summary>
        /// 图像灰度反转
        /// </summary>
        /// <param name="bmp"></param>
        /// <returns></returns>
        public static Bitmap grayReverse(Bitmap bmp)
        {
            for (int i = 0; i < bmp.Width; i++)
            {
                for (int j = 0; j < bmp.Height; j++)
                {
                    //获取该点的像素的RGB的颜色
                    Color color = bmp.GetPixel(i, j);
                    Color newColor = Color.FromArgb(255 - color.R, 255 - color.G, 255 - color.B);
                    bmp.SetPixel(i, j, newColor);
                }
            }
            return bmp;
        }

        # endregion

        # region 图像二值化 1

        /// <summary>
        /// 图像二值化1：
        /// 取图片的平均灰度作为阈值，低于该值的全都为0，高于该值的全都为255
        /// </summary>
        /// <param name="bmp"></param>
        /// <returns></returns>
        public static Bitmap ConvertTo1Bpp1(Bitmap bmp)
        {
            int average = 0;
            for (int i = 0; i < bmp.Width; i++)
            {
                for (int j = 0; j < bmp.Height; j++)
                {
                    Color color = bmp.GetPixel(i, j);
                    average += color.B;
                }
            }

            average = (int)average / (bmp.Width * bmp.Height);

            for (int i = 0; i < bmp.Width; i++)
            {
                for (int j = 0; j < bmp.Height; j++)
                {
                    //获取该点的像素的RGB的颜色
                    Color color = bmp.GetPixel(i, j);
                    int value = 255 - color.B;
                    Color newColor = value > average ? Color.FromArgb(0, 0, 0) : Color.FromArgb(255, 255, 255);
                    bmp.SetPixel(i, j, newColor);
                }
            }
            return bmp;
        }

        # endregion

        # region 图像二值化 2

        /// <summary>
        /// 图像二值化2
        /// </summary>
        /// <param name="img"></param>
        /// <returns></returns>
        public static Bitmap ConvertTo1Bpp2(Bitmap img)
        {
            int w = img.Width;
            int h = img.Height;
            Bitmap bmp = new Bitmap(w, h, PixelFormat.Format1bppIndexed);
            BitmapData data = bmp.LockBits(new Rectangle(0, 0, w, h), ImageLockMode.ReadWrite, PixelFormat.Format1bppIndexed);
            for (int y = 0; y < h; y++)
            {
                byte[] scan = new byte[(w + 7) / 8];
                for (int x = 0; x < w; x++)
                {
                    Color c = img.GetPixel(x, y);
                    if (c.GetBrightness() >= 0.5) scan[x / 8] |= (byte)(0x80 >> (x % 8));
                }
                Marshal.Copy(scan, 0, (IntPtr)((int)data.Scan0 + data.Stride * y), scan.Length);
            }
            return bmp;
        }

        # endregion

        # region 剪切图片

        /// <summary>  
        /// 剪裁 -- 用GDI+   
        /// </summary>  
        /// <param name="bitmap">原始Bitmap</param>  
        /// <param name="StartX">开始坐标X</param>  
        /// <param name="StartY">开始坐标Y</param>  
        /// <param name="targetWidth">宽度</param>  
        /// <param name="targetHeight">高度</param>  
        /// <returns>剪裁后的Bitmap</returns>  
        public static Bitmap cropImage(Bitmap bitmap, int StartX, int StartY, int targetWidth, int targetHeight)
        {
            if (bitmap == null)
            {
                return null;
            }

            int sourceWidth = bitmap.Width;
            int sourceHeight = bitmap.Height;

            if (StartX >= sourceWidth || StartY >= sourceHeight)
            {
                return null;
            }

            if (StartX + targetWidth > sourceWidth)
            {
                targetWidth = sourceWidth - StartX;
            }

            if (StartY + targetHeight > sourceHeight)
            {
                targetHeight = sourceHeight - StartY;
            }

            try
            {
                Bitmap resultBitmap = new Bitmap(targetWidth, targetHeight, PixelFormat.Format24bppRgb);
                Graphics graphics = Graphics.FromImage(resultBitmap);
                graphics.DrawImage(bitmap, new Rectangle(0, 0, targetWidth, targetHeight), new Rectangle(StartX, StartY, targetWidth, targetHeight), GraphicsUnit.Pixel);
                graphics.Dispose();

                return resultBitmap;
            }
            catch
            {
                return null;
            }
        }

        # endregion

        # region get pixel gray value

        /// <summary>
        /// 灰度值计算
        /// </summary>
        /// <param name="pixels">像素</param>
        /// <returns>灰度值</returns>
        public static int rgbToGray(int pixels)
        {
            int red = (pixels >> 16) & 0xFF;
            int green = (pixels >> 8) & 0xFF;
            int blue = (pixels) & 0xFF;
            return (int)(0.3 * red + 0.59 * green + 0.11 * blue);
        }

        # endregion

        # region get pixel gray value

        /// <summary>
        /// 灰度值计算
        /// </summary>
        /// <param name="pixels">像素</param>
        /// <returns>灰度值</returns>
        public static int colorToGray(Color color)
        {
            return (int)(0.3 * color.R + 0.59 * color.G + 0.11 * color.B);
        }

        # endregion

        # region 计算数组的平均值

        /// <summary>
        /// 计算数组的平均值
        /// </summary>
        /// <param name="pixels"></param>
        /// <returns></returns>
        public static int average(int[] pixels)
        {
            float m = 0;
            for (int i = 0; i < pixels.Length; ++i)
            {
                m += pixels[i];
            }
            m = m / pixels.Length;
            return (int)m;
        }

        # endregion

        # region 计算 Hash 值

        private static string getFingerPrintHashCode(int[] comparedPixels)
        {
            StringBuilder hashCodeBuilder = new StringBuilder();
            for (int index = 0; index < comparedPixels.Length; index += 4)
            {
                int result = 
                    comparedPixels[index] * (int)Math.Pow(2, 3) +
                    comparedPixels[index + 1] * (int)Math.Pow(2, 2) +
                    comparedPixels[index + 2] * (int)Math.Pow(2, 1) +
                    comparedPixels[index + 2];

                hashCodeBuilder.Append(CommonUtils.binaryToHex(result));
            }
            
            return hashCodeBuilder.ToString();
        }

        # endregion
    }
}
