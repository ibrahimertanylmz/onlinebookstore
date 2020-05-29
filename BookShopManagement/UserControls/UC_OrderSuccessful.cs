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
    public partial class UC_OrderSuccessful : UserControl
    {
        public UC_OrderSuccessful()
        {
            InitializeComponent();
            Classes.ShoppingCart.Instance.RemoveProduct(true);
        }
    }
}
