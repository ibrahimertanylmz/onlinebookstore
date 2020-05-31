/**
 * @author Ahmad ZAIDAN
 * @date 25.05.2020
 * 
 * @edited_by Kumbukani Kamanga 26.05.2020 
*/


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
using BookShopManagement.Classes;
using System.Data.SqlClient;

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

        private void Form_Checkout_Load(object sender, EventArgs e)
        {
            PersonalInformation();
        }

        void PersonalInformation()
        {
            txtName.Text = Session.Instance.Customer.FirstName.ToString() + " " + Session.Instance.Customer.LastName.ToString();
            txtAdress.Text = Session.Instance.Customer.Adress.ToString();
            mskPhone.Text = Session.Instance.Customer.Phone.ToString();
        }

        private void btnpayment_Click(object sender, EventArgs e)
        {
            if (txtName.Text != "" && txtAdress.Text != "" && mskPhone.MaskCompleted)
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
            else
            {
                if (txtName.Text == "")
                {
                    lblNameText.ForeColor = Color.FromArgb(255, 0, 0);
                }
                else
                {
                    lblNameText.ForeColor = Color.FromArgb(0, 71, 160);
                }
                if (txtAdress.Text == "")
                {
                    lblAddressText.ForeColor = Color.FromArgb(255, 0, 0);
                }
                else
                {
                    lblAddressText.ForeColor = Color.FromArgb(0, 71, 160);
                }    
                if (!mskPhone.MaskCompleted)
                {
                    lblPhoneText.ForeColor = Color.FromArgb(255, 0, 0);
                }
                else
                {
                    lblPhoneText.ForeColor = Color.FromArgb(0, 71, 160);
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
        public void AddControlsToPanel(Control c)
        {
            c.Dock = DockStyle.Fill;
            panelCheckout.Controls.Clear();
            panelCheckout.Controls.Add(c);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
           // this.Dispose();
            ShoppingCart.Instance.CancelOrder();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ShoppingCart.Instance.CancelOrder();
        }

        private void btngift_Click(object sender, EventArgs e)
        {
            txtName.Text = "";
            txtAdress.Text = "";
            mskPhone.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PersonalInformation();
        }
    }
}
