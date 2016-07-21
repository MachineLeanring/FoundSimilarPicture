namespace FoundSimilarPicture
{
    partial class MatchSimilarImageForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.averageHashRadioButton = new System.Windows.Forms.RadioButton();
            this.perceptionHashRadioButton = new System.Windows.Forms.RadioButton();
            this.differenceHashRadioButton = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.hammingDistanceRadioButton = new System.Windows.Forms.RadioButton();
            this.cosineSimilarityRadioButton = new System.Windows.Forms.RadioButton();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Courier New", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(12, 27);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(350, 23);
            this.textBox1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(385, 24);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(60, 30);
            this.button1.TabIndex = 1;
            this.button1.Text = "浏览";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Courier New", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(12, 70);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(350, 23);
            this.textBox2.TabIndex = 2;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(385, 64);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(60, 30);
            this.button2.TabIndex = 3;
            this.button2.Text = "浏览";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(102, 270);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(246, 30);
            this.button3.TabIndex = 4;
            this.button3.Text = "匹 配";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(12, 228);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(371, 28);
            this.label1.TabIndex = 5;
            this.label1.Text = "注：汉明距离的范围为 [0, 15]，取值越大，相似度越小。\r\n    余弦相似度范围为 [0, 1]，取值越大，相似度越小。";
            // 
            // averageHashRadioButton
            // 
            this.averageHashRadioButton.AutoSize = true;
            this.averageHashRadioButton.Checked = true;
            this.averageHashRadioButton.Location = new System.Drawing.Point(3, 17);
            this.averageHashRadioButton.Name = "averageHashRadioButton";
            this.averageHashRadioButton.Size = new System.Drawing.Size(71, 16);
            this.averageHashRadioButton.TabIndex = 6;
            this.averageHashRadioButton.TabStop = true;
            this.averageHashRadioButton.Text = "平均哈希";
            this.averageHashRadioButton.UseVisualStyleBackColor = true;
            // 
            // perceptionHashRadioButton
            // 
            this.perceptionHashRadioButton.AutoSize = true;
            this.perceptionHashRadioButton.Location = new System.Drawing.Point(163, 17);
            this.perceptionHashRadioButton.Name = "perceptionHashRadioButton";
            this.perceptionHashRadioButton.Size = new System.Drawing.Size(71, 16);
            this.perceptionHashRadioButton.TabIndex = 7;
            this.perceptionHashRadioButton.TabStop = true;
            this.perceptionHashRadioButton.Text = "感知哈希";
            this.perceptionHashRadioButton.UseVisualStyleBackColor = true;
            // 
            // differenceHashRadioButton
            // 
            this.differenceHashRadioButton.AutoSize = true;
            this.differenceHashRadioButton.Location = new System.Drawing.Point(310, 17);
            this.differenceHashRadioButton.Name = "differenceHashRadioButton";
            this.differenceHashRadioButton.Size = new System.Drawing.Size(71, 16);
            this.differenceHashRadioButton.TabIndex = 8;
            this.differenceHashRadioButton.TabStop = true;
            this.differenceHashRadioButton.Text = "差异哈希";
            this.differenceHashRadioButton.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.averageHashRadioButton);
            this.panel1.Controls.Add(this.differenceHashRadioButton);
            this.panel1.Controls.Add(this.perceptionHashRadioButton);
            this.panel1.Location = new System.Drawing.Point(28, 115);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(384, 47);
            this.panel1.TabIndex = 9;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.cosineSimilarityRadioButton);
            this.panel2.Controls.Add(this.hammingDistanceRadioButton);
            this.panel2.Location = new System.Drawing.Point(28, 168);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(234, 38);
            this.panel2.TabIndex = 10;
            // 
            // hammingDistanceRadioButton
            // 
            this.hammingDistanceRadioButton.AutoSize = true;
            this.hammingDistanceRadioButton.Checked = true;
            this.hammingDistanceRadioButton.Location = new System.Drawing.Point(3, 12);
            this.hammingDistanceRadioButton.Name = "hammingDistanceRadioButton";
            this.hammingDistanceRadioButton.Size = new System.Drawing.Size(71, 16);
            this.hammingDistanceRadioButton.TabIndex = 0;
            this.hammingDistanceRadioButton.TabStop = true;
            this.hammingDistanceRadioButton.Text = "汉明距离";
            this.hammingDistanceRadioButton.UseVisualStyleBackColor = true;
            // 
            // cosineSimilarityRadioButton
            // 
            this.cosineSimilarityRadioButton.AutoSize = true;
            this.cosineSimilarityRadioButton.Location = new System.Drawing.Point(160, 12);
            this.cosineSimilarityRadioButton.Name = "cosineSimilarityRadioButton";
            this.cosineSimilarityRadioButton.Size = new System.Drawing.Size(71, 16);
            this.cosineSimilarityRadioButton.TabIndex = 1;
            this.cosineSimilarityRadioButton.TabStop = true;
            this.cosineSimilarityRadioButton.Text = "余弦定理";
            this.cosineSimilarityRadioButton.UseVisualStyleBackColor = true;
            // 
            // MatchSimilarImageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 312);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Name = "MatchSimilarImageForm";
            this.Text = "比较图片相似度";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton averageHashRadioButton;
        private System.Windows.Forms.RadioButton perceptionHashRadioButton;
        private System.Windows.Forms.RadioButton differenceHashRadioButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton hammingDistanceRadioButton;
        private System.Windows.Forms.RadioButton cosineSimilarityRadioButton;
    }
}