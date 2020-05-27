using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BookShopManagement.Classes;

namespace BookShopManagement.UserControls
{
    public partial class UC_Payment : UserControl
    {
        public UC_Payment()
        {
            InitializeComponent();
            lblPrice.Text = ShoppingCart.Instance.PaymentAmount.ToString() + " €";
        }
    }
}
