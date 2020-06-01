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
    /**
    * \brief A class that handles the authentications in the program like login and register
    */
    class Auth
    {
        public static Auth Instance { get; private set; } = new Auth();
        /**
        * \brief Login. Checks if the entered user name and password have a match in the sql
        * \param string username: Customer's UserName
        * \param string password: Customer's Password
        */
        public Boolean Login (string username, string password)
        {
            SqlCommand command = new SqlCommand("select * FROM TBLCUSTOMER WHERE USERNAME=@P1 AND PASSWORD=@P2", Connection.connect);
            if (command.Connection.State != ConnectionState.Open)
                command.Connection.Open();
            command.Parameters.AddWithValue("@P1", username);
            command.Parameters.AddWithValue("@P2", password);
            SqlDataReader dr = command.ExecuteReader();

            if (!dr.HasRows)
            {
                dr.Close();
                return false;
            }

            if (dr.Read())
            {
                Customer customer = new Customer(Convert.ToInt16(dr["CUSTOMERID"].ToString()), dr["FIRSTNAME"].ToString(), dr["LASTNAME"].ToString(), dr["ADDRESS"].ToString(),dr["PHONE"].ToString(), dr["EMAIL"].ToString(), dr["USERNAME"].ToString(), dr["PASSWORD"].ToString());
                Session.Instance.SetCustomer(customer);
                dr.Close();
                return true;
            }

            dr.Close();
            return false;
        }
        /**
        * \brief Register. Registers new users in the database
        * \param string name: Customer's Name
        * \param string surname: Customer's Surname
        * \param string address: Customer's Address
        * \param string email: Customer's Email
        * \param string username: Customer's UserName
        * \param string password: Customer's Password
        * \param string phone: Customer's Phone No
        */
        public void Register (string name,string surname, string address, string email, string username, string password, string phone)
        {
            SqlCommand add = new SqlCommand("insert into TBLCUSTOMER (FIRSTNAME,LASTNAME,ADDRESS,EMAIL,USERNAME,PASSWORD,PHONE) VALUES (@P1,@P2,@P3,@P4,@P5,@P6,@P7)", Connection.connect);
            if (add.Connection.State != ConnectionState.Open)
                add.Connection.Open();
            add.Parameters.AddWithValue("@P1", name);
            add.Parameters.AddWithValue("@P2", surname);
            add.Parameters.AddWithValue("@P3", address);
            add.Parameters.AddWithValue("@P4", email);
            add.Parameters.AddWithValue("@P5", username);
            add.Parameters.AddWithValue("@P6", password);
            add.Parameters.AddWithValue("@P7", phone);
            add.ExecuteNonQuery();
        }
    }
}