/**
 * @author İbrahim Ertan Yılmaz  
 * @date 25.05.2020
 * 
 * @edited_by Kumbukani Kamanga 26.05.2020 
*/

using BookShopManagement.Components;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace BookShopManagement.Classes
{
    class ShoppingCart 
    {
        public static ShoppingCart Instance { get; private set; } = new ShoppingCart();
        public string CustomerId { get; protected set; }

        public  ArrayList ItemsToPurchase = new ArrayList();
        public double PaymentAmount { get; set; }
        public int PaymentType { get; set; } //0 for cash, 1 for creditcard      

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
        public void SendInvoicebyEmail() {
            try
            {
                MailMessage mail = new MailMessage();
                SmtpClient smtpServer = new SmtpClient("ams1.sunucum.cloud");

                string message="Hello "+Session.Instance.Customer.FirstName+"\n"+"Your order no: "
                    +Session.Instance.OrderNo+"\nThanks for pushasing :)";
                mail.From = new MailAddress("bookstore@enessolak.com.tr");
                mail.To.Add(Session.Instance.Customer.Email.ToString());

                mail.Body = message;
                mail.Subject = "Your Invoice";
                smtpServer.Port = 587;
                smtpServer.Credentials = new System.Net.NetworkCredential("bookstore@enessolak.com.tr", "BookStore!!!");
                smtpServer.EnableSsl = true;

                smtpServer.Send(mail);
                //return true;
            }
            catch
            {
               Alert.Create("Something went wrong!", Alert.Type.Error);
               // return false;
            }
        }
    }
}
