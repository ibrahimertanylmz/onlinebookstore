/**
 * @author İbrahim Ertan Yılmaz  
 * @date 25.05.2020
 * 
 *  @edited_by Kumbukani Kamanga 26.05.2020 
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookShopManagement.Classes
{
    public class ItemToPurchase
    {
        public Product Product { get; set; }
        public int Quantity { get; set; }
        public ItemToPurchase() { }
        /**
         * @brief : Constructor function for ItemToPurchase.
         * @param Product: Product object for ItemToPurchase.
         * @param Quantity: Count of product ItemToPurchase.
         */
        public ItemToPurchase(Product Product,int Quantity)
        {
            this.Product = Product;
            this.Quantity = Quantity;
        }
    }
}
    