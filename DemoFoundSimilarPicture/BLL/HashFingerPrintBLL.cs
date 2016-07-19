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
    }
}
