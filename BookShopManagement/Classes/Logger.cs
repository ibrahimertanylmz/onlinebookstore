using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookShopManagement.Classes
{
    class Logger
    {
        public readonly static string fullpath = AppDomain.CurrentDomain.BaseDirectory + @"\logdDateandTime.log";

        public static void LogButtonClick(object sender, EventArgs e)
        {  
            Button btn = (Button)sender;
            string buttonname = btn.Name;

            using (StreamWriter writer = new StreamWriter(fullpath, append: true))
            {
                writer.WriteLine("DateandTime:"+DateTime.Now.ToString("HH:mm:ss") +" Button:" + buttonname +" Username:"+ Session.Instance.Customer.Username);
            }
        }
    }
}
