namespace FoundSimilarPicture
{
    partial class ImageShowForm
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
            this.bitmapShowPictureBox = new System.Windows.Forms.PictureBox();
            this.bitmapSaveButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bitmapShowPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // bitmapShowPictureBox
            // 
            this.bitmapShowPictureBox.Location = new System.Drawing.Point(74, 12);
            this.bitmapShowPictureBox.Name = "bitmapShowPictureBox";
            this.bitmapShowPictureBox.Size = new System.Drawing.Size(150, 150);
            this.bitmapShowPictureBox.TabIndex = 0;
            this.bitmapShowPictureBox.TabStop = false;
            // 
            // bitmapSaveButton
            // 
            this.bitmapSaveButton.Location = new System.Drawing.Point(95, 189);
            this.bitmapSaveButton.Name = "bitmapSaveButton";
            this.bitmapSaveButton.Size = new System.Drawing.Size(100, 30);
            this.bitmapSaveButton.TabIndex = 1;
            this.bitmapSaveButton.Text = "保 存";
            this.bitmapSaveButton.UseVisualStyleBackColor = true;
            this.bitmapSaveButton.Click += new System.EventHandler(this.bitmapSaveButton_Click);
            // 
            // ImageShowForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 231);
            this.Controls.Add(this.bitmapSaveButton);
            this.Controls.Add(this.bitmapShowPictureBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ImageShowForm";
            this.Text = "ImageShowForm";
            this.Load += new System.EventHandler(this.ImageShowForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bitmapShowPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox bitmapShowPictureBox;
        private System.Windows.Forms.Button bitmapSaveButton;
    }
}