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
            SqlCommand command = new SqlCommand("select * FROM TBLCUSTOMER WHERE USERNAME=@P1 AND PASSWORD=@P2", Connection.connect);
            if (command.Connection.State != ConnectionState.Open)
            {
                command.Connection.Open();
            }
            command.Parameters.AddWithValue("@P1", txtUserName.Text);
            command.Parameters.AddWithValue("@P2", txtPassword.Text);
            SqlDataReader dr = command.ExecuteReader();
            if (dr.Read())
            {
                Session.Instance.Set_Customer(Int32.Parse(dr.GetValue(0).ToString()), dr.GetValue(1).ToString(), dr.GetValue(2).ToString(), dr.GetValue(3).ToString(), dr.GetValue(4).ToString(), dr.GetValue(6).ToString());
                using (Form_Dashboard fd = new Form_Dashboard())
                {
                    fd.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show("Username or Password is wrong.Please try again!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            dr.Close();
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