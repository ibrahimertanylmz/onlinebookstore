/**
 * @author İbrahim Ertan Yılmaz  
 * @date 25.05.2020
 */

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
        public int Id { get; protected set; }
        public double Price { get; protected set; }
        public int Quantity { get; protected set; }
        public string Picture { get; protected set; }

        protected Product() { }
        /**
          * @brief : Constructor function for Product Class.
          * @param Name: Name of Product.
          * @param Id: Id of product.
          * @param Price: Price of Product.
          * @param Quantity: Count of Product.
          * @param Picture: Picture of Product.
          */
        protected Product(string Name, int Id, double Price, int Quantity, string Picture)
        {
            this.Name = Name;
            this.Id = Id;
            this.Price = Price;
            this.Quantity = Quantity;
            this.Picture = Picture;
        }
    }
}
