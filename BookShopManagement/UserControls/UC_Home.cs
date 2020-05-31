/**
 * @author İbrahim Ertan Yılmaz  
 * @date 31.05.2020
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace BookShopManagement.UserControls
{
    public partial class UC_Home : UserControl
    {
        public UC_Home()
        {
            InitializeComponent();
        }

        private void UC_Home_Load(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("SELECT TOP 2 * FROM TBLPRODUCT WHERE PTYPE=@P1 ORDER BY ID DESC", Connection.connect);
            if (command.Connection.State != ConnectionState.Open)
                command.Connection.Open();
            command.Parameters.AddWithValue("@P1", "Book");
            SqlDataReader reader = command.ExecuteReader();

            if (reader.Read())
            {
                lastbookname.Text= reader["NAME"].ToString();
                lastbookpicture.Image = Utils.Base64StringToBitmap(reader["PICTURE"].ToString());
                lastbookprice.Text = reader["PRICE"].ToString() + " €";   
            }

            if (reader.Read())
            {
                previouslastbookname.Text = reader["NAME"].ToString();
                previouslastbookpicture.Image = Utils.Base64StringToBitmap(reader["PICTURE"].ToString());
                previouslastbookprice.Text = reader["PRICE"].ToString() + " €";
            }

            reader.Close();       

            SqlCommand command2 = new SqlCommand("SELECT TOP 2 * FROM TBLPRODUCT WHERE PTYPE=@P2 ORDER BY ID DESC", Connection.connect);
            if (command2.Connection.State != ConnectionState.Open)
                command2.Connection.Open();
            command2.Parameters.AddWithValue("@P2", "Magazine");
            SqlDataReader reader2 = command2.ExecuteReader();

            if (reader2.Read())
            {
                lastmagazinename.Text = reader2["NAME"].ToString();
                lastmagazinepicture.Image = Utils.Base64StringToBitmap(reader2["PICTURE"].ToString());
                lastmagazineprice.Text = reader2["PRICE"].ToString() + " €";
            }

            if (reader2.Read())
            {
                previouslastmagazinename.Text = reader2["NAME"].ToString();
                previouslastmagazinepicture.Image = Utils.Base64StringToBitmap(reader2["PICTURE"].ToString());
                previouslastmagazineprice.Text = reader2["PRICE"].ToString() + " €";
            }

            reader2.Close();

            SqlCommand command3 = new SqlCommand("SELECT TOP 2 * FROM TBLPRODUCT WHERE PTYPE=@P3 ORDER BY ID DESC", Connection.connect);
            if (command3.Connection.State != ConnectionState.Open)
                command3.Connection.Open();
            command3.Parameters.AddWithValue("@P3", "MusicCd");
            SqlDataReader reader3 = command3.ExecuteReader();

            if (reader3.Read())
            {
                lastmusicCDname.Text = reader3["NAME"].ToString();
                lastmusicCDpicture.Image = Utils.Base64StringToBitmap(reader3["PICTURE"].ToString());
                lastmusicCDprice.Text = reader3["PRICE"].ToString() + " €";
            }

            if (reader3.Read())
            {
                previouslastmusicCDname.Text = reader3["NAME"].ToString();
                previouslastmusicCDpicture.Image = Utils.Base64StringToBitmap(reader3["PICTURE"].ToString());
                previouslastmusicCDprice.Text = reader3["PRICE"].ToString() + " €";
            }

            reader3.Close();
        }
    }
}