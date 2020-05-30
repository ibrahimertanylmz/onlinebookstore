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
using BookShopManagement.Classes;
using BookShopManagement.Components;

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
            for (var i= 0;i < ShoppingCart.Instance.ItemsToPurchase.Count;i++)
            {
                ItemToPurchase item = new ItemToPurchase();
                item = (ItemToPurchase)ShoppingCart.Instance.ItemsToPurchase[i];
                total += (item.Quantity * item.Product.Price);
                UC_ShoppingCartItem product = new UC_ShoppingCartItem(item);
                product.Dock = DockStyle.Top;
                pnlCart.Controls.Add(product);
            }
            pnlCart.Controls.Add(pnlHeaders);
            pnlHeaders.Dock = DockStyle.Top;
            ShoppingCart.Instance.PaymentAmount = total;
            lblTotal.Text = total.ToString() + " €";
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
