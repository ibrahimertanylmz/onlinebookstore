/**
 * @author İbrahim Ertan Yılmaz
 * @date 01.06.2020
 */
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
    {  /**
        * @param fullpath: path for logDateandTime.
        */
        public readonly static string fullpath = AppDomain.CurrentDomain.BaseDirectory + @"\logDateandTime.log";
        /**
         * @brief :Writes DateandTime Username and ClickedButton data to a log file.
         * @param btn:Used for getting data for ClickedButton.
         * @param buttonname: Name of clicked Button.
         */
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
