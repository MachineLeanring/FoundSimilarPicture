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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.classifyGetMoreButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // compressButton
            // 
            this.compressButton.Location = new System.Drawing.Point(205, 28);
            this.compressButton.Name = "compressButton";
            this.compressButton.Size = new System.Drawing.Size(60, 30);
            this.compressButton.TabIndex = 0;
            this.compressButton.Text = "浏览";
            this.compressButton.UseVisualStyleBackColor = true;
            this.compressButton.Click += new System.EventHandler(this.compressButtonClick);
            // 
            // imageSimilarMatchButton
            // 
            this.imageSimilarMatchButton.Location = new System.Drawing.Point(205, 176);
            this.imageSimilarMatchButton.Name = "imageSimilarMatchButton";
            this.imageSimilarMatchButton.Size = new System.Drawing.Size(60, 30);
            this.imageSimilarMatchButton.TabIndex = 1;
            this.imageSimilarMatchButton.Text = "测试";
            this.imageSimilarMatchButton.UseVisualStyleBackColor = true;
            this.imageSimilarMatchButton.Click += new System.EventHandler(this.imageSimilarMatchButtonClick);
            // 
            // fingerPrintButton
            // 
            this.fingerPrintButton.Location = new System.Drawing.Point(205, 130);
            this.fingerPrintButton.Name = "fingerPrintButton";
            this.fingerPrintButton.Size = new System.Drawing.Size(60, 30);
            this.fingerPrintButton.TabIndex = 2;
            this.fingerPrintButton.Text = "浏览";
            this.fingerPrintButton.UseVisualStyleBackColor = true;
            this.fingerPrintButton.Click += new System.EventHandler(this.fingerPrintButton_Click);
            // 
            // compressButton2
            // 
            this.compressButton2.Location = new System.Drawing.Point(205, 80);
            this.compressButton2.Name = "compressButton2";
            this.compressButton2.Size = new System.Drawing.Size(60, 30);
            this.compressButton2.TabIndex = 3;
            this.compressButton2.Text = "测试";
            this.compressButton2.UseVisualStyleBackColor = true;
            this.compressButton2.Click += new System.EventHandler(this.compressButton2_Click);
            // 
            // classifyGetButton
            // 
            this.classifyGetButton.Location = new System.Drawing.Point(205, 223);
            this.classifyGetButton.Margin = new System.Windows.Forms.Padding(2);
            this.classifyGetButton.Name = "classifyGetButton";
            this.classifyGetButton.Size = new System.Drawing.Size(60, 30);
            this.classifyGetButton.TabIndex = 4;
            this.classifyGetButton.Text = "浏览";
            this.classifyGetButton.UseVisualStyleBackColor = true;
            this.classifyGetButton.Click += new System.EventHandler(this.classifyGetButton_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(12, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "测试压缩图片:";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(12, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "计算图片指纹：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(12, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "测试压缩图片2：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(12, 181);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(168, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "测试图片相似度匹配：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(12, 228);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(168, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "判定图片的分类结果：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(12, 274);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(152, 16);
            this.label6.TabIndex = 10;
            this.label6.Text = "批量测试分类结果：";
            // 
            // classifyGetMoreButton
            // 
            this.classifyGetMoreButton.Location = new System.Drawing.Point(205, 269);
            this.classifyGetMoreButton.Name = "classifyGetMoreButton";
            this.classifyGetMoreButton.Size = new System.Drawing.Size(60, 30);
            this.classifyGetMoreButton.TabIndex = 11;
            this.classifyGetMoreButton.Text = "浏览";
            this.classifyGetMoreButton.UseVisualStyleBackColor = true;
            this.classifyGetMoreButton.Click += new System.EventHandler(this.classifyGetMoreButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(287, 316);
            this.Controls.Add(this.classifyGetMoreButton);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
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
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button compressButton;
        private System.Windows.Forms.Button imageSimilarMatchButton;
        private System.Windows.Forms.Button fingerPrintButton;
        private System.Windows.Forms.Button compressButton2;
        private System.Windows.Forms.Button classifyGetButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button classifyGetMoreButton;
    }
}

