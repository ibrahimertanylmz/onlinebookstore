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
using BookShopManagement.Forms;

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
           // pnlHeaders.Dock = DockStyle.Top;
            LoadItems(true);
           
        }

        private void LoadItems(bool clear = false)
        {
            double total = 0;
            if (clear)
            {
                pnlCart.Controls.Clear();
            }
            for (var i= 0;i < Classes.ShoppingCart.Instance.ItemsToPurchase.Count;i++)
            {
                Classes.ItemToPurchase item = new Classes.ItemToPurchase();
                item = (Classes.ItemToPurchase)Classes.ShoppingCart.Instance.ItemsToPurchase[i];
                total += (item.Quantity * item.Product.Price);
                UC_ShoppingCartItem product = new UC_ShoppingCartItem(item);
                product.Dock = DockStyle.Top;
                pnlCart.Controls.Add(product);
            }
            pnlCart.Controls.Add(pnlHeaders);
            pnlHeaders.Dock = DockStyle.Top;
            lblTotal.Text = total.ToString() + " €";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Classes.ShoppingCart.Instance.RemoveProduct(true);
            pnlCart.Controls.Clear();
            lblTotal.Text = "0 €";
            pnlHeaders.Dock = DockStyle.Top;
            pnlCart.Controls.Add(pnlHeaders);
        }
    }
}
