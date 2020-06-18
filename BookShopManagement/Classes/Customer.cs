/**
 * @author İbrahim Ertan Yılmaz  
 * @date 25.05.2020
 * 
 * @edited_by Enes Solak 25.05.2020
 */

using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookShopManagement.Classes
{
    class Customer 
    {
        public int CustomerID { get; protected set; }
        public string FirstName { get; protected set; }
        public string LastName { get; protected set; }
        public string Adress { get; protected set; }
        public string Phone { get; protected set; }
        public string Email { get; protected set; }
        public string Username { get; protected set; }
        public string Password { get; protected set; }
        /**
         * @brief : Constructor function for customer.
         * @param CustomerID: Id of customer.
         * @param FirstName: Firstname of customer.
         * @param LastName: Lastname of customer.
         * @param Adress: Adress of customer.
         * @param Phone: Phone number of customer.
         * @param Email: Email of customer.
         * @param Username: Username of customer.
         * @param Password: Password of customer.
         */
        public Customer(int CustomerID, string FirstName,string LastName, string Adress, string Phone, string Email, string Username, string Password)
        {
            this.CustomerID = CustomerID;
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Adress = Adress;
            this.Phone = Phone;
            this.Email = Email;
            this.Username = Username;
            this.Password = Password;
        }

        /**
        * @brief : Gets data of customer from database and updates. 
        */
        public void Update(string firstname,string lastname, string address, string phone ,string email,string username, string password)
        {
            SqlCommand update = new SqlCommand("UPDATE TBLCUSTOMER SET FIRSTNAME=@P1,LASTNAME=@P2,ADDRESS=@P3,EMAIL=@P4,USERNAME=@P5,PASSWORD=@P6,PHONE=@P7 WHERE CUSTOMERID="+CustomerID, Connection.connect);
            update.Parameters.AddWithValue("@P1", firstname);
            update.Parameters.AddWithValue("@P2", lastname);
            update.Parameters.AddWithValue("@P3", address);
            update.Parameters.AddWithValue("@P4", email);
            update.Parameters.AddWithValue("@P5", username);
            update.Parameters.AddWithValue("@P6", password);
            update.Parameters.AddWithValue("@P7", phone);
            update.ExecuteNonQuery();
            Connection.connect.Close();
           
            this.FirstName = firstname;
            this.LastName = lastname;
            this.Adress = address;
            this.Phone = phone;
            this.Email = email;
            this.Username = username;
            this.Password = password;
        }

    }
}