using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BookShopManagement.Forms;
using BookShopManagement.Classes;
using BookShopManagement.Components;
using BookShopManagement.Properties;
using System.Data.SqlClient;

namespace BookShopManagement.UserControls
{
    public partial class UC_History : UserControl
    {   public static string OrderNO;
        public UC_History()
        {
            InitializeComponent();
            Loaditems();
        }
        private void Loaditems()
        {
            int i = 0;
            SqlCommand command = new SqlCommand("SELECT * FROM TBLORDERS WHERE ID=@P1", Connection.connect);
            if (command.Connection.State != ConnectionState.Open)
                command.Connection.Open();
            command.Parameters.AddWithValue("@P1", Session.Instance.Customer.CustomerID);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                Panel panel = new Panel
                {
                    BackColor = Color.RoyalBlue,
                    Location = new Point(50, 50 + i * 120),
                    Name = "product-" + reader["ORDERNO"].ToString(),
                    Size = new Size(980, 70),
                    Dock = DockStyle.Top
                };

                Label OrderNO = new Label
                {
                    Anchor = AnchorStyles.None,
                    AutoSize = true,
                    Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0))),
                    Location = new Point(60,34),
                    MaximumSize = new Size(400, 0),
                    Name = "productName-" + reader["ORDERNO"].ToString(),
                    Size = new Size(179, 34),
                    TabIndex = 2,
                    Text = reader["ORDERNO"].ToString(),
                    ForeColor = Color.White
                };

                Label OrderPrice = new Label
                {
                    Anchor = AnchorStyles.None,
                    AutoSize = true,
                    Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0))),
                    Location = new Point(310, 34),
                    Name = "OrderPrice-" + reader["ORDERNO"].ToString(),
                    Size = new Size(83, 24),
                    TabIndex = 3,
                    Text = "€" + reader["PRICE"].ToString(),
                    ForeColor = Color.White
                };
                Button button = new Button
                {
                    Cursor = Cursors.Hand,
                    FlatStyle = FlatStyle.Flat,
                    Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0))),
                    ForeColor = Color.White,
                    Location = new Point(480, 24),
                    Name = "ShowDetails-" + reader["ORDERNO"].ToString(),
                    Size = new Size(140, 35),
                    Text="Show Details",
                    TabIndex = 4,
                    UseVisualStyleBackColor = true
                };
                button.Click += OnPanelClick;
                panel.Controls.Add(OrderNO);
                panel.Controls.Add(OrderPrice);
                panel.Controls.Add(button);
                pnlOrders.Controls.Add(panel);
            }
            pnlOrders.Controls.Add(pnlHeaders);
            pnlHeaders.Dock = DockStyle.Top;
            reader.Close();
        }
        private void OnPanelClick(object sender, EventArgs e)
        {
            string[] name = ((Button)sender).Name.Split('-');
            OrderNO = name[1];
            using (Form_OrderSummary os = new Form_OrderSummary())
            {
                os.ShowDialog();
            }
        }
    }
}
