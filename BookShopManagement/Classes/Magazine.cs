/**
 * @author İbrahim Ertan Yılmaz  
 * @date 25.05.2020
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookShopManagement.Classes
{
    class Magazine : Product
    {
        public string Issue { get; protected set; }
        public string Type { get; protected set; }

        public Magazine()
        {
            this.Issue = Issue;
            this.Type = Type;
        }
    }
}
