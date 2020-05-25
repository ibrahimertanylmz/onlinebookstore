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
    class Book : Product
    {
        public string ISBN { get; protected set; }
        public string Author { get; protected set; }
        public string Publisher { get; protected set; }
        public int Page { get; protected set; }

        public Book(string ISBN, string Author, string Publisher, int Page)
        {
            this.ISBN = ISBN;
            this.Author = Author;
            this.Publisher = Publisher;
            this.Page = Page;
        }
    }
}
