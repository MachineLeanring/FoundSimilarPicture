using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using FoundSimilarPicture.Utils;

namespace FoundSimilarPicture
{
    public partial class ImageShowForm : Form
    {
        string sourcePath = "";
        Bitmap thumbnailBitmap = null;

        public ImageShowForm()
        {
            InitializeComponent();
        }

        public void setSourcePath(string sourcePath)
        {
            this.sourcePath = sourcePath;
        }

        private void ImageShowForm_Load(object sender, EventArgs e)
        {
            bitmapShowPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            thumbnailBitmap = ImageUtils.getThumbnailBitmap3(sourcePath, 8, 8);
            bitmapShowPictureBox.Image = Image.FromHbitmap(thumbnailBitmap.GetHbitmap());
        }

        private void bitmapSaveButton_Click(object sender, EventArgs e)
        {
            if (thumbnailBitmap != null)
            {
                thumbnailBitmap.Save(sourcePath + @".thumb.jpg");
            }

            this.Close();
        }
    }
}
