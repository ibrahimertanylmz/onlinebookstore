namespace BookShopManagement.UserControls
{
    partial class UC_History
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
            this.pnlHeaders = new System.Windows.Forms.Panel();
            this.lblProductName = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblOrderNo = new System.Windows.Forms.Label();
            this.pnlOrders = new System.Windows.Forms.Panel();
            this.pnlHeaders.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHeaders
            // 
            this.pnlHeaders.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.pnlHeaders.Controls.Add(this.lblProductName);
            this.pnlHeaders.Controls.Add(this.lblPrice);
            this.pnlHeaders.Controls.Add(this.lblOrderNo);
            this.pnlHeaders.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeaders.Location = new System.Drawing.Point(0, 0);
            this.pnlHeaders.Name = "pnlHeaders";
            this.pnlHeaders.Size = new System.Drawing.Size(985, 45);
            this.pnlHeaders.TabIndex = 1;
            // 
            // lblProductName
            // 
            this.lblProductName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblProductName.AutoSize = true;
            this.lblProductName.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductName.ForeColor = System.Drawing.Color.White;
            this.lblProductName.Location = new System.Drawing.Point(312, 10);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(45, 19);
            this.lblProductName.TabIndex = 3;
            this.lblProductName.Text = "Total";
            // 
            // lblPrice
            // 
            this.lblPrice.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.ForeColor = System.Drawing.Color.White;
            this.lblPrice.Location = new System.Drawing.Point(519, 10);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(59, 19);
            this.lblPrice.TabIndex = 1;
            this.lblPrice.Text = "Details";
            // 
            // lblOrderNo
            // 
            this.lblOrderNo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblOrderNo.AutoSize = true;
            this.lblOrderNo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrderNo.ForeColor = System.Drawing.Color.White;
            this.lblOrderNo.Location = new System.Drawing.Point(64, 10);
            this.lblOrderNo.Name = "lblOrderNo";
            this.lblOrderNo.Size = new System.Drawing.Size(82, 19);
            this.lblOrderNo.TabIndex = 0;
            this.lblOrderNo.Text = "Order NO";
            // 
            // pnlOrders
            // 
            this.pnlOrders.AutoScroll = true;
            this.pnlOrders.Location = new System.Drawing.Point(0, 0);
            this.pnlOrders.Name = "pnlOrders";
            this.pnlOrders.Size = new System.Drawing.Size(985, 577);
            this.pnlOrders.TabIndex = 2;
            // 
            // UC_History
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlHeaders);
            this.Controls.Add(this.pnlOrders);
            this.Name = "UC_History";
            this.Size = new System.Drawing.Size(985, 580);
            this.pnlHeaders.ResumeLayout(false);
            this.pnlHeaders.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeaders;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblOrderNo;
        private System.Windows.Forms.Panel pnlOrders;
    }
}
