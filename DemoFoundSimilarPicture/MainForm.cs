﻿using System;
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
            string targetPath = ImageHelper.ROOTPATH + @"..\..\images\compress\thumbnail.jpg";
            TestGetImageThumbnail.test(FormUtils.getOpenFileDialogReturnFileName(), targetPath);
            MessageBox.Show(string.Concat(@"图片已压缩，压缩后的图片路径为: ", targetPath));
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
            TestFoundSimiarPicture.testFoundSimilarPicture(ImageHelper.ROOTPATH + @"..\..\images\samples\1364398774_4118.jpg", ImageHelper.ROOTPATH + @"..\..\images\samples");
        }

        private void classifyGetButton_Click(object sender, EventArgs e)
        {
            string samplesPath = ImageHelper.ROOTPATH + @"..\..\images\LOL\";

            new TestClassifyGet().testSingleImage(samplesPath, FormUtils.getOpenFileDialogReturnFileName());
        }

        private void classifyGetMoreButton_Click(object sender, EventArgs e)
        {
            string samplesPath = ImageHelper.ROOTPATH + @"..\..\images\LOL\";
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
    }
}
