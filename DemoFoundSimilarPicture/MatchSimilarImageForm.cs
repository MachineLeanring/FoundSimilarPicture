/***********************************************************************

** Author:      Q-WHai
** Create Date: 2016/7/20
** Last Modify: 2016/7/20
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

using DemoFoundSimilarPicture.BLL;
using DemoFoundSimilarPicture.Model;
using DemoFoundSimilarPicture.Utils;

namespace DemoFoundSimilarPicture
{
    public partial class MatchSimilarImageForm : Form
    {
        public MatchSimilarImageForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string imageFileFullName = FormUtils.getOpenFileDialogReturnFileName();

            Thread thread = new Thread(new ParameterizedThreadStart(updateTextBoxLabel));
            thread.IsBackground = true;

            UpdateModel model = new UpdateModel(textBox1, imageFileFullName);
            thread.Start(model);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string imageFileFullName = FormUtils.getOpenFileDialogReturnFileName();

            Thread thread = new Thread(new ParameterizedThreadStart(updateTextBoxLabel));
            thread.IsBackground = true;

            UpdateModel model = new UpdateModel(textBox2, imageFileFullName);
            thread.Start(model);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            HashFingerPrintBLL bll = new PerceptionHashFingerPrintBLL();
            string image1FingerPrint = bll.getImageFingerPrint(textBox1.Text, 8, 8);
            string image2FingerPrint = bll.getImageFingerPrint(textBox2.Text, 8, 8);

            MessageBox.Show("汉明距离 = " + CommonUtils.hammingDistance(image1FingerPrint, image2FingerPrint));
        }

        // --------------------------------- 委托 ----------------------------------------
        private delegate void invokeUpdateTextBox(string label);

        private void updateTextBox1(string label)
        {
            textBox1.Text = label;
        }

        private void updateTextBox2(string label)
        {
            textBox2.Text = label;
        }

        private void updateTextBoxLabel(object o)
        {
            if (o == null)
            {
                return;
            }

            UpdateModel model = (UpdateModel)o;

            if (model.getTextBox().InvokeRequired)
            {
                if (model.getTextBox().Name.Equals(textBox1.Name))
                {
                    invokeUpdateTextBox invoke = new invokeUpdateTextBox(updateTextBox1);
                    Invoke(invoke, model.getLabel());
                }
                else
                {
                    invokeUpdateTextBox invoke = new invokeUpdateTextBox(updateTextBox2);
                    Invoke(invoke, model.getLabel());
                }
            }
        }
    }
}
