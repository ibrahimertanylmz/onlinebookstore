using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BookShopManagement.Classes;

namespace BookShopManagement.UserControls
{
    public partial class UC_OrderSuccessful : UserControl
    {
        public UC_OrderSuccessful()
        {
            InitializeComponent();
            WriteOrder();
            WritePurchases();
        }
        private void WriteOrder()
        {
            SqlCommand add = new SqlCommand("insert into TBLORDERS (ID,ORDERNO,PRICE) VALUES (@P1,@P2,@P3)", Connection.connect);
            if (add.Connection.State != ConnectionState.Open)
                add.Connection.Open();
            add.Parameters.AddWithValue("@P1", Session.Instance.Customer.CustomerID.ToString());
            add.Parameters.AddWithValue("@P2", Session.Instance.OrderNo);
            add.Parameters.AddWithValue("@P3", ShoppingCart.Instance.PaymentAmount);
            add.ExecuteNonQuery();
        }
        private void WritePurchases()
        {
            for (var i = 0; i < ShoppingCart.Instance.ItemsToPurchase.Count; i++)
            {
                ItemToPurchase item = new ItemToPurchase();
                item = (ItemToPurchase)ShoppingCart.Instance.ItemsToPurchase[i];
                SqlCommand add = new SqlCommand("insert into TBLPURCHASES (ORDERNO,PRODUCTID,QTY,NAME,PICTURE) VALUES (@P1,@P2,@P3,@P4,@P5)", Connection.connect);
                if (add.Connection.State != ConnectionState.Open)
                    add.Connection.Open();
                add.Parameters.AddWithValue("@P1", Session.Instance.OrderNo);
                add.Parameters.AddWithValue("@P2", item.Product.Id);
                add.Parameters.AddWithValue("@P3", item.Quantity);
                add.Parameters.AddWithValue("@P4", item.Product.Name);
                add.Parameters.AddWithValue("@P5", item.Product.Picture);
                add.ExecuteNonQuery();

                SqlCommand decrease = new SqlCommand("update TBLPRODUCT SET QUANTITY=QUANTITY-@P1 where ID=" + item.Product.Id, Connection.connect);
                decrease.Parameters.AddWithValue("@P1", item.Quantity);
                decrease.ExecuteNonQuery();
            }
        }
    }
}
