using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BookShopManagement.Forms;

namespace BookShopManagement.UserControls
{
    public partial class UC_Books : UserControl
    {
        public UC_Books()
        {
            InitializeComponent();
            panel11.AutoScroll = true;
        }

        private void button7_Click(object sender, EventArgs e)
        {
        }

        private void panel2_Click(object sender, EventArgs e)
        {
            lblISBN.Text = "Hello";
        }
    }
}
