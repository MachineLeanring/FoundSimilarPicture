/***********************************************************************

** Author:      Q-WHai
** Create Date: 2016/7/21 16:19:09
** Last Modify: 2016/7/21
** desc：       尚未编写描述
** Ver.:        V0.1.0

************************************************************************/

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

using FoundSimilarPicture.Utils;

namespace FoundSimilarPicture.BLL
{
    public class ImageBLL
    {
        public static void binaryImage(string sourceImagePath, string targetImagePath)
        {
            Bitmap sourceBitmap = new Bitmap(sourceImagePath);
            // Bitmap sourceBitmap = ImageUtils.getThumbnailBitmap3(sourceImagePath, 32, 32);
            ImageUtils.binaryImage2(sourceBitmap).Save(targetImagePath);
        }
    }
}
