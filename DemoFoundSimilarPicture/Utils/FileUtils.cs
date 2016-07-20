/***********************************************************************

** Author:      Q-WHai
** Create Date: 2016‎/‎5‎/‎20
** Last Modify: 2016/7/20
** desc：       这是一个与文件操作相关的工具类
** Ver.:        V0.1.2

************************************************************************/

using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Collections;

namespace FoundSimilarPicture.Utils
{
    public class FileUtils
    {
        /// <summary>
        /// 获得当前目录下的所有一级子目录
        /// </summary>
        /// <param name="folderFullName">当前目录</param>
        /// <returns>所有一级子目录</returns>
        public static DirectoryInfo[] getAllSubFolder(string folderFullName)
        {
            if (CommonUtils.isEmpty(folderFullName))
            {
                return null;
            }

            DirectoryInfo dirInfo = new DirectoryInfo(folderFullName);
            DirectoryInfo[] dirInfos = dirInfo.GetDirectories();
            return dirInfos;
        } // end of function getAllSubFolder

        /// <summary>
        /// 获得当前目录的所有一级子文件
        /// </summary>
        /// <param name="folderFullName">当前目录</param>
        /// <returns>所有一级子目录</returns>
        public static FileInfo[] getAllSubFile(string folderFullName)
        {
            if (CommonUtils.isEmpty(folderFullName))
            {
                return null;
            }

            DirectoryInfo dirInfo = new DirectoryInfo(folderFullName);
            FileInfo[] fileInfos = dirInfo.GetFiles();
            return fileInfos;
        } // end of function getAllSubFile

        /// <summary>
        /// 展示某一个文件夹下的所有文件，包括子文件夹下的子文件
        /// 注意：传入的文件夹参数需要以 “/” 结尾
        /// </summary>
        /// <param name="folderFullName">待遍历的文件夹</param>
        public static void showAllFiles(string folderFullName)
        {
            FileInfo[] fileInfos = FileUtils.getAllSubFile(folderFullName);
            foreach (FileInfo nextFileInfo in fileInfos)
            {
                Console.WriteLine(String.Concat(folderFullName, nextFileInfo));
            }

            DirectoryInfo[] dirInfos = FileUtils.getAllSubFolder(folderFullName);
            foreach (DirectoryInfo nextDirInfo in dirInfos)
            {
                showAllFiles(String.Concat(folderFullName, nextDirInfo.Name + "/"));
            }
        } // end of function showAllFiles

        /// <summary>
        /// 获取某一个文件夹下的所有文件，包括子文件夹下的子文件
        /// 注意：传入的文件夹参数需要以 “/” 结尾
        /// </summary>
        /// <param name="folderFullName">待遍历的文件夹</param>
        /// <param name="files">装入文件信息的列表</param>
        public static void getAllFiles(string folderFullName, ArrayList files)
        {
            FileInfo[] fileInfos = FileUtils.getAllSubFile(folderFullName);
            foreach (FileInfo nextFileInfo in fileInfos)
            {
                files.Add(nextFileInfo);
            }

            DirectoryInfo[] dirInfos = FileUtils.getAllSubFolder(folderFullName);
            foreach (DirectoryInfo nextDirInfo in dirInfos)
            {
                getAllFiles(String.Concat(folderFullName, nextDirInfo.Name + "/"), files);
            }
        }

        /// <summary>
        /// 判别一个文件是否是压缩文件
        /// FIXME 待重构
        /// </summary>
        /// <param name="fileFullName">文件完全路径</param>
        /// <returns>true：是压缩文件 / false：不是压缩文件</returns>
        public static bool isZipFile(string fileFullName)
        {
            string[] zipSuffixs = { ".zip", ".rar", ".7z", ".gz", ".lzh", ".bz2", ".gz2", ".tar", ".xz", ".wim" };

            foreach (string suffix in zipSuffixs)
            {
                if (fileFullName.EndsWith(suffix))
                {
                    return true;
                }
            }

            return false;
        } // end of function isZipFile

