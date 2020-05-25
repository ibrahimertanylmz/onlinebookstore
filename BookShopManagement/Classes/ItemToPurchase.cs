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
    class ItemToPurchase
    {
        public Product Product { get; protected set; }
        public int Quantity { get; protected set; }

        public ItemToPurchase(Product Product,int Quantity)
        {
            this.Product = Product;
            this.Quantity = Quantity;
        }
    }
}
    