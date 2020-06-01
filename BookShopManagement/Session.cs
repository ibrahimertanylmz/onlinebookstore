/**
 * @author Ahmad Zaidan
 * @date
 * 
 * @edited_by Enes Solak 25.02.2020
 */

using BookShopManagement.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookShopManagement
{
    /**
    * \brief A class that saves this current session's information
    */
    class Session
    {
        private Session() { }
        public static Session Instance { get; private set; } = new Session();

        public Customer Customer = null;
        public string OrderNo;
        /**
        * \brief SetCustomer. Saves the current customers object in the class
        * \param Customer customer: Customer object
        */
        public void SetCustomer(Customer customer)
        {
            this.Customer = customer;
            OrderNo = Customer.CustomerID.ToString()+DateTime.Now.ToString(@"MMddyyyyHHmmss");
        }
    }
}
