using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G43_G02_ADV05
{
    internal class Book
    {
        public string Title { get; set; }
        
        public string [] Author { get; set; }

        public string ISBN { get; set; }

        public DateTime PublicationDate { get; set; }
        public decimal Price { get; set; }

        public Book(string title, string[] author, string isbn, DateTime publicationDate, decimal price)
        {
            Title = title;
            Author = author;
            ISBN = isbn;
            PublicationDate = publicationDate;
            Price = price;
        }
        public override string ToString()
        {
            return $"Title: {Title}, Author: {string.Join(", ", Author)}, ISBN: {ISBN}, Publication Date: {PublicationDate}, Price: {Price}";
        }
    }
}
