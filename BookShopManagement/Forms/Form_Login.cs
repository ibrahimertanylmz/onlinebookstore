/**
 * @author
 * @date
 * 
 * @edited_by Enes Solak 25.05.2020
 */

using BookShopManagement.Components;
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

            try
            {
                if (Auth.Instance.Login(username, password))
                {
                    txtUserName.Text = "";
                    txtPassword.Text = "";

                    Alert.Create("Logged in successfully.", Alert.Type.Success);

                    using (Form_Dashboard fd = new Form_Dashboard())
                    {
                        fd.ShowDialog();
                    }
                }
                else
                {
                    Alert.Create("Username or Password is wrong.", Alert.Type.Error);
                }
            }
            catch (Exception)
            {
                Alert.Create("Didnt connect to database.", Alert.Type.Error);
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