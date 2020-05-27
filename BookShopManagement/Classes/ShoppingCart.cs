/**
 * @author İbrahim Ertan Yılmaz  
 * @date 25.05.2020
 * 
 * @edited_by Kumbukani Kamanga 26.05.2020 
*/

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookShopManagement.Classes
{
    class ShoppingCart 
    {
        public static ShoppingCart Instance { get; private set; } = new ShoppingCart();
        public string CustomerId { get; protected set; }

        public  ArrayList ItemsToPurchase = new ArrayList();
        public double PaymentAmount { get; protected set; }
        public int PaymentType { get; protected set; } //0 for cash, 1 for creditcard      

        public void AddProduct(ItemToPurchase itemToPurchase) 
        {
            ItemsToPurchase.Add(itemToPurchase);
        }

        public void RemoveProduct(ItemToPurchase itemToPurchase)
        {
            ItemsToPurchase.Remove(itemToPurchase);
        }
        public void RemoveProduct(bool removeAll)
        {
            if (removeAll)
            {
                ItemsToPurchase.Clear();
            }
        }

        public void PlaceOrder() { }
        public void CancelOrder() { }
        public void SendInvoicebySMS() { }
        public void SendInvoicebyEmail() { }

    }
}
