/**
 * @author İbrahim Ertan Yılmaz  
 * @date 25.05.2020
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
    /**
   * \brief A classderved from product class for magazines.
   */
    class Magazine : Product
    {
        public string Issue { get; protected set; }
        public string Type { get; protected set; }
        public int Page { get; protected set; }
        public string Publisher { get; protected set; }

        /**
        * \brief Magazine constructor. Sets Magazine members
        * \param int Id: Product ID
        * \param string Name: Product Name.
        * \param double Price: Product Price.
        * \param int Quantity: Quantity.
        * \param string Picture: Product picture.
        * \param string Isssue: Product issue.
        * \param string Type: Product type.
        * \param string Publisher: product publisher
        * \param int Page: Number of pages.
        */
        public Magazine(int Id, string Name, double Price, int Quantity, string Picture, string Issue, string Type, string Publisher, int Page)
        {
            this.Id = Id;
            this.Name = Name;
            this.Issue = Issue;
            this.Quantity = Quantity;
            this.Price = Price;
            this.Type = Type;
            this.Page = Page;
            this.Publisher = Publisher;
            this.Picture = Picture;
        }

        /**
        * \brief creates Magazine using a product ID
        * \param int Id: Product ID
        * \return Magazine
        */
        public static Magazine CreateFromID(int ID)
        {
            SqlCommand command = new SqlCommand("select * FROM TBLPRODUCT WHERE ID=@P1", Connection.connect);
            if (command.Connection.State != ConnectionState.Open)
            {
                command.Connection.Open();
            }
            command.Parameters.AddWithValue("@P1", ID);

            SqlDataReader dr = command.ExecuteReader();
            if (dr.Read())
            {
                    Magazine magazine=new Magazine(
                    Int32.Parse(dr[0].ToString()),
                    dr[2].ToString(),
                    double.Parse(dr[3].ToString()),
                    Int32.Parse(dr[4].ToString()),
                    dr[5].ToString(),
                    dr[10].ToString(),
                    dr[12].ToString(),
                    dr[8].ToString(),
                    Int32.Parse(dr[9].ToString()));
                dr.Close();
                return magazine;
            }
            dr.Close();
            throw new Exception();
        }
    }
}
