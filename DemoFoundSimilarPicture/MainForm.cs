using System;
using System.IO;
using System.Windows.Forms;

using FoundSimilarPicture.BLL;
using FoundSimilarPicture.Utils;
using FoundSimilarPicture.Test;

namespace FoundSimilarPicture
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void compressButtonClick(object sender, EventArgs e)
        {
            string sourcePath = FormUtils.getOpenFileDialogReturnFileName();

            ImageShowForm form = new ImageShowForm();
            form.setSourcePath(sourcePath);
            form.Show(this);
        }

        private void compressButton2_Click(object sender, EventArgs e)
        {
            TestImageThumbnail.test();
            MessageBox.Show(@"图片压缩测试已完成");
        }

        private void fingerPrintButton_Click(object sender, EventArgs e)
        {
            string fileFullName = FormUtils.getOpenFileDialogReturnFileName();
            HashFingerPrintBLL bll = new AverageHashFingerPrintBLL();
            string fingerPrint = bll.getImageFingerPrint(fileFullName, 8, 8);
            MessageBox.Show(String.Concat("图片 ", fileFullName, " 的指纹是： ", fingerPrint));
        }

        private void imageSimilarMatchButtonClick(object sender, EventArgs e)
        {
            TestFoundSimiarPicture.testFoundSimilarPicture(ImageUtils.ROOTPATH + @"..\..\images\samples\1364398774_4118.jpg", ImageUtils.ROOTPATH + @"..\..\images\samples");
        }

        private void classifyGetButton_Click(object sender, EventArgs e)
        {
            string samplesPath = ImageUtils.ROOTPATH + @"..\..\images\LOL\";

            new TestClassifyGet().testSingleImage(samplesPath, FormUtils.getOpenFileDialogReturnFileName());
        }

        private void classifyGetMoreButton_Click(object sender, EventArgs e)
        {
            string samplesPath = ImageUtils.ROOTPATH + @"..\..\images\LOL\";
            string testFolderFullName = FormUtils.getOpenFolderDialogReturnFolderName();

            new TestClassifyGet().testMoreImages(samplesPath, testFolderFullName);
        }

        private void perceptionHashFingerPrintButton_Click(object sender, EventArgs e)
        {
            string fileFullName = FormUtils.getOpenFileDialogReturnFileName();
            HashFingerPrintBLL bll = new PerceptionHashFingerPrintBLL();
            string fingerPrint = bll.getImageFingerPrint(fileFullName, 32, 32);
            MessageBox.Show(String.Concat("图片 ", fileFullName, " 的指纹是： ", fingerPrint));
        }

        private void matchSimilarImageButton1_Click(object sender, EventArgs e)
        {
            // string image1FileFullName = FormUtils.getOpenFileDialogReturnFileName();
            MatchSimilarImageForm form = new MatchSimilarImageForm();
            form.ShowDialog(this);
        }

        private void differenceHashFingerPrintButton_Click(object sender, EventArgs e)
        {
            string fileFullName = FormUtils.getOpenFileDialogReturnFileName();

            HashFingerPrintBLL bll = new DifferenceHashFingerPrintBLL();
            string fingerPrint = bll.getImageFingerPrint(fileFullName, 9, 8);
            MessageBox.Show(String.Concat("图片 ", fileFullName, " 的指纹是： ", fingerPrint));
        }

        private void testImageCropButton_Click(object sender, EventArgs e)
        {
            CorpImageForm form = new CorpImageForm();
            form.Show(this);
        }

        private void perceptionHashButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("cos = " + CommonUtils.cosineSimilarity("1221110", "1221121"));
        }

        private void imageBinaryButton_Click(object sender, EventArgs e)
        {
            string fileFullName = FormUtils.getOpenFileDialogReturnFileName();
            ImageBLL.binaryImage(fileFullName, fileFullName + ".b.jpg");
            MessageBox.Show("二值化图片完成");
        }
    }
}
