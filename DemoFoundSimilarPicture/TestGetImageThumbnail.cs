/***********************************************************************

** Author:      Q-WHai
** Create Date: 2016/7/19 9:52:40
** Last Modify: 2016/7/19 9:52:40
** desc：       尚未编写描述
** Ver.:        V0.1.0

************************************************************************/

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace DemoFoundSimilarPicture
{
    class TestGetImageThumbnail
    {
        public static void test(string sourcePath, string targetPath)
        {

            Bitmap bitmap = ImageHelper.getThumbnailImage(sourcePath, 8, 8);
            ImageHelper.saveBitmap(bitmap, targetPath);
        }
    }
}
