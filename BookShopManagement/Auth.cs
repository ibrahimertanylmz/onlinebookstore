/**
 * @author Enes Solak
 * @date 25.05.2020
 */

using BookShopManagement.Classes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookShopManagement
{
    class Auth
    {
        public static Auth Instance { get; private set; } = new Auth();

        public Boolean Login (string username, string password)
        {
            SqlCommand command = new SqlCommand("select * FROM TBLCUSTOMER WHERE USERNAME=@P1 AND PASSWORD=@P2", Connection.connect);
            if (command.Connection.State != ConnectionState.Open)
                command.Connection.Open();
            command.Parameters.AddWithValue("@P1", username);
            command.Parameters.AddWithValue("@P2", password);
            SqlDataReader dr = command.ExecuteReader();

            if (dr.Read())
            {
                Customer customer = new Customer(Int32.Parse(dr.GetValue(0).ToString()), dr.GetValue(1).ToString(), dr.GetValue(2).ToString(), dr.GetValue(6).ToString(), dr.GetValue(3).ToString(), dr.GetValue(4).ToString(), dr.GetValue(5).ToString());
                Session.Instance.SetCustomer(customer);
                return true;
            }

            dr.Close();

            throw new Exception();
        }

        public void Register (string name, string address, string email, string username, string password, string phone)
        {
            SqlCommand add = new SqlCommand("insert into TBLCUSTOMER (NAME,ADDRESS,EMAIL,USERNAME,PASSWORD,PHONE) VALUES (@P1,@P2,@P3,@P4,@P5,@P6)", Connection.connect);
            if (add.Connection.State != ConnectionState.Open)
                add.Connection.Open();
            add.Parameters.AddWithValue("@P1", name);
            add.Parameters.AddWithValue("@P2", address);
            add.Parameters.AddWithValue("@P3", email);
            add.Parameters.AddWithValue("@P4", username);
            add.Parameters.AddWithValue("@P5", password);
            add.Parameters.AddWithValue("@P6", phone);
            add.ExecuteNonQuery();
        }
    }
}
