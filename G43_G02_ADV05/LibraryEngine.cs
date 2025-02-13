using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G43_G02_ADV05
{
    internal class LibraryEngine
    {
        public delegate string BookInfoDelegate(Book book);

        public static void ProcessBooks(List<Book> books, BookInfoDelegate bookInfoDelegate)
        {
            foreach (var book in books)
            {
                Console.WriteLine(bookInfoDelegate(book));
            }
        }

    }
}
