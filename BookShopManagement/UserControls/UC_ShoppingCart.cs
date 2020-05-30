/**
 * @author Kumbukani KAMANGA
 * @date 26.05.2020
 * 
 * @edited_by Enes Solak 30.05.2020
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
using BookShopManagement.Classes;
using BookShopManagement.Components;
using BookShopManagement.Properties;

namespace BookShopManagement.UserControls
{
    public partial class UC_ShoppingCart : UserControl
    {
        public UC_ShoppingCart()
        {
            InitializeComponent();
        }

        private void UC_ShoppingCart_Load(object sender, EventArgs e)
        {
            LoadItems(true);
        }

        private void LoadItems(bool clear = false)
        {
            double total = 0;
            if (clear)
                pnlCart.Controls.Clear();

            for (var i = 0; i < ShoppingCart.Instance.ItemsToPurchase.Count; i++)
            {
                ItemToPurchase item = (ItemToPurchase)ShoppingCart.Instance.ItemsToPurchase[i];
                total += (item.Quantity * item.Product.Price);

                Panel panel = new Panel
                {
                    BackColor = Color.RoyalBlue,
                    Location = new Point(50, 50 + i * 150),
                    Name = "product-" + item.Product.Id.ToString(),
                    Size = new Size(1300, 100),
                    Dock = DockStyle.Top
                };

                PictureBox productPicture = new PictureBox
                {
                    Anchor = AnchorStyles.None,
                    Location = new Point(330, 3),
                    Name = "productPicture-" + item.Product.Id.ToString(),
                    Image = Utils.Base64StringToBitmap(item.Product.Picture),
                    SizeMode = PictureBoxSizeMode.StretchImage,
                    Size = new Size(55, 60),
                    TabIndex = 0,
                    TabStop = false
                };

                Label productName = new Label
                {
                    Anchor = AnchorStyles.None,
                    AutoSize = true,
                    Font = new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0))),
                    Location = new Point(463, 24),
                    MaximumSize = new Size(200, 0),
                    Name = "productName-" + item.Product.Id.ToString(),
                    Size = new Size(179, 24),
                    TabIndex = 2,
                    Text = item.Product.Name.ToString()
                };

                Label productPrice = new Label
                {
                    Anchor = AnchorStyles.None,
                    AutoSize = true,
                    Font = new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0))),
                    Location = new Point(700, 24),
                    Name = "productPrice-" + item.Product.Id.ToString(),
                    Size = new Size(83, 24),
                    TabIndex = 3,
                    Text = item.Product.Price.ToString("0.00") + " €"
                };

                Label productQuantity = new Label
                {
                    Anchor = AnchorStyles.None,
                    AutoSize = true,
                    Font = new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0))),
                    Location = new Point(229, 24),
                    Name = "productQuantity-" + item.Product.Id.ToString(),
                    Size = new Size(22, 24),
                    TabIndex = 5,
                    Text = item.Quantity.ToString()
                };

                Button buttonDelete = new Button
                {
                    Cursor = Cursors.Hand,
                    Dock = DockStyle.Left,
                    FlatStyle = FlatStyle.Flat,
                    Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0))),
                    ForeColor = Color.White,
                    Image = Resources.trash,
                    Location = new Point(0, 0),
                    Name = "btnDelete-" + item.Product.Id.ToString(),
                    Size = new Size(51, 75),
                    TabIndex = 4,
                    TextImageRelation = TextImageRelation.ImageBeforeText,
                    UseVisualStyleBackColor = true
                };
                buttonDelete.FlatAppearance.BorderSize = 0;
                buttonDelete.FlatAppearance.MouseOverBackColor = Color.Red;
                buttonDelete.Click += ButtonDeleteClick;

                panel.Controls.Add(productPicture);
                panel.Controls.Add(productName);
                panel.Controls.Add(productPrice);
                panel.Controls.Add(productQuantity);
                panel.Controls.Add(buttonDelete);

                pnlCart.Controls.Add(panel);
            }

            pnlCart.Controls.Add(pnlHeaders);
            pnlHeaders.Dock = DockStyle.Top;
            ShoppingCart.Instance.PaymentAmount = total;
            lblTotal.Text = total.ToString() + " €";
        }

        private void ButtonDeleteClick(object sender, EventArgs e)
        {
            string[] name = ((Button)sender).Name.Split('-');
            int id = Convert.ToInt32(name[1]);

            try
            {
                ShoppingCart.Instance.RemoveProductById(id);
                Alert.Create("Item is successfully removed!", Alert.Type.Success);
            }
            catch (Exception)
            {
                Alert.Create("An error occurred!", Alert.Type.Error);
            }

            LoadItems(true);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ShoppingCart.Instance.RemoveProduct(true);
            pnlCart.Controls.Clear();
            lblTotal.Text = "0 €";
            pnlHeaders.Dock = DockStyle.Top;
            pnlCart.Controls.Add(pnlHeaders);
        }

        private void btnAddNewBooks_Click(object sender, EventArgs e)
        {
            if (ShoppingCart.Instance.ItemsToPurchase.Count > 0)
            {
                using (Form_Checkout fch = new Form_Checkout())
                {
                    fch.ShowDialog();
                }
            }
            else
            {
                Alert.Create("Your Cart Is Empty!", Alert.Type.Error);
            }
        }
    }
}