        /// <summary>
        /// 拷贝整个文件夹
        /// TODO 待重构
        /// </summary>
        /// <param name="sourceFolderFullName">原文件夹</param>
        /// <param name="targetFolderFullName">目标文件夹</param>
        public static void copyFolderWhole(string sourceFolderFullName, string targetFolderFullName)
        {
            try
            {
                // 检查目标目录是否以目录分割字符结束如果不是则添加
                if (targetFolderFullName[targetFolderFullName.Length - 1] != System.IO.Path.DirectorySeparatorChar)
                {
                    targetFolderFullName += System.IO.Path.DirectorySeparatorChar;
                }

                // 判断目标目录是否存在如果不存在则新建
                if (!System.IO.Directory.Exists(targetFolderFullName))
                {
                    System.IO.Directory.CreateDirectory(targetFolderFullName);
                }

                // 得到源目录的文件列表，该里面是包含文件以及目录路径的一个数组
                // 如果你指向 copy 目标文件下面的文件而不包含目录请使用下面的方法
                //string[] fileList = Directory.GetFiles(sourceFolderFullName);
                string[] fileList = System.IO.Directory.GetFileSystemEntries(sourceFolderFullName);

                // 遍历所有的文件和目录
                foreach (string file in fileList)
                {
                    // 先当作目录处理如果存在这个目录就递归Copy该目录下面的文件
                    if (System.IO.Directory.Exists(file))
                    {
                        copyFolderWhole(file, targetFolderFullName + System.IO.Path.GetFileName(file));
                    }
                    else // 否则直接Copy文件
                    {
                        System.IO.File.Copy(file, targetFolderFullName + System.IO.Path.GetFileName(file), true);
                    }
                }
            }
            catch (Exception)
            {
                throw new Exception();
            }
        } // end of function copyFolderWhole()

        /// <summary>
        /// 按行读取文件
        /// </summary>
        /// <param name="filePath">文件完整路径</param>
        /// <returns>文件每一行的数据列表</returns>
        public static List<string> read(string filePath)
        {
            List<string> words = new List<string>();
            StreamReader reader = new StreamReader(filePath, Encoding.Default);
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                words.Add(line);
            }

            reader.Close();

            return words;
        } // end of function read

        /// <summary>
        /// 按行读取文件到一个字符串变量
        /// </summary>
        /// <param name="fileFullName">文件完整路径</param>
        /// <returns>文本内容</returns>
        public static string readToString(string fileFullName)
        {
            string text = "";
            StreamReader reader = new StreamReader(fileFullName, Encoding.Default);
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                text = String.Concat(text, line);
            }

            reader.Close();

            return text;
        }

        /// <summary>
        /// 删除非空文件夹
        /// </summary>
        /// <param name="path">要删除的文件夹目录</param>
        public static void removeFolder(string path)
        {
            DirectoryInfo dir = new DirectoryInfo(path);
            if (dir.Exists)
            {
                DirectoryInfo[] childs = dir.GetDirectories();
                foreach (DirectoryInfo child in childs)
                {
                    child.Delete(true);
                }
                dir.Delete(true);
            }
        } // end of function removeFolder()

        /// <summary>
        /// 对文件进行重命名
        /// </summary>
        /// <param name="sourceFileName">文件原路径</param>
        /// <param name="targetFileName">文件新路径</param>
        public static void renameFile(string sourceFileName, string targetFileName)
        {
            if (System.IO.File.Exists(sourceFileName))
            {
                System.IO.File.Move(sourceFileName, targetFileName);
            }
        } // end of function renameFile()

        /// <summary>
        /// 对文件夹进行重命名
        /// </summary>
        /// <param name="sourceFolderName">文件夹原路径</param>
        /// <param name="targetFolderName">文件夹新路径</param>
        public static void renameFolder(string sourceFolderName, string targetFolderName)
        {
            if (System.IO.Directory.Exists(sourceFolderName))
            {
                System.IO.Directory.Move(sourceFolderName, targetFolderName);
            }
        } // end of function renameFolder()

        /// <summary>
        /// 判断一个文件是否存在
        /// </summary>
        /// <param name="folderFullName">文件夹完整路径</param>
        /// <returns>true:存在 / false:不存在</returns>
        public static bool existFolder(string folderFullName)
        {
            DirectoryInfo folderInfo = new DirectoryInfo(folderFullName);
            if (folderInfo == null)
            {
                return false;
            }

            return folderInfo.Exists;
        } // end of function existFolder()
    }
}
