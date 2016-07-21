namespace FoundSimilarPicture
{
    partial class CorpImageForm
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
            this.imageFullNameTextBox = new System.Windows.Forms.TextBox();
            this.corpImageBrowseButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.locationXTextBox = new System.Windows.Forms.TextBox();
            this.locationYTextBox = new System.Windows.Forms.TextBox();
            this.sizeWTextBox = new System.Windows.Forms.TextBox();
            this.sizeHTextBox = new System.Windows.Forms.TextBox();
            this.imageCorpButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // imageFullNameTextBox
            // 
            this.imageFullNameTextBox.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.imageFullNameTextBox.Location = new System.Drawing.Point(13, 29);
            this.imageFullNameTextBox.Name = "imageFullNameTextBox";
            this.imageFullNameTextBox.Size = new System.Drawing.Size(275, 26);
            this.imageFullNameTextBox.TabIndex = 0;
            // 
            // corpImageBrowseButton
            // 
            this.corpImageBrowseButton.Location = new System.Drawing.Point(316, 27);
            this.corpImageBrowseButton.Name = "corpImageBrowseButton";
            this.corpImageBrowseButton.Size = new System.Drawing.Size(60, 30);
            this.corpImageBrowseButton.TabIndex = 1;
            this.corpImageBrowseButton.Text = "浏览";
            this.corpImageBrowseButton.UseVisualStyleBackColor = true;
            this.corpImageBrowseButton.Click += new System.EventHandler(this.corpImageBrowseButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(12, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "X =";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(12, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Y =";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(12, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "W =";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(13, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "H =";
            // 
            // locationXTextBox
            // 
            this.locationXTextBox.Location = new System.Drawing.Point(51, 68);
            this.locationXTextBox.Name = "locationXTextBox";
            this.locationXTextBox.Size = new System.Drawing.Size(100, 21);
            this.locationXTextBox.TabIndex = 6;
            this.locationXTextBox.Text = "0";
            // 
            // locationYTextBox
            // 
            this.locationYTextBox.Location = new System.Drawing.Point(50, 96);
            this.locationYTextBox.Name = "locationYTextBox";
            this.locationYTextBox.Size = new System.Drawing.Size(100, 21);
            this.locationYTextBox.TabIndex = 7;
            this.locationYTextBox.Text = "0";
            // 
            // sizeWTextBox
            // 
            this.sizeWTextBox.Location = new System.Drawing.Point(51, 132);
            this.sizeWTextBox.Name = "sizeWTextBox";
            this.sizeWTextBox.Size = new System.Drawing.Size(100, 21);
            this.sizeWTextBox.TabIndex = 8;
            this.sizeWTextBox.Text = "1";
            // 
            // sizeHTextBox
            // 
            this.sizeHTextBox.Location = new System.Drawing.Point(51, 159);
            this.sizeHTextBox.Name = "sizeHTextBox";
            this.sizeHTextBox.Size = new System.Drawing.Size(100, 21);
            this.sizeHTextBox.TabIndex = 9;
            this.sizeHTextBox.Text = "1";
            // 
            // imageCorpButton
            // 
            this.imageCorpButton.Location = new System.Drawing.Point(108, 200);
            this.imageCorpButton.Name = "imageCorpButton";
            this.imageCorpButton.Size = new System.Drawing.Size(180, 30);
            this.imageCorpButton.TabIndex = 10;
            this.imageCorpButton.Text = "裁 剪";
            this.imageCorpButton.UseVisualStyleBackColor = true;
            this.imageCorpButton.Click += new System.EventHandler(this.imageCorpButton_Click);
            // 
            // CorpImageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(391, 245);
            this.Controls.Add(this.imageCorpButton);
            this.Controls.Add(this.sizeHTextBox);
            this.Controls.Add(this.sizeWTextBox);
            this.Controls.Add(this.locationYTextBox);
            this.Controls.Add(this.locationXTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.corpImageBrowseButton);
            this.Controls.Add(this.imageFullNameTextBox);
            this.Name = "CorpImageForm";
            this.Text = "CorpImageForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox imageFullNameTextBox;
        private System.Windows.Forms.Button corpImageBrowseButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox locationXTextBox;
        private System.Windows.Forms.TextBox locationYTextBox;
        private System.Windows.Forms.TextBox sizeWTextBox;
        private System.Windows.Forms.TextBox sizeHTextBox;
        private System.Windows.Forms.Button imageCorpButton;
    }
}