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

        public static double cosineSimilarity(String vector1, String vector2)
        {
            int[] vectorArray1 = chars2intArray(vector1.ToCharArray());
            int[] vectorArray2 = chars2intArray(vector2.ToCharArray());

            double molecular = 0.0;
            double denominator1 = 0.0;
            double denominator2 = 0.0;

            for (int index = 0; index < vectorArray1.Length; index++)
            {
                molecular += vectorArray1[index] * vectorArray2[index];
                denominator1 += vectorArray1[index] * vectorArray1[index];
                denominator2 += vectorArray2[index] * vectorArray2[index];
            }

            return 1 - molecular / (Math.Sqrt(denominator1) * Math.Sqrt(denominator2));
        }

        public static double cosineSimilarityHex(String vector1, String vector2)
        {
            int[] vectorArray1 = hexChars2intArray(vector1.ToCharArray());
            int[] vectorArray2 = hexChars2intArray(vector2.ToCharArray());

            double molecular = 0.0;
            double denominator1 = 0.0;
            double denominator2 = 0.0;

            for (int index = 0; index < vectorArray1.Length; index++)
            {
                molecular += vectorArray1[index] * vectorArray2[index];
                denominator1 += vectorArray1[index] * vectorArray1[index];
                denominator2 += vectorArray2[index] * vectorArray2[index];
            }

            return 1 - molecular / (Math.Sqrt(denominator1) * Math.Sqrt(denominator2));
        }

        private static int[] chars2intArray(char[] chars)
        {
            int[] result = new int[chars.Length];
            for (int index = 0; index < chars.Length; index++)
            {
                result[index] = int.Parse(chars[index] + "");
            }

            return result;
        }

        private static int[] hexChars2intArray(char[] chars)
        {
            int[] result = new int[chars.Length];
            for (int index = 0; index < chars.Length; index++)
            {
                result[index] = hex2Binary(chars[index]);
            }

            return result;
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

        public static int hex2Binary(char hex)
        {
            Dictionary<char, int> binaryDict = new Dictionary<char, int>();
            binaryDict.Add('0', 0);
            binaryDict.Add('1', 1);
            binaryDict.Add('2', 2);
            binaryDict.Add('3', 3);
            binaryDict.Add('4', 4);
            binaryDict.Add('5', 5);
            binaryDict.Add('6', 6);
            binaryDict.Add('7', 7);
            binaryDict.Add('8', 8);
            binaryDict.Add('9', 9);
            binaryDict.Add('A', 10);
            binaryDict.Add('B', 11);
            binaryDict.Add('C', 12);
            binaryDict.Add('D', 13);
            binaryDict.Add('E', 14);
            binaryDict.Add('F', 15);

            return binaryDict[hex];
        }
    }
}
