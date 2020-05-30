/**
 * @author İbrahim Ertan Yılmaz  
 * @date 25.05.2020
 * 
 * @edited_by Kumbukani Kamanga 26.05.2020 
 * @edited_by Orhan İNAÇ 30.05.2020
*/

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using BookShopManagement.Components;
using BookShopManagement.Forms;

namespace BookShopManagement.Classes
{
    class ShoppingCart 
    {
        public static ShoppingCart Instance { get; private set; } = new ShoppingCart();
        public string CustomerID { get; protected set; }

        public ArrayList ItemsToPurchase = new ArrayList();
        public double PaymentAmount { get; set; } = 0;
        public int PaymentType { get; set; } //0 for cash, 1 for creditcard      

        public void AddProduct(ItemToPurchase itemToPurchase) 
        {
            ItemsToPurchase.Add(itemToPurchase);
            PaymentAmount += itemToPurchase.Product.Price * itemToPurchase.Quantity;
        }

        public void RemoveProduct(ItemToPurchase itemToPurchase)
        {
            ItemsToPurchase.Remove(itemToPurchase);
            PaymentAmount -= itemToPurchase.Product.Price * itemToPurchase.Quantity;
        }

        public void RemoveProduct(bool removeAll)
        {
            if (removeAll)
            {
                ItemsToPurchase.Clear();
                PaymentAmount = 0;
            }
        }

        public void RemoveProductByID(int id)
        {
            int index = 0;
            foreach (ItemToPurchase item in ItemsToPurchase)
            {
                if (item.Product.Id == id)
                {
                    ItemsToPurchase.RemoveAt(index);
                    PaymentAmount -= item.Product.Price * item.Quantity;
                    break;
                }
                index++;
            }
        }
  

        public static void PlaceOrder()
        {
            if (ShoppingCart.Instance.ItemsToPurchase.Count > 0)
            {
                using (Form_Checkout fch = new Form_Checkout())
                {
                    fch.ShowDialog();
                }
            }
            else
            {
                Alert.Create("Your Cart Is Empty!", Alert.Type.Error);
            }
        }
        public void CancelOrder() {
            Form_Checkout.ActiveForm.Dispose();
        }
        public void SendInvoicebySMS() { }

        public void SendInvoicebyEmail()
        {
            try
            {
                MailMessage mail = new MailMessage();
                SmtpClient smtpServer = new SmtpClient("ams1.sunucum.cloud");
                string message = "Hello " + Session.Instance.Customer.FirstName + ",\n" + "Your order no: "
                    + Session.Instance.OrderNo + "was successfully processed." +
                    "\nThank you for shopping with us!" +
                    "\n\nYours,\nThe OnlineBookStore Team";
                mail.From = new MailAddress("bookstore@enessolak.com.tr");
                mail.To.Add(Session.Instance.Customer.Email.ToString());
                mail.Body = message;
                mail.Subject = "Your Invoice";
                smtpServer.Port = 587;
                smtpServer.Credentials = new System.Net.NetworkCredential("bookstore@enessolak.com.tr", "BookStore!!!");
                smtpServer.EnableSsl = true;
                smtpServer.Send(mail);
            }
            catch
            {
                Alert.Create("Something went wrong!", Alert.Type.Error);
            }
        }

    }
}
