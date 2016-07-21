namespace FoundSimilarPicture
{
    partial class MainForm
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
            this.label7 = new System.Windows.Forms.Label();
            this.perceptionHashFingerPrintButton = new System.Windows.Forms.Button();
            this.matchSimilarImageButton1 = new System.Windows.Forms.Button();
            this.differenceHashFingerPrintButton = new System.Windows.Forms.Button();
            this.testImageCropButton = new System.Windows.Forms.Button();
            this.cosineSimilarityButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // compressButton
            // 
            this.compressButton.Location = new System.Drawing.Point(205, 12);
            this.compressButton.Name = "compressButton";
            this.compressButton.Size = new System.Drawing.Size(60, 30);
            this.compressButton.TabIndex = 0;
            this.compressButton.Text = "浏览";
            this.compressButton.UseVisualStyleBackColor = true;
            this.compressButton.Click += new System.EventHandler(this.compressButtonClick);
            // 
            // imageSimilarMatchButton
            // 
            this.imageSimilarMatchButton.Location = new System.Drawing.Point(205, 120);
            this.imageSimilarMatchButton.Name = "imageSimilarMatchButton";
            this.imageSimilarMatchButton.Size = new System.Drawing.Size(60, 30);
            this.imageSimilarMatchButton.TabIndex = 1;
            this.imageSimilarMatchButton.Text = "测试";
            this.imageSimilarMatchButton.UseVisualStyleBackColor = true;
            this.imageSimilarMatchButton.Click += new System.EventHandler(this.imageSimilarMatchButtonClick);
            // 
            // fingerPrintButton
            // 
            this.fingerPrintButton.Location = new System.Drawing.Point(205, 84);
            this.fingerPrintButton.Name = "fingerPrintButton";
            this.fingerPrintButton.Size = new System.Drawing.Size(60, 30);
            this.fingerPrintButton.TabIndex = 2;
            this.fingerPrintButton.Text = "浏览";
            this.fingerPrintButton.UseVisualStyleBackColor = true;
            this.fingerPrintButton.Click += new System.EventHandler(this.fingerPrintButton_Click);
            // 
            // compressButton2
            // 
            this.compressButton2.Location = new System.Drawing.Point(205, 48);
            this.compressButton2.Name = "compressButton2";
            this.compressButton2.Size = new System.Drawing.Size(60, 30);
            this.compressButton2.TabIndex = 3;
            this.compressButton2.Text = "测试";
            this.compressButton2.UseVisualStyleBackColor = true;
            this.compressButton2.Click += new System.EventHandler(this.compressButton2_Click);
            // 
            // classifyGetButton
            // 
            this.classifyGetButton.Location = new System.Drawing.Point(205, 155);
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
            this.label1.Location = new System.Drawing.Point(12, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "测试压缩图片:";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(12, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "计算图片指纹：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(12, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "测试压缩图片2：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(12, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(168, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "测试图片相似度匹配：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(12, 160);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(168, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "判定图片的分类结果：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(12, 195);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(152, 16);
            this.label6.TabIndex = 10;
            this.label6.Text = "批量测试分类结果：";
            // 
            // classifyGetMoreButton
            // 
            this.classifyGetMoreButton.Location = new System.Drawing.Point(205, 190);
            this.classifyGetMoreButton.Name = "classifyGetMoreButton";
            this.classifyGetMoreButton.Size = new System.Drawing.Size(60, 30);
            this.classifyGetMoreButton.TabIndex = 11;
            this.classifyGetMoreButton.Text = "浏览";
            this.classifyGetMoreButton.UseVisualStyleBackColor = true;
            this.classifyGetMoreButton.Click += new System.EventHandler(this.classifyGetMoreButton_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.Location = new System.Drawing.Point(12, 231);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(136, 16);
            this.label7.TabIndex = 12;
            this.label7.Text = "感知哈希图片指纹";
            // 
            // perceptionHashFingerPrintButton
            // 
            this.perceptionHashFingerPrintButton.Location = new System.Drawing.Point(205, 226);
            this.perceptionHashFingerPrintButton.Name = "perceptionHashFingerPrintButton";
            this.perceptionHashFingerPrintButton.Size = new System.Drawing.Size(60, 30);
            this.perceptionHashFingerPrintButton.TabIndex = 13;
            this.perceptionHashFingerPrintButton.Text = "浏览";
            this.perceptionHashFingerPrintButton.UseVisualStyleBackColor = true;
            this.perceptionHashFingerPrintButton.Click += new System.EventHandler(this.perceptionHashFingerPrintButton_Click);
            // 
            // matchSimilarImageButton1
            // 
            this.matchSimilarImageButton1.Location = new System.Drawing.Point(9, 262);
            this.matchSimilarImageButton1.Name = "matchSimilarImageButton1";
            this.matchSimilarImageButton1.Size = new System.Drawing.Size(256, 30);
            this.matchSimilarImageButton1.TabIndex = 16;
            this.matchSimilarImageButton1.Text = "图片相似度比较";
            this.matchSimilarImageButton1.UseVisualStyleBackColor = true;
            this.matchSimilarImageButton1.Click += new System.EventHandler(this.matchSimilarImageButton1_Click);
            // 
            // differenceHashFingerPrintButton
            // 
            this.differenceHashFingerPrintButton.Location = new System.Drawing.Point(9, 334);
            this.differenceHashFingerPrintButton.Name = "differenceHashFingerPrintButton";
            this.differenceHashFingerPrintButton.Size = new System.Drawing.Size(256, 30);
            this.differenceHashFingerPrintButton.TabIndex = 17;
            this.differenceHashFingerPrintButton.Text = "测试差异哈希算法";
            this.differenceHashFingerPrintButton.UseVisualStyleBackColor = true;
            this.differenceHashFingerPrintButton.Click += new System.EventHandler(this.differenceHashFingerPrintButton_Click);
            // 
            // testImageCropButton
            // 
            this.testImageCropButton.Location = new System.Drawing.Point(9, 370);
            this.testImageCropButton.Name = "testImageCropButton";
            this.testImageCropButton.Size = new System.Drawing.Size(256, 30);
            this.testImageCropButton.TabIndex = 18;
            this.testImageCropButton.Text = "测试图片裁剪";
            this.testImageCropButton.UseVisualStyleBackColor = true;
            this.testImageCropButton.Click += new System.EventHandler(this.testImageCropButton_Click);
            // 
            // cosineSimilarityButton
            // 
            this.cosineSimilarityButton.Location = new System.Drawing.Point(9, 298);
            this.cosineSimilarityButton.Name = "cosineSimilarityButton";
            this.cosineSimilarityButton.Size = new System.Drawing.Size(256, 30);
            this.cosineSimilarityButton.TabIndex = 19;
            this.cosineSimilarityButton.Text = "测试余弦相似性";
            this.cosineSimilarityButton.UseVisualStyleBackColor = true;
            this.cosineSimilarityButton.Click += new System.EventHandler(this.perceptionHashButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(279, 414);
            this.Controls.Add(this.cosineSimilarityButton);
            this.Controls.Add(this.testImageCropButton);
            this.Controls.Add(this.differenceHashFingerPrintButton);
            this.Controls.Add(this.matchSimilarImageButton1);
            this.Controls.Add(this.perceptionHashFingerPrintButton);
            this.Controls.Add(this.label7);
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
            this.Name = "MainForm";
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
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button perceptionHashFingerPrintButton;
        private System.Windows.Forms.Button matchSimilarImageButton1;
        private System.Windows.Forms.Button differenceHashFingerPrintButton;
        private System.Windows.Forms.Button testImageCropButton;
        private System.Windows.Forms.Button cosineSimilarityButton;
    }
}

