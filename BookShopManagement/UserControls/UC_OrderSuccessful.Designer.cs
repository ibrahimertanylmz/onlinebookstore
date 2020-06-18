namespace BookShopManagement.UserControls
{
    partial class UC_OrderSuccessful
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblPhoneText = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPhoneText
            // 
            this.lblPhoneText.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPhoneText.AutoSize = true;
            this.lblPhoneText.Font = new System.Drawing.Font("Century Gothic", 18F);
            this.lblPhoneText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.lblPhoneText.Location = new System.Drawing.Point(120, 301);
            this.lblPhoneText.Name = "lblPhoneText";
            this.lblPhoneText.Size = new System.Drawing.Size(492, 30);
            this.lblPhoneText.TabIndex = 53;
            this.lblPhoneText.Text = "Your Order Was Completed Successfully";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::BookShopManagement.Properties.Resources.qcBBexbc5;
            this.pictureBox1.Location = new System.Drawing.Point(226, 46);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(269, 200);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 54;
            this.pictureBox1.TabStop = false;
            // 
            // UC_OrderSuccessful
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblPhoneText);
            this.Name = "UC_OrderSuccessful";
            this.Size = new System.Drawing.Size(719, 506);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPhoneText;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
