/**
 * @author İbrahim Ertan Yılmaz  
 * @date 25.05.2020
 * 
 * @edited_by Enes Solak 26.05.2020
 */

using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookShopManagement.Classes
{
    class Book : Product
    {
        public string ISBN { get; protected set; }
        public string Author { get; protected set; }
        public string Publisher { get; protected set; }
        public int Page { get; protected set; }
        public Book(int Id, string Name, double Price, int Quantity, string Picture, string ISBN, string Author, string Publisher, int Page)
        {
            this.ISBN = ISBN;
            this.Author = Author;
            this.Publisher = Publisher;
            this.Page = Page;
            this.Name = Name;
            this.Id = Id;
            this.Price = Price;
            this.Quantity = Quantity;
            this.Picture = Picture;
        }

        public static Book CreateFromID(int ID)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM TBLPRODUCT WHERE ID=@P1", Connection.connect);
            if (command.Connection.State != ConnectionState.Open)
                command.Connection.Open();
            command.Parameters.AddWithValue("@P1", ID);
            SqlDataReader reader = command.ExecuteReader();

            if (reader.Read())
            {
                Book book = new Book(
                    Int32.Parse(reader[0].ToString()),
                    reader[2].ToString(),
                    double.Parse(reader[3].ToString()),
                    Int32.Parse(reader[4].ToString()),
                    reader[5].ToString(),
                    reader[6].ToString(),
                    reader[7].ToString(),
                    reader[8].ToString(),
                    Int32.Parse(reader[9].ToString())
                );
                reader.Close();
                return book;
            }

            reader.Close();
            throw new Exception();
        }
    }
}
