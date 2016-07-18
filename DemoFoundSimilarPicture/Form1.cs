using System;
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
            string sourcePath = ImageHelper.ROOTPATH + @"..\..\images\original\original.jpg";
            string targetPath = ImageHelper.ROOTPATH + @"..\..\images\compress\thumbnail.jpg";
            ImageHelper.saveThumbnail(sourcePath, targetPath, 8, 8, 100);
            MessageBox.Show(string.Concat(@"图片已压缩，压缩后的图片路径为: ", targetPath));
        }

        private void compressButton2_Click(object sender, EventArgs e)
        {
            TestImageThumbnail.test();
            MessageBox.Show(@"图片压缩测试已完成");
        }

        private void fingerPrintButton_Click(object sender, EventArgs e)
        {
            string imagePath = ImageHelper.ROOTPATH + @"..\..\images\original\original.jpg";
            string fingerPrint = ImageHelper.getImageFingerPrint(imagePath, 8, 8);
            MessageBox.Show(String.Concat("图片 ", imagePath, " 的指纹是： ", fingerPrint));
        }

        private void imageSimilarMatchButtonClick(object sender, EventArgs e)
        {
            TestFoundSimiarPicture.testFoundSimilarPicture(ImageHelper.ROOTPATH + @"..\..\images\part-lol\1.jpg", ImageHelper.ROOTPATH + @"..\..\images\part-lol");
        }

        private void classifyGetButton_Click(object sender, EventArgs e)
        {
            string samplesPath = @"D:\Code\CS\Demo\Picture\FoundSimilarPicture\DemoFoundSimilarPicture\images\LOL\";
            string testImagePath = @"D:\Code\CS\Demo\Picture\FoundSimilarPicture\DemoFoundSimilarPicture\images\LOL\Victory\v-0.jpg";
            new TestClassifyGet().execute(samplesPath, testImagePath);
        }
    }
}
