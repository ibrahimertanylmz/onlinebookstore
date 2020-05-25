using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookShopManagement.Classes
{
    public abstract class Product
    {
        public string Name { get; protected set; }
        public string Id { get; protected set; }
        public double Price { get; protected set; }
        public int Quantity { get; protected set; }
        public string Picture { get; protected set; }

        protected Product() { }

        protected Product(string Name, string Id, double Price, int Quantity, string Picture)
        {
            this.Name = Name;
            this.Id = Id;
            this.Price = Price;
            this.Quantity = Quantity;
            this.Picture = Picture;
        }
    }
}
