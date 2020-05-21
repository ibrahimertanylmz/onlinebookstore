using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace BookShopManagement
{
    public class Connection
    {
        public static SqlConnection connect = new SqlConnection("workstation id=bookstore.mssql.somee.com;packet size=4096;user id=trname_SQLLogin_1;pwd=992qrgsk3z;data source=bookstore.mssql.somee.com;persist security info=False;initial catalog=bookstore");
    }
}
