/**
 * @author Ahmad Zaidan
 * @date
 * 
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using BookShopManagement.Forms;
using BookShopManagement.Classes;

namespace BookShopManagement.UserControls
{
    public partial class UC_Magazines : UserControl
    {
        public UC_Magazines()
        {
            InitializeComponent();
            leftPanel.AutoScroll = true;
            lblName.Text = "";
            lblIssue.Text = "";
            lblType.Text = "";
            lblPublisher.Text = "";
            lblPage.Text = "";
        }

        private void UC_Magazines_Load(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM TBLPRODUCT WHERE PTYPE=@P1", Connection.connect);
            if (command.Connection.State != ConnectionState.Open)
                command.Connection.Open();
            command.Parameters.AddWithValue("@P1", "Magazine");
            SqlDataReader reader = command.ExecuteReader();

            int count = 0;
            while (reader.Read())
            {
                Panel panel = new Panel
                {
                    BackColor = Color.FromArgb(220,20,60),
                    Location = new Point(50 + count % 3 * 300, 50 + (int)(Math.Floor((decimal)count / 3) * 250)),
                    Name = "product-" + reader["ID"].ToString(),
                    Size = new Size(250, 200),
                };

                PictureBox pictureBox = new PictureBox
                {
                    Image = Utils.Base64StringToBitmap(reader["PICTURE"].ToString()),
                    Location = new Point(155, 20),
                    Name = "picture-" + reader["ID"].ToString(),
                    Size = new Size(75, 100),
                    SizeMode = PictureBoxSizeMode.Zoom,
                    TabStop = false
                };

                Label name = new Label
                {
                    Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0))),
                    ForeColor = Color.White,
                    Location = new Point(20, 20),
                    Name = "name-" + reader["ID"].ToString(),
                    Size = new Size(145, 80),
                    Text = reader["NAME"].ToString()
                };

                Label price = new Label
                {
                    AutoSize = true,
                    Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0))),
                    ForeColor = Color.White,
                    Location = new Point(20, 100),
                    Name = "price-" + reader["ID"].ToString(),
                    Size = new Size(145, 30),
                    Text = reader["PRICE"].ToString() + " €"
                };

                Button button = new Button
                {
                    BackColor = Color.FromArgb(234, 60, 83),
                    FlatStyle = FlatStyle.Flat,
                    Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0))),
                    ForeColor = Color.White,
                    Location = new Point(20, 150),
                    Name = "btnDetail-" + reader["ID"].ToString(),
                    Size = new Size(210, 30),
                    Text = "Show Details",
                    UseVisualStyleBackColor = false,
                    Cursor = Cursors.Hand
                };
                button.FlatAppearance.BorderSize = 0;
                button.Click += OnPanelClick;

                panel.Controls.Add(pictureBox);
                panel.Controls.Add(price);
                panel.Controls.Add(name);
                panel.Controls.Add(button);

                this.leftPanel.Controls.Add(panel);

                count++;
            }
            if (count == 0)
            {
                groupBox1.Visible = true;
            }

            reader.Close();
        }
        private void OnPanelClick(object sender, EventArgs e)
        {
            string[] name = ((Button)sender).Name.Split('-');

            Magazine magazine = Magazine.CreateFromID(int.Parse(name[1]));

            lblName.Text = magazine.Name;
            lblIssue.Text = magazine.Issue;
            lblType.Text = magazine.Type;
            lblPublisher.Text = magazine.Publisher;
            lblPage.Text = magazine.Page.ToString();
        }
    }
}
