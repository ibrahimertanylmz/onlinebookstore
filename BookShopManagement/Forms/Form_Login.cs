/**
 * @author
 * @date
 * 
 * @edited_by Enes Solak 25.05.2020
 */ 
 
using BookShopManagement.Forms;
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

namespace BookShopManagement
{
    public partial class Form_Login : Form
    {
        public Form_Login()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUserName.Text;
            string password = txtPassword.Text;

            if (Auth.Instance.Login(username, password))
            {
                txtUserName.Text = "";
                txtPassword.Text = "";

                using (Form_Dashboard fd = new Form_Dashboard())
                {
                    fd.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show("Username or Password is wrong.Please try again!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void linkLabelRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            using (Form_Register fr = new Form_Register())
            {
                fr.ShowDialog();
            }
        }
    }
}