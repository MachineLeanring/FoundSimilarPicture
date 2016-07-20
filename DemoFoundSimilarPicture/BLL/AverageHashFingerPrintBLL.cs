/***********************************************************************

** Author:      Q-WHai
** Create Date: 2016/7/19 16:19:48
** Last Modify: 2016/7/20
** desc：       平均哈希算法
** Ver.:        V0.1.0

************************************************************************/

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

using DemoFoundSimilarPicture.Utils;

namespace DemoFoundSimilarPicture.BLL
{
    public class AverageHashFingerPrintBLL : HashFingerPrintBLL
    {
        public override string getImageFingerPrint(string imageFileFullName, int targetWidth, int targetHeight)
        {
            // 第 1 步，缩小尺寸
            Bitmap thumbnailBitmap = ImageHelper.getThumbnailBitmap3(imageFileFullName, targetWidth, targetHeight);

            // 第 2 步，简化色彩
            int[] pixels = ImageHelper.getSimplifyPixels(targetWidth, targetHeight, thumbnailBitmap);

            // 第 3 步，计算平均值
            int averagePixel = average(pixels);

            // 第 4 步，比较像素的灰度
            int[] comparedPixels = getComparedPixels(pixels, targetWidth, targetHeight, averagePixel);

            // 第 5 步，计算哈希值
            return getFingerPrintHashCode(comparedPixels);
        }
    }
}
