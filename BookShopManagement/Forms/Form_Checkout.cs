using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BookShopManagement.UserControls;

namespace BookShopManagement.Forms
{
    public partial class Form_Checkout : Form
    {
        public Form_Checkout()
        {
            InitializeComponent();
            rbCard.Checked = true;
            Console.WriteLine("Button Pressed");
        }

        private void btnpayment_Click(object sender, EventArgs e)
        {
            if (txtName.Text !="" && txtAdress.Text !="" && txtHouseNo.Text !="" &&txtCity.Text != "" && mskPhone.MaskCompleted)
            {
                if (rbCard.Checked)
                {
                    UC_Payment ucp = new UC_Payment();
                    AddControlsToPanel(ucp);
                }
                else
                {
                    UC_OrderSuccessful uco = new UC_OrderSuccessful();
                    AddControlsToPanel(uco);
                }
            }
        }
        private void rbCash_CheckedChanged(object sender, EventArgs e)
        {
            if (rbCash.Checked)
            {
                btnpayment.Text = "Finish Order";
            }
            else
            {
                btnpayment.Text = "Proceed To Payment...";
            }
        }
        private void AddControlsToPanel(Control c)
        {
            c.Dock = DockStyle.Fill;
            panelCheckout.Controls.Clear();
            panelCheckout.Controls.Add(c);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
