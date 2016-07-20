/***********************************************************************

** Author:      Q-WHai
** Create Date: 2016/7/19 16:27:42
** Last Modify: 2016/7/20
** desc：       差异哈希算法
** Ver.:        V0.1.0

************************************************************************/

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

using FoundSimilarPicture.Utils;

namespace FoundSimilarPicture.BLL
{
    public class DifferenceHashFingerPrintBLL : HashFingerPrintBLL
    {
        public override string getImageFingerPrint(string imageFileFullName, int targetWidth, int targetHeight)
        {
            // 第 1 步，缩小尺寸
            Bitmap thumbnailBitmap = ImageHelper.getThumbnailBitmap3(imageFileFullName, targetWidth, targetHeight);

            // 第 2 步，转化为灰度图
            Bitmap grayThumbnailBitmap = ImageHelper.toGray(thumbnailBitmap);
            // ImageHelper.saveBitmap(grayThumbnailBitmap, @"F:\Temp\xxx.jpg");

            // 第 3 步，计算像素矩阵
            int[] pixels = getPixelsOfBitmap(grayThumbnailBitmap, targetWidth, targetHeight);

            // 第 4 步，计算差异矩阵
            int[] diffPixels = getDifferencePixelsOfBitmap(pixels, 8, 8);

            // 第 5 步，计算哈希指纹
            return getFingerPrintHashCode(diffPixels);
        }

        # region Get Pixels Of Bitmap

        private int[] getPixelsOfBitmap(Bitmap bitmap, int width, int height)
        {
            int[] pixels = new int[width * height];

            for (int rowIndex = 0; rowIndex < height; rowIndex++)
            {
                for (int colIndex = 0; colIndex < width; colIndex++)
                {
                    pixels[rowIndex * width + colIndex] = bitmap.GetPixel(colIndex, rowIndex).ToArgb();
                }
            }

            return pixels;
        }

        # endregion

        private int[] getDifferencePixelsOfBitmap(int[] pixels, int width, int height)
        {
            int[] diffPixels = new int[width * height];

            for (int rowIndex = 0; rowIndex < height; rowIndex++)
            {
                for (int colIndex = 0; colIndex < width; colIndex++)
                {
                    diffPixels[rowIndex * width + colIndex] = pixels[rowIndex * width + colIndex] - pixels[rowIndex * width + colIndex + 1] > 0 ? 1 : 0;
                }
            }

            return diffPixels;
        }
    }
}
