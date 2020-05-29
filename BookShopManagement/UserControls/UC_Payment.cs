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
using BookShopManagement.UserControls;

namespace BookShopManagement.UserControls
{
    public partial class UC_Payment : UserControl
    {
        public UC_Payment()
        {
            InitializeComponent();
            lblPrice.Text = ShoppingCart.Instance.PaymentAmount.ToString() + " €";
        }

        private void btnpayment_Click(object sender, EventArgs e)
        {
            if(txtName.Text != "" && mskCardNo.MaskCompleted && mskCVV.MaskCompleted && mskDate.MaskCompleted)
            {
                UC_OrderSuccessful uco = new UC_OrderSuccessful();
                AddControlsToPanel(uco);
            }
        }
        private void AddControlsToPanel(Control c)
        {
            c.Dock = DockStyle.Fill;
            panelCard.Controls.Clear();
            panelCard.Controls.Add(c);
        }
    }
}
