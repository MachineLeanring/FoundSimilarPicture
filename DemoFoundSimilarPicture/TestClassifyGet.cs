using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace DemoFoundSimilarPicture
{
    public class TestClassifyGet
    {
        public void execute(string samplesPath, string testImagePath)
        {
            Dictionary<string, List<string>> fingerPrintDict = getFingerPrintDict(samplesPath);
            string testImageFingerPrint = ImageHelper.getImageFingerPrint(testImagePath, 8, 8);

            string classify = getClassify(fingerPrintDict, testImageFingerPrint);
            MessageBox.Show("图片" + testImagePath + "的分类结果为：\n" + classify);
        }

        private string getClassify(Dictionary<string, List<string>> fingerPrintDict, string testImageFingerPrint)
        {
            int minDistance = int.MaxValue;
            string classify = string.Empty;
            foreach (var item in fingerPrintDict)
            {
                 List<string> fingerPrints = item.Value;
                 foreach (string fingerPrint in fingerPrints)
                 {
                     int distance = CommonUtils.hammingDistance(fingerPrint, testImageFingerPrint);
                     if (distance < minDistance)
                     {
                         minDistance = distance;
                         classify = item.Key;
                     }
                 }
            }

            // MessageBox.Show("d = " + minDistance);

            if (minDistance >= 5)
            {
                classify = "无法判定";
            }

            return classify;
        }

        private Dictionary<string, List<string>> getFingerPrintDict(string samplesPath)
        {
            DirectoryInfo[] classifyFolderNames = FileUtils.getAllSubFolder(samplesPath);

            Dictionary<string, List<string>> fingerPrintDict = new Dictionary<string, List<string>>();
            foreach (DirectoryInfo directoryInfo in classifyFolderNames)
            {
                FileInfo[] fileInfos = FileUtils.getAllSubFile(directoryInfo.FullName);
                List<string> fingerPrints = new List<string>();
                foreach (FileInfo fileInfo in fileInfos)
                {
                    string fingerPrint = ImageHelper.getImageFingerPrint(fileInfo.FullName, 8, 8);
                    fingerPrints.Add(fingerPrint);
                }
                fingerPrintDict.Add(directoryInfo.Name, fingerPrints);
            }

            return fingerPrintDict;
        }
    }
}
