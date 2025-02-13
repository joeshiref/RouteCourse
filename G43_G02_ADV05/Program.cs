namespace G43_G02_ADV05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Book> books = new List<Book>
            {
                new Book(
                    "Cracking the coding Interview",
                    new string[] { "Youssef Sherif", "Hussien Ibrahim" },
                    "12345",
                    new DateTime(1996, 10, 23),
                    45.99m
                )
            };


            LibraryEngine.ProcessBooks(books, BookFunctions.GetTitle);
            //LibraryEngine.ProcessBooks(books, new Func<Book, string>(BookFunctions.GetPrice));

            LibraryEngine.ProcessBooks(books, delegate (Book book)
            {
                return book.ISBN;
            });

            LibraryEngine.ProcessBooks(books, (Book book) => book.PublicationDate.ToString("yyyy-MM-dd"));
        }
    }
}
