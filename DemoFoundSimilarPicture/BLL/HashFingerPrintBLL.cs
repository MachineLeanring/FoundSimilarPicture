/***********************************************************************

** Author:      Q-WHai
** Create Date: 2016/7/19 16:20:30
** Last Modify: 2016/7/19 16:20:30
** desc：       尚未编写描述
** Ver.:        V0.1.0

************************************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DemoFoundSimilarPicture
{
    public abstract class HashFingerPrintBLL
    {
        public enum AnchorPosition
        {
            Top,
            Center,
            Bottom,
            Left,
            Right
        }

        public abstract string getImageFingerPrint(string imageFileFullName, int targetWidth, int targetHeight);

        # region get average of pixels

        /// <summary>
        /// 计算数组的平均值
        /// </summary>
        /// <param name="pixels"></param>
        /// <returns></returns>
        public int average(int[] pixels)
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

        # region 计算比较的后的像素标识

        public int[] getComparedPixels(int[] pixels, int width, int height, int averagePixel)
        {
            int[] comparedPixels = new int[width * height];
            for (int i = 0; i < comparedPixels.Length; i++)
            {
                if (pixels[i] >= averagePixel)
                {
                    comparedPixels[i] = 1;
                }
                else
                {
                    comparedPixels[i] = 0;
                }
            }

            return comparedPixels;
        }

        # endregion

        # region get hash code

        public string getFingerPrintHashCode(int[] comparedPixels)
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
