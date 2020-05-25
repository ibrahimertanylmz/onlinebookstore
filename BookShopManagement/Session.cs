using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookShopManagement
{
    class Session
    {
        private Session() { }
        public static Session Instance { get; private set; } = new Session();

        public IDictionary<string, string> Customer = new Dictionary<string, string>();

        IDictionary<int, int> itemslist = new Dictionary<int, int>();

        public void Set_Customer(int id, string name, string address, string email, string username, string phone)
        {
            Customer.Add("Id", id.ToString());
            Customer.Add("Name", name);
            Customer.Add("Address", address);
            Customer.Add("Email", email);
            Customer.Add("UserName", username);
            Customer.Add("Phone", phone);
        }

        public void add_item(int id, int qty)
        {
            if (itemslist.ContainsKey(id))
            {
                itemslist[id] += qty;
            }
            else
            {
                itemslist.Add(id, qty);
            }
        }

        public void delete_item(int id)
        {
            itemslist.Remove(id);
        }
    }
}
