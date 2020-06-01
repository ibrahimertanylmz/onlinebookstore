using BookShopManagement.Classes;

namespace BookShopManagement.Forms
{
    partial class Form_Checkout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Checkout));
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelPayment = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblHouseText = new System.Windows.Forms.Label();
            this.txtHouseNo = new System.Windows.Forms.TextBox();
            this.btnpayment = new System.Windows.Forms.Button();
            this.lblNameText = new System.Windows.Forms.Label();
            this.lblAddressText = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtAdress = new System.Windows.Forms.TextBox();
            this.lblPhoneText = new System.Windows.Forms.Label();
            this.mskPhone = new System.Windows.Forms.MaskedTextBox();
            this.lblCityText = new System.Windows.Forms.Label();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbCard = new System.Windows.Forms.RadioButton();
            this.rbCash = new System.Windows.Forms.RadioButton();
            this.panelCheckout = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panelCheckout.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(60, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(184, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Esogu Book Store";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.panel1.Controls.Add(this.panelPayment);
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(719, 57);
            this.panel1.TabIndex = 24;
            // 
            // panelPayment
            // 
            this.panelPayment.Location = new System.Drawing.Point(0, 58);
            this.panelPayment.Name = "panelPayment";
            this.panelPayment.Size = new System.Drawing.Size(719, 509);
            this.panelPayment.TabIndex = 39;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.btnExit.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.Location = new System.Drawing.Point(658, 0);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(61, 57);
            this.btnExit.TabIndex = 4;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            this.btnExit.Click += Logger.LogButtonClick;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(10, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 46);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // lblHouseText
            // 
            this.lblHouseText.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblHouseText.AutoSize = true;
            this.lblHouseText.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblHouseText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.lblHouseText.Location = new System.Drawing.Point(180, 333);
            this.lblHouseText.Name = "lblHouseText";
            this.lblHouseText.Size = new System.Drawing.Size(158, 21);
            this.lblHouseText.TabIndex = 49;
            this.lblHouseText.Text = "Building/House NO:";
            // 
            // txtHouseNo
            // 
            this.txtHouseNo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtHouseNo.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHouseNo.Location = new System.Drawing.Point(184, 360);
            this.txtHouseNo.Name = "txtHouseNo";
            this.txtHouseNo.Size = new System.Drawing.Size(354, 31);
            this.txtHouseNo.TabIndex = 47;
            // 
            // btnpayment
            // 
            this.btnpayment.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnpayment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.btnpayment.FlatAppearance.BorderSize = 0;
            this.btnpayment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnpayment.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnpayment.ForeColor = System.Drawing.Color.White;
            this.btnpayment.Location = new System.Drawing.Point(184, 477);
            this.btnpayment.Name = "btnpayment";
            this.btnpayment.Size = new System.Drawing.Size(166, 55);
            this.btnpayment.TabIndex = 48;
            this.btnpayment.Text = "Proceed To Payment...";
            this.btnpayment.UseVisualStyleBackColor = false;
            this.btnpayment.Click += new System.EventHandler(this.btnpayment_Click);
            this.btnpayment.Click += Logger.LogButtonClick;
            // 
            // lblNameText
            // 
            this.lblNameText.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblNameText.AutoSize = true;
            this.lblNameText.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblNameText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.lblNameText.Location = new System.Drawing.Point(180, 41);
            this.lblNameText.Name = "lblNameText";
            this.lblNameText.Size = new System.Drawing.Size(62, 21);
            this.lblNameText.TabIndex = 51;
            this.lblNameText.Text = "Name:";
            // 
            // lblAddressText
            // 
            this.lblAddressText.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblAddressText.AutoSize = true;
            this.lblAddressText.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAddressText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.lblAddressText.Location = new System.Drawing.Point(180, 257);
            this.lblAddressText.Name = "lblAddressText";
            this.lblAddressText.Size = new System.Drawing.Size(65, 21);
            this.lblAddressText.TabIndex = 50;
            this.lblAddressText.Text = "Adress:";
            // 
            // txtName
            // 
            this.txtName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtName.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(184, 68);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(354, 31);
            this.txtName.TabIndex = 43;
            // 
            // txtAdress
            // 
            this.txtAdress.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtAdress.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAdress.Location = new System.Drawing.Point(184, 284);
            this.txtAdress.Name = "txtAdress";
            this.txtAdress.Size = new System.Drawing.Size(354, 31);
            this.txtAdress.TabIndex = 46;
            // 
            // lblPhoneText
            // 
            this.lblPhoneText.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPhoneText.AutoSize = true;
            this.lblPhoneText.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPhoneText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.lblPhoneText.Location = new System.Drawing.Point(180, 114);
            this.lblPhoneText.Name = "lblPhoneText";
            this.lblPhoneText.Size = new System.Drawing.Size(63, 21);
            this.lblPhoneText.TabIndex = 52;
            this.lblPhoneText.Text = "Phone:";
            // 
            // mskPhone
            // 
            this.mskPhone.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mskPhone.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.mskPhone.Location = new System.Drawing.Point(184, 138);
            this.mskPhone.Mask = "(999) 000-0000";
            this.mskPhone.Name = "mskPhone";
            this.mskPhone.Size = new System.Drawing.Size(354, 31);
            this.mskPhone.TabIndex = 44;
            // 
            // lblCityText
            // 
            this.lblCityText.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCityText.AutoSize = true;
            this.lblCityText.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCityText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.lblCityText.Location = new System.Drawing.Point(180, 188);
            this.lblCityText.Name = "lblCityText";
            this.lblCityText.Size = new System.Drawing.Size(45, 21);
            this.lblCityText.TabIndex = 53;
            this.lblCityText.Text = "City:";
            // 
            // txtCity
            // 
            this.txtCity.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCity.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCity.Location = new System.Drawing.Point(184, 215);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(354, 31);
            this.txtCity.TabIndex = 45;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.label1.Location = new System.Drawing.Point(180, 405);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 21);
            this.label1.TabIndex = 54;
            this.label1.Text = "Payment Method:";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.Controls.Add(this.rbCard);
            this.groupBox1.Controls.Add(this.rbCash);
            this.groupBox1.Location = new System.Drawing.Point(184, 429);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(354, 41);
            this.groupBox1.TabIndex = 55;
            this.groupBox1.TabStop = false;
            // 
            // rbCard
            // 
            this.rbCard.AutoSize = true;
            this.rbCard.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.rbCard.Location = new System.Drawing.Point(6, 16);
            this.rbCard.Name = "rbCard";
            this.rbCard.Size = new System.Drawing.Size(171, 25);
            this.rbCard.TabIndex = 6;
            this.rbCard.TabStop = true;
            this.rbCard.Text = "Credit/Debit Card";
            this.rbCard.UseVisualStyleBackColor = true;
            // 
            // rbCash
            // 
            this.rbCash.AutoSize = true;
            this.rbCash.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.rbCash.Location = new System.Drawing.Point(237, 16);
            this.rbCash.Name = "rbCash";
            this.rbCash.Size = new System.Drawing.Size(68, 25);
            this.rbCash.TabIndex = 7;
            this.rbCash.TabStop = true;
            this.rbCash.Text = "Cash";
            this.rbCash.UseVisualStyleBackColor = true;
            this.rbCash.CheckedChanged += new System.EventHandler(this.rbCash_CheckedChanged);
            // 
            // panelCheckout
            // 
            this.panelCheckout.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelCheckout.Controls.Add(this.btnCancel);
            this.panelCheckout.Controls.Add(this.groupBox1);
            this.panelCheckout.Controls.Add(this.label1);
            this.panelCheckout.Controls.Add(this.txtCity);
            this.panelCheckout.Controls.Add(this.lblCityText);
            this.panelCheckout.Controls.Add(this.mskPhone);
            this.panelCheckout.Controls.Add(this.lblPhoneText);
            this.panelCheckout.Controls.Add(this.txtAdress);
            this.panelCheckout.Controls.Add(this.txtName);
            this.panelCheckout.Controls.Add(this.lblAddressText);
            this.panelCheckout.Controls.Add(this.lblNameText);
            this.panelCheckout.Controls.Add(this.btnpayment);
            this.panelCheckout.Controls.Add(this.txtHouseNo);
            this.panelCheckout.Controls.Add(this.lblHouseText);
            this.panelCheckout.Location = new System.Drawing.Point(0, 108);
            this.panelCheckout.Name = "panelCheckout";
            this.panelCheckout.Size = new System.Drawing.Size(719, 557);
            this.panelCheckout.TabIndex = 25;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(372, 477);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(166, 55);
            this.btnCancel.TabIndex = 56;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            this.btnCancel.Click += Logger.LogButtonClick;
            // 
            // Form_Checkout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(719, 666);
            this.Controls.Add(this.panelCheckout);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_Checkout";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Form_Checkout";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panelCheckout.ResumeLayout(false);
            this.panelCheckout.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelPayment;
        private System.Windows.Forms.Label lblHouseText;
        private System.Windows.Forms.TextBox txtHouseNo;
        private System.Windows.Forms.Button btnpayment;
        private System.Windows.Forms.Label lblNameText;
        private System.Windows.Forms.Label lblAddressText;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtAdress;
        private System.Windows.Forms.Label lblPhoneText;
        private System.Windows.Forms.MaskedTextBox mskPhone;
        private System.Windows.Forms.Label lblCityText;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbCard;
        private System.Windows.Forms.RadioButton rbCash;
        private System.Windows.Forms.Panel panelCheckout;
        private System.Windows.Forms.Button btnCancel;
    }
}