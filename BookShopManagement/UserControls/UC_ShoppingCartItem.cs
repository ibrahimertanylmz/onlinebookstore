/**
 * @author Kumbukani KAMANGA
 * @date 26.05.2020
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

namespace BookShopManagement.UserControls
{
    public partial class UC_ShoppingCartItem : UserControl
    {
        Classes.ItemToPurchase item = new Classes.ItemToPurchase();

        public UC_ShoppingCartItem(Classes.ItemToPurchase item)
        {
            InitializeComponent();
            lblQuantity.Text = item.Quantity.ToString();
            lblProductName.Text = item.Product.Name;
            lblPrice.Text = "€" + item.Product.Price.ToString("0.00");
            picProductIcon.Image = Utils.Base64StringToBitmap(item.Product.Picture);
            picProductIcon.SizeMode = PictureBoxSizeMode.StretchImage;
            this.item = item;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {            
            Classes.ShoppingCart.Instance.RemoveProduct(item);
            UC_ShoppingCart sc = new UC_ShoppingCart();
            // UC_ShoppingCart.LoadItems(true);
        }
    }
}
