/***********************************************************************

** Author:      Q-WHai
** Create Date: 2016/7/15 15:00:06
** Last Modify: 2016/7/15
** desc：       尚未编写描述
** Ver.:        V0.1.0

************************************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FoundSimilarPicture.Utils
{
    public class CommonUtils
    {
        public static bool isEmpty(string text)
        {
            return text == null || text.Length == 0;
        }

        /// <summary>
        /// 计算"汉明距离"（Hamming distance）
        /// </summary>
        public static int hammingDistance(String sourceHashCode, String hashCode)
        {
            int difference = 0;
            int len = sourceHashCode.Length;

            for (int i = 0; i < len; i++)
            {
                if (sourceHashCode[i] != hashCode[i])
                {
                    difference++;
                }
            }

            return difference;
        }

        /// <summary>
        /// 二进制转为十六进制
        /// </summary>
        public static char binaryToHex(int binary)
        {
            Dictionary<int, char> hexDict = new Dictionary<int, char>();
            hexDict.Add(0, '0');
            hexDict.Add(1, '1');
            hexDict.Add(2, '2');
            hexDict.Add(3, '3');
            hexDict.Add(4, '4');
            hexDict.Add(5, '5');
            hexDict.Add(6, '6');
            hexDict.Add(7, '7');
            hexDict.Add(8, '8');
            hexDict.Add(9, '9');
            hexDict.Add(10, 'A');
            hexDict.Add(11, 'B');
            hexDict.Add(12, 'C');
            hexDict.Add(13, 'D');
            hexDict.Add(14, 'E');
            hexDict.Add(15, 'F');

            return hexDict[binary];
        }
    }
}
