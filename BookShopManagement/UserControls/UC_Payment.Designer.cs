using BookShopManagement.Classes;

namespace BookShopManagement.UserControls
{
    partial class UC_Payment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_Payment));
            this.panelCard = new System.Windows.Forms.Panel();
            this.lblPrice = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblCVVText = new System.Windows.Forms.Label();
            this.lblExpiryText = new System.Windows.Forms.Label();
            this.mskCVV = new System.Windows.Forms.MaskedTextBox();
            this.mskDate = new System.Windows.Forms.MaskedTextBox();
            this.lblCardNoText = new System.Windows.Forms.Label();
            this.lblNameText = new System.Windows.Forms.Label();
            this.mskCardNo = new System.Windows.Forms.MaskedTextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.btnpayment = new System.Windows.Forms.Button();
            this.pBPayment = new System.Windows.Forms.PictureBox();
            this.panelCard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBPayment)).BeginInit();
            this.SuspendLayout();
            // 
            // panelCard
            // 
            this.panelCard.Controls.Add(this.lblPrice);
            this.panelCard.Controls.Add(this.label4);
            this.panelCard.Controls.Add(this.lblCVVText);
            this.panelCard.Controls.Add(this.lblExpiryText);
            this.panelCard.Controls.Add(this.mskCVV);
            this.panelCard.Controls.Add(this.mskDate);
            this.panelCard.Controls.Add(this.lblCardNoText);
            this.panelCard.Controls.Add(this.lblNameText);
            this.panelCard.Controls.Add(this.mskCardNo);
            this.panelCard.Controls.Add(this.txtName);
            this.panelCard.Controls.Add(this.btnpayment);
            this.panelCard.Controls.Add(this.pBPayment);
            this.panelCard.Location = new System.Drawing.Point(0, 0);
            this.panelCard.Name = "panelCard";
            this.panelCard.Size = new System.Drawing.Size(719, 506);
            this.panelCard.TabIndex = 43;
            // 
            // lblPrice
            // 
            this.lblPrice.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.lblPrice.Location = new System.Drawing.Point(335, 386);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(79, 21);
            this.lblPrice.TabIndex = 54;
            this.lblPrice.Text = "Amount ";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.label4.Location = new System.Drawing.Point(180, 386);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 21);
            this.label4.TabIndex = 53;
            this.label4.Text = "Amount To Pay:";
            // 
            // lblCVVText
            // 
            this.lblCVVText.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCVVText.AutoSize = true;
            this.lblCVVText.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCVVText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.lblCVVText.Location = new System.Drawing.Point(441, 287);
            this.lblCVVText.Name = "lblCVVText";
            this.lblCVVText.Size = new System.Drawing.Size(49, 21);
            this.lblCVVText.TabIndex = 52;
            this.lblCVVText.Text = "CVV:";
            // 
            // lblExpiryText
            // 
            this.lblExpiryText.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblExpiryText.AutoSize = true;
            this.lblExpiryText.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblExpiryText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.lblExpiryText.Location = new System.Drawing.Point(180, 287);
            this.lblExpiryText.Name = "lblExpiryText";
            this.lblExpiryText.Size = new System.Drawing.Size(102, 21);
            this.lblExpiryText.TabIndex = 51;
            this.lblExpiryText.Text = "Expiry Date:";
            // 
            // mskCVV
            // 
            this.mskCVV.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mskCVV.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.mskCVV.Location = new System.Drawing.Point(445, 325);
            this.mskCVV.Mask = "000";
            this.mskCVV.Name = "mskCVV";
            this.mskCVV.PasswordChar = '•';
            this.mskCVV.Size = new System.Drawing.Size(93, 31);
            this.mskCVV.TabIndex = 4;
            // 
            // mskDate
            // 
            this.mskDate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mskDate.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.mskDate.Location = new System.Drawing.Point(184, 325);
            this.mskDate.Mask = "00/00";
            this.mskDate.Name = "mskDate";
            this.mskDate.Size = new System.Drawing.Size(93, 31);
            this.mskDate.TabIndex = 3;
            // 
            // lblCardNoText
            // 
            this.lblCardNoText.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCardNoText.AutoSize = true;
            this.lblCardNoText.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCardNoText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.lblCardNoText.Location = new System.Drawing.Point(180, 207);
            this.lblCardNoText.Name = "lblCardNoText";
            this.lblCardNoText.Size = new System.Drawing.Size(121, 21);
            this.lblCardNoText.TabIndex = 48;
            this.lblCardNoText.Text = "Card Number:";
            // 
            // lblNameText
            // 
            this.lblNameText.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblNameText.AutoSize = true;
            this.lblNameText.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblNameText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.lblNameText.Location = new System.Drawing.Point(180, 140);
            this.lblNameText.Name = "lblNameText";
            this.lblNameText.Size = new System.Drawing.Size(134, 21);
            this.lblNameText.TabIndex = 47;
            this.lblNameText.Text = "Name On Card:";
            // 
            // mskCardNo
            // 
            this.mskCardNo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mskCardNo.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.mskCardNo.Location = new System.Drawing.Point(184, 241);
            this.mskCardNo.Mask = "0000-0000-0000-0000";
            this.mskCardNo.Name = "mskCardNo";
            this.mskCardNo.Size = new System.Drawing.Size(354, 31);
            this.mskCardNo.TabIndex = 2;
            // 
            // txtName
            // 
            this.txtName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtName.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(184, 164);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(354, 31);
            this.txtName.TabIndex = 1;
            // 
            // btnpayment
            // 
            this.btnpayment.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnpayment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.btnpayment.FlatAppearance.BorderSize = 0;
            this.btnpayment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnpayment.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnpayment.ForeColor = System.Drawing.Color.White;
            this.btnpayment.Location = new System.Drawing.Point(184, 427);
            this.btnpayment.Name = "btnpayment";
            this.btnpayment.Size = new System.Drawing.Size(354, 39);
            this.btnpayment.TabIndex = 5;
            this.btnpayment.Text = "Pay";
            this.btnpayment.UseVisualStyleBackColor = false;
            this.btnpayment.Click += new System.EventHandler(this.btnpayment_Click);
            this.btnpayment.Click += Logger.LogButtonClick;
            // 
            // pBPayment
            // 
            this.pBPayment.Image = ((System.Drawing.Image)(resources.GetObject("pBPayment.Image")));
            this.pBPayment.Location = new System.Drawing.Point(184, 40);
            this.pBPayment.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.pBPayment.Name = "pBPayment";
            this.pBPayment.Size = new System.Drawing.Size(354, 79);
            this.pBPayment.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pBPayment.TabIndex = 43;
            this.pBPayment.TabStop = false;
            // 
            // UC_Payment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelCard);
            this.Name = "UC_Payment";
            this.Size = new System.Drawing.Size(719, 506);
            this.panelCard.ResumeLayout(false);
            this.panelCard.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBPayment)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelCard;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblCVVText;
        private System.Windows.Forms.Label lblExpiryText;
        private System.Windows.Forms.MaskedTextBox mskCVV;
        private System.Windows.Forms.MaskedTextBox mskDate;
        private System.Windows.Forms.Label lblCardNoText;
        private System.Windows.Forms.Label lblNameText;
        private System.Windows.Forms.MaskedTextBox mskCardNo;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button btnpayment;
        private System.Windows.Forms.PictureBox pBPayment;
    }
}
