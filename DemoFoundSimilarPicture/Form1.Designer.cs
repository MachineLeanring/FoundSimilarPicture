namespace DemoFoundSimilarPicture
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.compressButton = new System.Windows.Forms.Button();
            this.imageSimilarMatchButton = new System.Windows.Forms.Button();
            this.fingerPrintButton = new System.Windows.Forms.Button();
            this.compressButton2 = new System.Windows.Forms.Button();
            this.classifyGetButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // compressButton
            // 
            this.compressButton.Location = new System.Drawing.Point(111, 45);
            this.compressButton.Name = "compressButton";
            this.compressButton.Size = new System.Drawing.Size(173, 30);
            this.compressButton.TabIndex = 0;
            this.compressButton.Text = "测试压缩图片";
            this.compressButton.UseVisualStyleBackColor = true;
            this.compressButton.Click += new System.EventHandler(this.compressButtonClick);
            // 
            // imageSimilarMatchButton
            // 
            this.imageSimilarMatchButton.Location = new System.Drawing.Point(111, 182);
            this.imageSimilarMatchButton.Name = "imageSimilarMatchButton";
            this.imageSimilarMatchButton.Size = new System.Drawing.Size(173, 30);
            this.imageSimilarMatchButton.TabIndex = 1;
            this.imageSimilarMatchButton.Text = "测试图片相似度匹配";
            this.imageSimilarMatchButton.UseVisualStyleBackColor = true;
            this.imageSimilarMatchButton.Click += new System.EventHandler(this.imageSimilarMatchButtonClick);
            // 
            // fingerPrintButton
            // 
            this.fingerPrintButton.Location = new System.Drawing.Point(111, 135);
            this.fingerPrintButton.Name = "fingerPrintButton";
            this.fingerPrintButton.Size = new System.Drawing.Size(173, 30);
            this.fingerPrintButton.TabIndex = 2;
            this.fingerPrintButton.Text = "计算图片指纹";
            this.fingerPrintButton.UseVisualStyleBackColor = true;
            this.fingerPrintButton.Click += new System.EventHandler(this.fingerPrintButton_Click);
            // 
            // compressButton2
            // 
            this.compressButton2.Location = new System.Drawing.Point(111, 90);
            this.compressButton2.Name = "compressButton2";
            this.compressButton2.Size = new System.Drawing.Size(173, 30);
            this.compressButton2.TabIndex = 3;
            this.compressButton2.Text = "测试压缩图片2";
            this.compressButton2.UseVisualStyleBackColor = true;
            this.compressButton2.Click += new System.EventHandler(this.compressButton2_Click);
            // 
            // classifyGetButton
            // 
            this.classifyGetButton.Location = new System.Drawing.Point(111, 229);
            this.classifyGetButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.classifyGetButton.Name = "classifyGetButton";
            this.classifyGetButton.Size = new System.Drawing.Size(173, 30);
            this.classifyGetButton.TabIndex = 4;
            this.classifyGetButton.Text = "匹配判定";
            this.classifyGetButton.UseVisualStyleBackColor = true;
            this.classifyGetButton.Click += new System.EventHandler(this.classifyGetButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(391, 319);
            this.Controls.Add(this.classifyGetButton);
            this.Controls.Add(this.compressButton2);
            this.Controls.Add(this.fingerPrintButton);
            this.Controls.Add(this.imageSimilarMatchButton);
            this.Controls.Add(this.compressButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "相似图片匹配";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button compressButton;
        private System.Windows.Forms.Button imageSimilarMatchButton;
        private System.Windows.Forms.Button fingerPrintButton;
        private System.Windows.Forms.Button compressButton2;
        private System.Windows.Forms.Button classifyGetButton;
    }
}

