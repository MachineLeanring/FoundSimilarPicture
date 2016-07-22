namespace FoundSimilarPicture
{
    partial class ImagesCompareForm
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
            this.imagesComparePictureBox1 = new System.Windows.Forms.PictureBox();
            this.imagesComparePictureBox2 = new System.Windows.Forms.PictureBox();
            this.imagesCompareResultLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.imagesComparePictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagesComparePictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // imagesComparePictureBox1
            // 
            this.imagesComparePictureBox1.Location = new System.Drawing.Point(12, 12);
            this.imagesComparePictureBox1.Name = "imagesComparePictureBox1";
            this.imagesComparePictureBox1.Size = new System.Drawing.Size(100, 100);
            this.imagesComparePictureBox1.TabIndex = 0;
            this.imagesComparePictureBox1.TabStop = false;
            // 
            // imagesComparePictureBox2
            // 
            this.imagesComparePictureBox2.Location = new System.Drawing.Point(154, 12);
            this.imagesComparePictureBox2.Name = "imagesComparePictureBox2";
            this.imagesComparePictureBox2.Size = new System.Drawing.Size(100, 100);
            this.imagesComparePictureBox2.TabIndex = 1;
            this.imagesComparePictureBox2.TabStop = false;
            // 
            // imagesCompareResultLabel
            // 
            this.imagesCompareResultLabel.AutoSize = true;
            this.imagesCompareResultLabel.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.imagesCompareResultLabel.Location = new System.Drawing.Point(12, 143);
            this.imagesCompareResultLabel.Name = "imagesCompareResultLabel";
            this.imagesCompareResultLabel.Size = new System.Drawing.Size(72, 16);
            this.imagesCompareResultLabel.TabIndex = 2;
            this.imagesCompareResultLabel.Text = "比较结果";
            // 
            // ImagesCompareForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(266, 179);
            this.Controls.Add(this.imagesCompareResultLabel);
            this.Controls.Add(this.imagesComparePictureBox2);
            this.Controls.Add(this.imagesComparePictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ImagesCompareForm";
            this.Text = "ImagesCompareForm";
            this.Load += new System.EventHandler(this.ImagesCompareForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imagesComparePictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagesComparePictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox imagesComparePictureBox1;
        private System.Windows.Forms.PictureBox imagesComparePictureBox2;
        private System.Windows.Forms.Label imagesCompareResultLabel;
    }
}