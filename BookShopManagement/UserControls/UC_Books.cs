﻿/**
 * @author Ahmad Zaidan
 * @date
 * 
 * @edited_by Enes Solak 26.05.2020
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
using BookShopManagement.Forms;
using System.Data.SqlClient;
using BookShopManagement.Classes;
using BookShopManagement.Components;

namespace BookShopManagement.UserControls
{
    public partial class UC_Books : UserControl
    {
        ItemToPurchase item = new ItemToPurchase();
        int lastbutton = -1;
        public UC_Books()
        {
            InitializeComponent();
            leftPanel.AutoScroll = true;
            lblPrice.Text = "€0.00";
            lblQty.Text = "0";
            lblName.Text = "";
            lblISBN.Text = "";
            lblAuthor.Text = "";
            lblPublisher.Text = "";
            lblPage.Text = "";
        }

        private void UC_Books_Load(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM TBLPRODUCT WHERE PTYPE=@P1", Connection.connect);
            if (command.Connection.State != ConnectionState.Open)
                command.Connection.Open();
            command.Parameters.AddWithValue("@P1", "Book");
            SqlDataReader reader = command.ExecuteReader();

            int count = 0;
            while (reader.Read())
            {
                Panel panel = new Panel
                {
                    BackColor = Color.FromArgb(39, 174, 96),
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
                    Text = "€" + reader["PRICE"].ToString()
                };

                Button button = new Button
                {
                    BackColor = Color.FromArgb(46, 204, 113),
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
            if (count==0)
            {
                groupBox1.Visible = true;
            }
           
            reader.Close();
        }

        private void OnPanelClick (object sender, EventArgs e)
        {
            string[] name = ((Button)sender).Name.Split('-');
            if (int.Parse(name[1]) != lastbutton)
            {
                Book book = Book.CreateFromID(int.Parse(name[1]));

                item.Product = book;
                item.Quantity = 1;
                lblName.Text = book.Name;
                lblISBN.Text = book.ISBN;
                lblAuthor.Text = book.Author;
                lblPublisher.Text = book.Publisher;
                lblPage.Text = book.Page.ToString();
                lblQty.Text = item.Quantity.ToString();
                lblPrice.Text = "€" + (item.Quantity * item.Product.Price).ToString("0.00");
            }
            lastbutton = int.Parse(name[1]);
        }

        private void btnIncrease_Click(object sender, EventArgs e)
        {
            try
            {
                if (item.Product.Name != "")
                {
                    item.Quantity++;
                    lblQty.Text = item.Quantity.ToString();
                    lblPrice.Text = "€" + (item.Quantity * item.Product.Price).ToString("0.00");
                }
            }
            catch (Exception) { }
        }
        private void btnDecrease_Click(object sender, EventArgs e)
        {
            try
            {
                if (item.Quantity > 0) { item.Quantity--; }
                lblQty.Text = item.Quantity.ToString();
                lblPrice.Text = "€" + (item.Quantity * item.Product.Price).ToString("0.00");
            }
            catch (Exception) { }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                int found = 0;
                if (item.Product.Name != "")
                {
                    ItemToPurchase itemtoadd = new ItemToPurchase();
                    itemtoadd.Product = item.Product;
                    itemtoadd.Quantity = item.Quantity;
                    for (var i = 0; i < Classes.ShoppingCart.Instance.ItemsToPurchase.Count; i++)
                    {
                        Classes.ItemToPurchase listitem = new Classes.ItemToPurchase();
                        listitem = (Classes.ItemToPurchase)Classes.ShoppingCart.Instance.ItemsToPurchase[i];
                        if(listitem.Product.Id== itemtoadd.Product.Id)
                        {
                            listitem.Quantity += itemtoadd.Quantity;
                            item.Quantity = 1;
                            found = 1;
                            lblQty.Text = item.Quantity.ToString();
                            lblPrice.Text = "€" + (item.Quantity * item.Product.Price).ToString("0.00");
                            break;
                        }
                    }
                    if (found == 0)
                    {
                        ShoppingCart.Instance.AddProduct(itemtoadd);
                        item.Quantity = 1;
                        lblQty.Text = item.Quantity.ToString();
                        lblPrice.Text = "€" + (item.Quantity * item.Product.Price).ToString("0.00");
                    }
                    Alert.Create("Item Added To Cart", Alert.Type.Added);
                }
            }
            catch (Exception) { };
        }
    }
}
