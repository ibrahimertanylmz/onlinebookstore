/**
 * @author Kumbukani KAMANGA
 * @date 26.05.2020
 * 
 *  @edited_by Enes Solak 30.05.2020
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

        internal void UC_ShoppingCart_Load(object sender, EventArgs e)
        {          
            LoadItems(true);           
        }

        private void LoadItems(bool clear = false)
        {
            if (clear)            
                pnlCart.Controls.Clear();

            for (var i = 0; i < ShoppingCart.Instance.ItemsToPurchase.Count; i++)
            {
                ItemToPurchase item = (ItemToPurchase)ShoppingCart.Instance.ItemsToPurchase[i];                     
                item = (ItemToPurchase)ShoppingCart.Instance.ItemsToPurchase[i];
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
                    Text = item.Product.Name.ToString(),
                    ForeColor = Color.White
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
                    Text = "€" + item.Product.Price.ToString("0.00"),
                    ForeColor = Color.White
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
                    Text = item.Quantity.ToString(),
                    ForeColor = Color.White
                };

                Button btnDelete = new Button
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

                btnDelete.FlatAppearance.BorderSize = 0;
                btnDelete.FlatAppearance.MouseOverBackColor = Color.Red;
                btnDelete.Click += btnDelete_Click;
                panel.Controls.Add(productPicture);
                panel.Controls.Add(productName);
                panel.Controls.Add(productPrice);
                panel.Controls.Add(productQuantity);
                panel.Controls.Add(btnDelete);
                pnlCart.Controls.Add(panel);
            }
            pnlCart.Controls.Add(pnlHeaders);
            pnlHeaders.Dock = DockStyle.Top;            
            lblTotal.Text = "€" + (ShoppingCart.Instance.PaymentAmount).ToString("0.00");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string[] name = ((Button)sender).Name.Split('-');
            int id = Convert.ToInt32(name[1]);
            try
            {
                ShoppingCart.Instance.RemoveProductByID(id);
                Alert.Create("Item removed from cart!", Alert.Type.Success);
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
            lblTotal.Text = "€0.00";
            pnlHeaders.Dock = DockStyle.Top;
            pnlCart.Controls.Add(pnlHeaders);
        }

        private void btnCheckout_Click(object sender, EventArgs e)
        {
            ShoppingCart.PlaceOrder();
        }

        private void tmrDelete_Tick(object sender, EventArgs e)
        {
            LoadItems(true);
            tmrDelete.Stop();
        }
    }
}
