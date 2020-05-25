using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookShopManagement.Forms
{
    public partial class Form_Register : Form
    {
        public Form_Register()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
                this.Dispose();
        }

        private void btnregister_Click(object sender, EventArgs e)
        {
            try
            {
                string name = txtName.Text;
                string address = txtAdress.Text;
                string email = txtEmail.Text;
                string username = txtUserName.Text;
                string password = txtPassword.Text;
                string phone = mskPhone.Text;

                Auth.Instance.Register(name, address, email, username, password, phone);

                MessageBox.Show("Congratulations new register!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
            }
            catch (Exception)
            {
                MessageBox.Show("Something went wrong! Please try again", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}