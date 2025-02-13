using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G43_G02_ADV05
{
    internal class BookFunctions
    {
        public static string GetTitle(Book book)
        {
            return book.Title;
        }
        public static string[] GetAuthors(Book book)
        {
            return book.Author;
        }
        public static string GetPrice(Book book)
        {
            return book.Price.ToString();
        }

    }
}
