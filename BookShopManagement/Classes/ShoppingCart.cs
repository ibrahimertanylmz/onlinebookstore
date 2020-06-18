﻿/**
 * @author İbrahim Ertan Yılmaz  
 * @date 25.05.2020
 * 
 * @edited_by Kumbukani Kamanga 26.05.2020 
 * @edited_by Enes Solak 30.05.2020
 * @edited_by Orhan İNAÇ 31.05.2020
*/

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BookShopManagement.Components;
using BookShopManagement.Forms;

namespace BookShopManagement.Classes
{
    /**
    * \brief A class used to handle the shopping cart processes.
    *
    */
    class ShoppingCart 
    {
        public static ShoppingCart Instance { get; private set; } = new ShoppingCart();
        public string CustomerID { get; protected set; }

        public ArrayList ItemsToPurchase = new ArrayList();
        public double PaymentAmount { get; set; } = 0;
        public int PaymentType { get; set; } //0 for cash, 1 for creditcard      

        /**
        * \brief Adds product to cart
        * \param itemToPurchase ItemToPurchase: product to be added
        */
        public void AddProduct(ItemToPurchase itemToPurchase) 
        {
            ItemsToPurchase.Add(itemToPurchase);
            PaymentAmount += itemToPurchase.Product.Price * itemToPurchase.Quantity;
        }


        /**
        * \brief Removes product from cart
        * \param itemToPurchase ItemToPurchase: product to be removed
        */
        public void RemoveProduct(ItemToPurchase itemToPurchase)
        {
            ItemsToPurchase.Remove(itemToPurchase);
            PaymentAmount -= itemToPurchase.Product.Price * itemToPurchase.Quantity;
        }

      /**
      * \brief Removes all product from cart
      * \param removeAll bool: 
      */
        public void RemoveProduct(bool removeAll)
        {
            if (removeAll)
            {
                ItemsToPurchase.Clear();
                PaymentAmount = 0;
            }
        }

      /**
      * \brief Removes product from cart using its ID
      * \param id int: product to be removed
      */
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

      /**
      * \brief Places the user's order
      */
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

      /**
      * \brief Cancels the user's order
      */
        public void CancelOrder() {
            Form_Checkout.ActiveForm.Dispose();
        }

      /**
      * \brief Sends order invoice to user's phone number
      */
        public void SendInvoicebySMS() {}

      /**
      * \brief Sends order invoice to user's email
      */
        public void SendInvoicebyEmail()
        {
            try
            {
                PDF pdf = new PDF(Session.Instance.OrderNo);
                MailMessage mail = new MailMessage();
                SmtpClient smtpServer = new SmtpClient("ams1.sunucum.cloud");
                string message = "Hello " + Session.Instance.Customer.FirstName + ",\n\n" + "Your order no: "
                    + Session.Instance.OrderNo + " was successfully processed." +
                    "\nThank you for shopping with us!" +
                    "\n\nYours,\nThe Esogu BookStore";
                mail.From = new MailAddress("bookstore@enessolak.com.tr");
                mail.Subject = "Succesful Order Processed!";
                mail.To.Add(Session.Instance.Customer.Email.ToString());
                mail.Body = message;
                mail.Attachments.Add(new Attachment(Session.Instance.OrderNo.ToString()+".pdf"));
                smtpServer.Port = 587;
                smtpServer.Credentials = new System.Net.NetworkCredential("bookstore@enessolak.com.tr", "BookStore!!!");
                smtpServer.EnableSsl = true;
                smtpServer.Send(mail);

                ShoppingCart.Instance.RemoveProduct(true);
            }
            catch
            {
                Alert.Create("Something went wrong!", Alert.Type.Error);
            }
        }

    }
}
