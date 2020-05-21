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
                SqlCommand add = new SqlCommand("insert into TBLCUSTOMER (NAME,ADDRESS,EMAIL,USERNAME,PASSWORD,PHONE) VALUES (@P1,@P2,@P3,@P4,@P5,@P6)", Connection.connect);
                if (add.Connection.State != ConnectionState.Open)
                {
                    add.Connection.Open();
                }
                add.Parameters.AddWithValue("@P1", txtName.Text);
                add.Parameters.AddWithValue("@P2", txtAdress.Text);
                add.Parameters.AddWithValue("@P3", txtEmail.Text);
                add.Parameters.AddWithValue("@P4", txtUserName.Text);
                add.Parameters.AddWithValue("@P5", txtPassword.Text);
                add.Parameters.AddWithValue("@P6", mskPhone.Text);
                add.ExecuteNonQuery();
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