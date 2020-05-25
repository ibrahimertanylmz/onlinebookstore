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
    class Magazine : Product
    {
        public string Issue { get; protected set; }
        public string Type { get; protected set; }

        public Magazine(int Id, string Name, double Price, int Quantity, string Picture, string Issue, string Type)
        {
            this.Issue = Issue;
            this.Type = Type;
        }

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
                return new Magazine(
                    Int32.Parse(dr[0].ToString()),
                    dr[2].ToString(),
                    double.Parse(dr[3].ToString()),
                    Int32.Parse(dr[4].ToString()),
                    dr[5].ToString(),
                    dr[10].ToString(),
                    dr[12].ToString()
                    );
            }
            dr.Close();
            throw new Exception();
        }
    }
}
