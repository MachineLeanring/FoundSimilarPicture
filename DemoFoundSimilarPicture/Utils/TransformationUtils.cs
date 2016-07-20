/***********************************************************************

** Author:      Q-WHai
** Create Date: 2016/7/19 17:26:18
** Last Modify: 2016/7/19 17:26:18
** desc：       尚未编写描述
** Ver.:        V0.1.0

************************************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FoundSimilarPicture.Utils
{
    public class TransformationUtils
    {
        // 要进行DCT变换的图片的宽或高
        public const int DCT_WIDTH = 256;

        /// <summary>
        /// 离散余弦变换 
        /// </summary>
        /// <param name="pix">原图像的数据矩阵</param>
        /// <param name="n">原图像(n*n)的高或宽</param>
        /// <returns>变换后的矩阵数组</returns>
        public int[] DCT(int[] pix, int n) {
            double[, ] iMatrix = new double[n, n];

            for(int i = 0; i < n; i++) {
                for(int j = 0; j < n; j++) {
                    iMatrix[i, j] = (double)(pix[i * n + j]);
                }
            }

            double[, ] quotient = coefficient(n); // 求系数矩阵
            double[, ] quotientT = transposingMatrix(quotient, n); // 转置系数矩阵
            
            double[, ] temp = new double[n, n];
            temp = matrixMultiply(quotient, iMatrix, n);
            iMatrix = matrixMultiply(temp, quotientT, n);

            int[] newpix = new int[n * n];
            for(int i = 0; i < n; i++) {
                for(int j = 0; j < n; j++) {
                    newpix[i * n + j] = (int)iMatrix[i, j];
                }
            }

            return newpix;
        }

        /// <summary>
        /// 矩阵转置
        /// </summary>
        /// <param name="matrix">原矩阵</param>
        /// <param name="n">矩阵 (n*n) 的高或宽</param>
        /// <returns>转置后的矩阵</returns>
        private double[, ] transposingMatrix(double[, ] matrix, int n) {
            double[,] nMatrix = new double[n, n];

            for(int i = 0; i < n; i++) {
                for(int j = 0; j < n; j++) {
                    nMatrix[i, j] = matrix[j, i];
                }
            }

            return nMatrix;
        }

        /// <summary>
        /// 求离散余弦变换的系数矩阵
        /// </summary>
        /// <param name="n">n*n 矩阵的大小</param>
        /// <returns>系数矩阵</returns>
        private double[, ] coefficient(int n) {
            double[, ] coeff = new double[n, n];
            double sqrt = 1.0 / Math.Sqrt(n);

            for(int i = 0; i < n; i++) {
                coeff[0, i] = sqrt;
            }
            for(int i = 1; i < n; i++) {
                for(int j = 0; j < n; j++) {
                    coeff[i, j] = Math.Sqrt(2.0 / n) * Math.Cos(i * Math.PI * (j + 0.5) / (double)n);
                }
            }

            return coeff;
        }

        /// <summary>
        /// 矩阵相乘
        /// </summary>
        /// <param name="A">矩阵 A</param>
        /// <param name="B">矩阵 B</param>
        /// <param name="n">矩阵的大小 (n * n)</param>
        /// <returns>乘积矩阵</returns>
        private double[, ] matrixMultiply(double[, ] A, double[, ] B, int n) {
            double[, ] nMatrix = new double[n, n];
            double t = 0.0;
            for(int i = 0; i < n; i++) {
                for(int j = 0; j < n; j++) {
                    t = 0;
                    for(int k = 0; k < n; k++) {
                        t += A[i, k] * B[k, j];
                    }
                    nMatrix[i, j] = t;
                }
            }
            return nMatrix;
        }
    }
}
