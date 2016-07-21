/***********************************************************************

** Author:      Q-WHai
** Create Date: 2016/7/20
** Last Modify: 2016/7/21
** desc：       尚未编写描述
** Ver.:        V0.1.0

************************************************************************/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Threading;
using System.Text;
using System.Windows.Forms;

using FoundSimilarPicture.Utils;

namespace FoundSimilarPicture
{
    public partial class CorpImageForm : Form
    {
        public CorpImageForm()
        {
            InitializeComponent();
        }

        private void corpImageBrowseButton_Click(object sender, EventArgs e)
        {
            string imageFileFullName = FormUtils.getOpenFileDialogReturnFileName();

            Thread thread = new Thread(new ParameterizedThreadStart(updateImageFullNameTextBoxLabel));
            thread.IsBackground = true;

            thread.Start(imageFileFullName);
        }

        private void imageCorpButton_Click(object sender, EventArgs e)
        {
            string imageFileFullName = imageFullNameTextBox.Text;
            int x = int.Parse(locationXTextBox.Text);
            int y = int.Parse(locationYTextBox.Text);
            int w = int.Parse(sizeWTextBox.Text);
            int h = int.Parse(sizeHTextBox.Text);

            Bitmap corpImageBitmap = ImageUtils.cropImage(new Bitmap(imageFileFullName), x, y, w, h);
            corpImageBitmap.Save(imageFileFullName + ".corp.jpg");

            MessageBox.Show("图片裁剪已完成，新图片路径：\n" + imageFileFullName + ".corp.jpg");
        }

        // --------------------------------- 委托 ----------------------------------------
        private delegate void invokeUpdateTextBox(string label);

        private void updateImageFullNameTextBox(string label)
        {
            imageFullNameTextBox.Text = label;
        }

        private void updateImageFullNameTextBoxLabel(object o)
        {
            if (o == null)
            {
                return;
            }

            if (imageFullNameTextBox.InvokeRequired)
            {
                invokeUpdateTextBox invoke = new invokeUpdateTextBox(updateImageFullNameTextBox);
                Invoke(invoke, o.ToString());
            }
        }
    }
}
