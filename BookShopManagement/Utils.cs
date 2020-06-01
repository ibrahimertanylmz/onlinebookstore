/**
 * @author Enes Solak 
 * @date 25.05.2020
 */

using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookShopManagement
{
    /**
    * \brief A class that handles the utilities
    */
    class Utils
    {
        /**
        * \brief Base64StringToBitmap. Creates Bitmap object for a base64 String
        * \param string base64String: Picture String
        */
        public static Bitmap Base64StringToBitmap(string base64String)
        {
            Bitmap bmpReturn = null;
            try
            {
                //Convert Base64 string to byte[]
                byte[] byteBuffer = Convert.FromBase64String(base64String);
                MemoryStream memoryStream = new MemoryStream(byteBuffer);
                memoryStream.Position = 0;

                bmpReturn = (Bitmap)Bitmap.FromStream(memoryStream);

                memoryStream.Close();
                memoryStream = null;
                byteBuffer = null;

            }
            catch (Exception) { };
            return bmpReturn;
        }
    }
}
