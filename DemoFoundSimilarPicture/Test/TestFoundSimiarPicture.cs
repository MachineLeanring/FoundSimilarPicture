/***********************************************************************

** Author:      Q-WHai
** Create Date: 2016/7/15 16:09:18
** Last Modify: 2016/7/15
** desc：       尚未编写描述
** Ver.:        V0.1.0

************************************************************************/

using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace DemoFoundSimilarPicture
{
    class TestFoundSimiarPicture
    {
        public static void testFoundSimilarPicture(string origionalImageFileFullName, string samplesImageFolderFullName)
        {
            StringBuilder showBuilder = new StringBuilder();
            HashFingerPrintBLL bll = new AverageHashFingerPrintBLL();
            string origionalImageFingerPrint = bll.getImageFingerPrint(origionalImageFileFullName, 8, 8);
            
            string[] pathSegments = origionalImageFileFullName.Split(new Char[] { '\\' });
            showBuilder.Append(string.Concat("原图片: ", pathSegments[pathSegments.Length - 1], ", 指纹: ", origionalImageFingerPrint, "\n\n"));

            FileInfo[] sampleFileInfos = FileUtils.getAllSubFile(samplesImageFolderFullName);
            foreach (FileInfo sampleFileInfo in sampleFileInfos)
            {
                string sampleImageFingerPrint = bll.getImageFingerPrint(sampleFileInfo.FullName, 8, 8);
                int distance = CommonUtils.hammingDistance(origionalImageFingerPrint, sampleImageFingerPrint);
                showBuilder.Append(string.Concat("样本 ", sampleFileInfo.Name, " 的指纹: ", origionalImageFingerPrint, "\n"));
                showBuilder.Append(string.Concat("与原图的距离: ", distance, " 判定结果为 ", getJudgment(distance), "\n\n"));
            }

            MessageBox.Show(showBuilder.ToString());
        }

        private static string getJudgment(int distance)
        {
            string judgemnt = "无判定";
            if (distance < 0)
            {
                judgemnt = "参数出错，无判定";
            }
            else if (distance == 0)
            {
                judgemnt = "同一张图片";
            }
            else if (distance <= 3)
            {
                judgemnt = "极度相似";
            }
            else if (distance <= 7)
            {
                judgemnt = "非常相似";
            }
            else if (distance <= 11)
            {
                judgemnt = "比较相似";
            }
            else
            {
                judgemnt = "完全不同";
            }

            return judgemnt;
        }
    }
}
