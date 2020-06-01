using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace BookShopManagement.UserControls
{
    public partial class UC_Reporting : UserControl
    {
        double total = 0;
        Random rand = new Random();
        public UC_Reporting()
        {
            InitializeComponent();
            lblOrders.Text = Orders().ToString();
            lblProducts.Text = Products().ToString();
            lblCustomers.Text = Customers().ToString();
            lblTotal.Text = "€ "+total.ToString();
            TargetProgressbar.Value = Convert.ToInt32((total/10000)*100);
        }
        private int Orders()
        {
            int count = 0;
            SqlCommand command = new SqlCommand("SELECT PRICE FROM TBLORDERS", Connection.connect);
            if (command.Connection.State != ConnectionState.Open)
                command.Connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                total += double.Parse(reader[0].ToString());
                count++;
            }
            reader.Close();
            return count;
        }
        private int Products()
        {
            int count = 0;
            SqlCommand command = new SqlCommand("SELECT * FROM TBLPURCHASES", Connection.connect);
            if (command.Connection.State != ConnectionState.Open)
                command.Connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                count += int.Parse(reader["QTY"].ToString());
            }
            reader.Close();
            return count;
        }
        private int Customers()
        {
            string stmt = "SELECT COUNT(*) FROM dbo.TBLCUSTOMER";
            int count = 0;
            using (SqlCommand command = new SqlCommand(stmt, Connection.connect))
            {
                if (command.Connection.State != ConnectionState.Open)
                    command.Connection.Open();
                count = (int)command.ExecuteScalar();
            }
            return count;
        }
        private void LoadChart()
        {
            var cnv = new Bunifu.DataViz.Canvas();
            var dataPoint = new Bunifu.DataViz.DataPoint(Bunifu.DataViz.BunifuDataViz._type.Bunifu_pie);
            dataPoint.addLabely("Books", rand.Next(0, 500).ToString());
            dataPoint.addLabely("Magazines", rand.Next(0, 500).ToString());
            dataPoint.addLabely("Music", rand.Next(0, 500).ToString());
            cnv.addData(dataPoint);
            bunifuDataViz1.Render(cnv);

        }
        private void btnReload_Click(object sender, EventArgs e)
        {
            LoadChart();
        }

        private void tmrChart_Tick(object sender, EventArgs e)
        {
            LoadChart();
            tmrChart.Stop();
        }
    }
}
