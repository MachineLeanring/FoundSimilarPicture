/***********************************************************************

** Author:      Q-WHai
** Create Date: 2016/7/19 16:24:52
** Last Modify: 2016/7/19
** desc：       感知哈希算法
** Ver.:        V0.1.0

************************************************************************/

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using DemoFoundSimilarPicture.Utils;

namespace DemoFoundSimilarPicture
{
    public class PerceptionHashFingerPrintBLL : HashFingerPrintBLL
    {
        public override string getImageFingerPrint(string imageFileFullName, int targetWidth, int targetHeight)
        {
            // 第 1 步，获得缩略图
            Bitmap thumbnailBitmap = ImageHelper.getThumbnailBitmap3(imageFileFullName, targetWidth, targetHeight);

            // 第 2 步，简化色彩
            int[] pixels = ImageHelper.getSimplifyPixels(targetWidth, targetHeight, thumbnailBitmap);

            // 第 3 步，计算DCT
            int[] dctPixels = new TransformationUtils().DCT(pixels, (int)Math.Sqrt(pixels.Length));

            // 第 4 步，缩小DCT ( 左上角 8*8 区块的 DCT 系数 )
            int[] dctSmallPixels = getDCTSmallPixels(dctPixels, 8, 8);

            // 第 5 步，计算平均值
            int averagePixel = average(dctSmallPixels);

            // 第 6 步，进一步减小 DCT
            int[] comparedPixels = getComparedPixels(dctSmallPixels, 8, 8, averagePixel);

            // 第 7 步，计算图片指纹
            return getFingerPrintHashCode(comparedPixels);
        }

        # region Narrow DCT Pixels

        private int[] getDCTSmallPixels(int[] dctPixels, int width, int height)
        {
            int dctPixelsLength = (int)Math.Sqrt(dctPixels.Length);
            int[] dctSmallPixels = new int[width * height];

            for (int rowIndex = 0; rowIndex < height; rowIndex++)
            {
                for (int colIndex = 0; colIndex < width; colIndex++)
                {
                    dctSmallPixels[rowIndex * width + colIndex] = dctPixels[rowIndex * dctPixelsLength + colIndex];
                }
            }

            return dctSmallPixels;
        }

        # endregion
    }
}
