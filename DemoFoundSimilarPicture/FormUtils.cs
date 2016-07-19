/***********************************************************************

** Author:      Q-WHai
** Create Date: 2016/7/19 11:42:19
** Last Modify: 2016/7/19 11:42:19
** desc：       尚未编写描述
** Ver.:        V0.1.0

************************************************************************/

using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.IO;
using System.Text;

namespace DemoFoundSimilarPicture
{
    public class FormUtils
    {
        public static string getOpenFileDialogReturnFileName()
        {
            OpenFileDialog opdialog = new OpenFileDialog();
            string fileFullName = string.Empty;
            if (opdialog.ShowDialog() == DialogResult.OK)
            {
                Stream stream = null;
                if ((stream = opdialog.OpenFile()) != null)
                {
                    fileFullName = opdialog.FileName;
                    stream.Dispose();
                }
            }

            return fileFullName;
        }

        public static string getOpenFolderDialogReturnFolderName()
        {
            string folderFullName = string.Empty;
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                folderFullName = dialog.SelectedPath;
            }

            return folderFullName;
        }
    }
}
