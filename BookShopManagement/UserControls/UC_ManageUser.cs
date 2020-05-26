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
    public partial class UC_ManageUser : UserControl
    {
        public UC_ManageUser()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string password = txtPassword.Text;
            if (string.IsNullOrEmpty(password))
            {
                password = Session.Instance.Customer.Password;
            }
            try
            {
                Session.Instance.Customer.Update(txtFirstname.Text, txtLastname.Text, txtAddress.Text, mskPhone.Text, txtEmail.Text, txtUserName.Text, password);
                MessageBox.Show("Your informations are updated", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                MessageBox.Show("Something went wrong.Please try again!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void UC_ManageUser_Load(object sender, EventArgs e)
        {
            txtAddress.Text = Session.Instance.Customer.Adress;
            txtEmail.Text= Session.Instance.Customer.Email;
            txtFirstname.Text = Session.Instance.Customer.FirstName;
            txtLastname.Text = Session.Instance.Customer.LastName;
            mskPhone.Text = Session.Instance.Customer.Phone;
            txtUserName.Text = Session.Instance.Customer.Username;
        }
    }
}