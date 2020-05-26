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
    class MusicCD : Product
    {
        public string Singer { get; protected set; }
        public string Type { get; protected set; }
        public string Issue { get; protected set; }

        public MusicCD(int Id, string Name, double Price, int Quantity, string Picture, string Singer, string Type,string Issue)
        {
            this.Singer = Singer;
            this.Type = Type;
            this.Name = Name;
            this.Id = Id;
            this.Price = Price;
            this.Quantity = Quantity;
            this.Issue = Issue;
            this.Picture = Picture;
        }
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
