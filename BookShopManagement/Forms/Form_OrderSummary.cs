using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BookShopManagement.Forms;
using BookShopManagement.UserControls;
using BookShopManagement.Classes;
using BookShopManagement.Components;
using BookShopManagement.Properties;
using System.Data.SqlClient;

namespace BookShopManagement.Forms
{
    public partial class Form_OrderSummary : Form
    {
        public Form_OrderSummary()
        {
            InitializeComponent();
            pnlItems.AutoScroll = true;
        }

        private void Form_OrderSummary_Load(object sender, EventArgs e)
        {
            int i = 0;
            SqlCommand command = new SqlCommand("SELECT * FROM TBLPURCHASES WHERE ORDERNO=@P1", Connection.connect);
            if (command.Connection.State != ConnectionState.Open)
                command.Connection.Open();
            command.Parameters.AddWithValue("@P1", UC_History.OrderNO);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                Panel panel = new Panel
                {
                    BackColor = Color.RoyalBlue,
                    Location = new Point(50, 50 + i * 120),
                    Name = "product-" + reader["PRODUCTID"],
                    Size = new Size(400, 70),
                    Dock = DockStyle.Top
                };

                PictureBox productPicture = new PictureBox
                {
                    Anchor = AnchorStyles.None,
                    Dock = DockStyle.Left,
                    Location = new Point(0, 0),
                    Name = "productPicture-" + reader["PRODUCTID"],
                    Image = Utils.Base64StringToBitmap(reader["PICTURE"].ToString()),
                    SizeMode = PictureBoxSizeMode.StretchImage,
                    Size = new Size(55, 60),
                    TabIndex = 0,
                    TabStop = false
                };

                Label productName = new Label
                {
                    Anchor = AnchorStyles.None,
                    AutoSize = true,
                    Font = new Font("Calibri", 15F, FontStyle.Italic, GraphicsUnit.Point, ((byte)(0))),
                    Location = new Point(120, 24),
                    MaximumSize = new Size(140, 24),
                    Name = "productName-" + reader["PRODUCTID"],
                    Size = new Size(140, 24),
                    TabIndex = 2,
                    Text = reader["NAME"].ToString(),
                    ForeColor = Color.White
                };

                Label productQuantity = new Label
                {
                    Anchor = AnchorStyles.None,
                    AutoSize = true,
                    Font = new Font("Calibri", 15F, FontStyle.Italic, GraphicsUnit.Point, ((byte)(0))),
                    Location = new Point(345, 24),
                    Name = "productQuantity-" + reader["PRODUCTID"],
                    Size = new Size(22, 24),
                    TabIndex = 5,
                    Text = reader["QTY"].ToString(),
                    ForeColor = Color.White
                };
                panel.Controls.Add(productPicture);
                panel.Controls.Add(productName);
                panel.Controls.Add(productQuantity);
                pnlItems.Controls.Add(panel);
                i++;
            }
            pnlItems.Controls.Add(pnlHeaders);
            pnlHeaders.Dock = DockStyle.Top;
            reader.Close();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
