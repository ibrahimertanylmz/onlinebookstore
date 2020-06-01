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
   * \brief A classderved from product class for Music CDs.
   */
    class MusicCD : Product
    {
        public string Artist { get; protected set; }
        public string Type { get; protected set; }
        public string Issue { get; protected set; }

        /**
      * \brief MusicCD constructor. Sets MusicCD members
      * \param int Id: Product ID
      * \param string Name: Product Name.
      * \param double Price: Product Price.
      * \param int Quantity: Quantity.
      * \param string Picture: Product picture.
      * \param string Artist: Product artist.
      * \param string Type: Product type.
      * \param string Isssue: Product issue.
      */
        public MusicCD(int Id, string Name, double Price, int Quantity, string Picture, string Artist, string Type,string Issue)
        {
            this.Artist = Artist;
            this.Type = Type;
            this.Name = Name;
            this.Id = Id;
            this.Price = Price;
            this.Quantity = Quantity;
            this.Issue = Issue;
            this.Picture = Picture;
        }

        /**
        * \brief creates MusicCD using a product ID
        * \param int Id: Product ID
        * \return MusicCD
        */
        public static MusicCD CreateFromID(int ID)
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
                MusicCD musicCD=new MusicCD(
                    Int32.Parse(dr[0].ToString()),
                    dr[2].ToString(),
                    double.Parse(dr[3].ToString()),
                    Int32.Parse(dr[4].ToString()),
                    dr[5].ToString(),
                    dr[11].ToString(),
                    dr[12].ToString(),
                    dr[10].ToString()
                    );
                dr.Close();
                return musicCD;
            }
            dr.Close();
            throw new Exception();
        }
    }
}
