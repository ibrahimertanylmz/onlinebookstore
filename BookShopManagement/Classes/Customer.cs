using System;
using System.Collections.Generic;
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
        public string IdCardNumber { get; protected set; } 
        public string Username { get; protected set; }
        public string Password { get; protected set; }
    }
}
    