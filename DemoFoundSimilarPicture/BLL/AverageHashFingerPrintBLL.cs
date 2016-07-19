/***********************************************************************

** Author:      Q-WHai
** Create Date: 2016/7/19 16:19:48
** Last Modify: 2016/7/19 16:19:48
** desc：       平均哈希算法
** Ver.:        V0.1.0

************************************************************************/

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace DemoFoundSimilarPicture
{
    public class AverageHashFingerPrintBLL : HashFingerPrintBLL
    {
        public override string getImageFingerPrint(string imageFileFullName, int targetWidth, int targetHeight)
        {
            // 第一步，缩小尺寸
            Bitmap thumbnailBitmap = ImageHelper.getThumbnailBitmap3(imageFileFullName, targetWidth, targetHeight);

            // 第二步，简化色彩
            int[] pixels = ImageHelper.getSimplifyPixels(targetWidth, targetHeight, thumbnailBitmap);

            // 第三步，计算平均值
            int averagePixel = average(pixels);

            // 第四步，比较像素的灰度
            int[] comparedPixels = ImageHelper.getComparedPixels(pixels, targetWidth, targetHeight, averagePixel);

            // 第五步，计算哈希值
            return getFingerPrintHashCode(comparedPixels);
        }

        # region get average of pixels

        /// <summary>
        /// 计算数组的平均值
        /// </summary>
        /// <param name="pixels"></param>
        /// <returns></returns>
        private int average(int[] pixels)
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

        # region get hash code

        private string getFingerPrintHashCode(int[] comparedPixels)
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
