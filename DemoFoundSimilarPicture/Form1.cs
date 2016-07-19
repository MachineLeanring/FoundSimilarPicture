using System;
using System.IO;
using System.Windows.Forms;

namespace DemoFoundSimilarPicture
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void compressButtonClick(object sender, EventArgs e)
        {
            string targetPath = ImageHelper.ROOTPATH + @"..\..\images\compress\thumbnail.jpg";
            TestGetImageThumbnail.test(getOpenFileDialogReturnFileName(), targetPath);
            MessageBox.Show(string.Concat(@"图片已压缩，压缩后的图片路径为: ", targetPath));
        }

        private void compressButton2_Click(object sender, EventArgs e)
        {
            TestImageThumbnail.test();
            MessageBox.Show(@"图片压缩测试已完成");
        }

        private void fingerPrintButton_Click(object sender, EventArgs e)
        {
            string fileFullName = getOpenFileDialogReturnFileName();
            string fingerPrint = ImageHelper.getImageFingerPrint(fileFullName, 8, 8);
            MessageBox.Show(String.Concat("图片 ", fileFullName, " 的指纹是： ", fingerPrint));
        }

        private void imageSimilarMatchButtonClick(object sender, EventArgs e)
        {
            TestFoundSimiarPicture.testFoundSimilarPicture(ImageHelper.ROOTPATH + @"..\..\images\part-lol\lol-result-v-0.jpg", ImageHelper.ROOTPATH + @"..\..\images\part-lol");
        }

        private void classifyGetButton_Click(object sender, EventArgs e)
        {
            string samplesPath = ImageHelper.ROOTPATH + @"..\..\images\LOL\";
            new TestClassifyGet().execute(samplesPath, getOpenFileDialogReturnFileName());
        }

        private string getOpenFileDialogReturnFileName()
        {
            OpenFileDialog opdialog = new OpenFileDialog();
            string fileFullName = string.Empty;
            if (opdialog.ShowDialog() == DialogResult.OK)
            {
                Stream ms = null;
                byte[] picbyte = null;
                if ((ms = opdialog.OpenFile()) != null)
                {
                    picbyte = new byte[ms.Length];
                    ms.Position = 0;
                    ms.Read(picbyte, 0, Convert.ToInt32(ms.Length));

                    fileFullName = opdialog.FileName;

                    ms.Dispose();
                }
            }

            return fileFullName;
        }
    }
}
