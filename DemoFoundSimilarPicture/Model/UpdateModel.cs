/***********************************************************************

** Author:      Q-WHai
** Create Date: 2016/7/20 11:02:19
** Last Modify: 2016/7/20 11:02:19
** desc：       尚未编写描述
** Ver.:        V0.1.0

************************************************************************/

using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Text;

namespace DemoFoundSimilarPicture.Model
{
    public class UpdateModel
    {
        private TextBox textBox = null;
        private string label = string.Empty;

        public UpdateModel()
        {
        }

        public UpdateModel(TextBox textBox, string label)
        {
            this.textBox = textBox;
            this.label = label;
        }

        public TextBox getTextBox()
        {
            return textBox;
        }

        public string getLabel()
        {
            return label;
        }
    }
}
