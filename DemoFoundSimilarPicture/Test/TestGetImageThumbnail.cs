/***********************************************************************

** Author:      Q-WHai
** Create Date: 2016/7/19 9:52:40
** Last Modify: 2016/7/19
** desc：       尚未编写描述
** Ver.:        V0.1.0

************************************************************************/

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

using FoundSimilarPicture.Utils;

namespace FoundSimilarPicture.Test
{
    class TestGetImageThumbnail
    {
        public static void test(string sourcePath, string targetPath)
        {
            Bitmap bitmap = ImageHelper.getThumbnailBitmap3(sourcePath, 32, 32);
            bitmap.Save(targetPath);
        }
    }
}
