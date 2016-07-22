namespace FoundSimilarPicture
{
    partial class BatchSimilarImageMatchForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BatchSimilarImageMatchForm));
            this.similarImageResultListView = new System.Windows.Forms.ListView();
            this.batchImageMatchImageList = new System.Windows.Forms.ImageList(this.components);
            this.SuspendLayout();
            // 
            // similarImageResultListView
            // 
            this.similarImageResultListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.similarImageResultListView.Location = new System.Drawing.Point(0, 0);
            this.similarImageResultListView.Name = "similarImageResultListView";
            this.similarImageResultListView.Size = new System.Drawing.Size(315, 374);
            this.similarImageResultListView.TabIndex = 0;
            this.similarImageResultListView.UseCompatibleStateImageBehavior = false;
            // 
            // batchImageMatchImageList
            // 
            this.batchImageMatchImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("batchImageMatchImageList.ImageStream")));
            this.batchImageMatchImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.batchImageMatchImageList.Images.SetKeyName(0, "20160718160413.jpg");
            this.batchImageMatchImageList.Images.SetKeyName(1, "20160718160529.jpg");
            this.batchImageMatchImageList.Images.SetKeyName(2, "20160718160538.jpg");
            this.batchImageMatchImageList.Images.SetKeyName(3, "20160718160546.jpg");
            this.batchImageMatchImageList.Images.SetKeyName(4, "20160718160554.jpg");
            this.batchImageMatchImageList.Images.SetKeyName(5, "20160718160602.jpg");
            this.batchImageMatchImageList.Images.SetKeyName(6, "20160719084347.jpg");
            this.batchImageMatchImageList.Images.SetKeyName(7, "20160719084743.jpg");
            this.batchImageMatchImageList.Images.SetKeyName(8, "20160719084855.jpg");
            this.batchImageMatchImageList.Images.SetKeyName(9, "20160719113014.jpg");
            this.batchImageMatchImageList.Images.SetKeyName(10, "20160719113028.jpg");
            this.batchImageMatchImageList.Images.SetKeyName(11, "20160719113038.jpg");
            this.batchImageMatchImageList.Images.SetKeyName(12, "20160719134331.jpg");
            this.batchImageMatchImageList.Images.SetKeyName(13, "20160719134453.jpg");
            this.batchImageMatchImageList.Images.SetKeyName(14, "20160719134505.jpg");
            this.batchImageMatchImageList.Images.SetKeyName(15, "20160719134514.jpg");
            this.batchImageMatchImageList.Images.SetKeyName(16, "20160719134522.jpg");
            this.batchImageMatchImageList.Images.SetKeyName(17, "20160719134530.jpg");
            this.batchImageMatchImageList.Images.SetKeyName(18, "20160719134539.jpg");
            this.batchImageMatchImageList.Images.SetKeyName(19, "20160719134920.jpg");
            this.batchImageMatchImageList.Images.SetKeyName(20, "20160719135028.jpg");
            this.batchImageMatchImageList.Images.SetKeyName(21, "20160719135044.jpg");
            this.batchImageMatchImageList.Images.SetKeyName(22, "20160719135109.jpg");
            this.batchImageMatchImageList.Images.SetKeyName(23, "20160719135220.jpg");
            this.batchImageMatchImageList.Images.SetKeyName(24, "20160719135427.jpg");
            this.batchImageMatchImageList.Images.SetKeyName(25, "20160719135643.jpg");
            // 
            // BatchSimilarImageMatchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(315, 374);
            this.Controls.Add(this.similarImageResultListView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "BatchSimilarImageMatchForm";
            this.Text = "BatchSimilarImageMatchForm";
            this.Load += new System.EventHandler(this.BatchSimilarImageMatchForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView similarImageResultListView;
        private System.Windows.Forms.ImageList batchImageMatchImageList;
    }
}