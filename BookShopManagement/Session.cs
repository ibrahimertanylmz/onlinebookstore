﻿using BookShopManagement.Classes;
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

        public Customer Customer = null;

        IDictionary<int, int> itemslist = new Dictionary<int, int>();

        public void SetCustomer(Customer customer)
        {
            this.Customer = customer;
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
