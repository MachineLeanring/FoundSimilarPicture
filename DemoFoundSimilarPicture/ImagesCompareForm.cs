using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FoundSimilarPicture
{
    public partial class ImagesCompareForm : Form
    {
        private string image1Path = string.Empty;
        private string image2Path = string.Empty;

        private string hashAlgorithName = "";
        private string resultLabel = string.Empty;

        public ImagesCompareForm()
        {
            InitializeComponent();
        }

        private void ImagesCompareForm_Load(object sender, EventArgs e)
        {
            this.Text = hashAlgorithName;
            imagesComparePictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            imagesComparePictureBox1.Image = Image.FromHbitmap(new Bitmap(image1Path).GetHbitmap());

            imagesComparePictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            imagesComparePictureBox2.Image = Image.FromHbitmap(new Bitmap(image2Path).GetHbitmap());

            imagesCompareResultLabel.Text = resultLabel;
        }

        public void setImage1Path(string path)
        {
            this.image1Path = path;
        }

        public void setImage2Path(string path)
        {
            this.image2Path = path;
        }

        public void setResultLabel(string label)
        {
            this.resultLabel = label;
        }

        public void setHashAlgorithName(string hashAlgorithName)
        {
            this.hashAlgorithName = hashAlgorithName;
        }
    }
}
