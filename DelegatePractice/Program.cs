namespace DelegatePractice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Book> books = new List<Book>
            {
                new Book("111", "C# Basics", new string[] {"John Doe"}, new DateTime(2020, 5, 1), 29.99m),
                 new Book("222", "Advanced C#", new string[] {"Jane Smith"}, new DateTime(2021, 7, 15), 49.99m)

            };
            Console.WriteLine("user define delegate");
            LibraryEngine.ProcessBooksUserDefined(books, BookFunctions.GetTitle);
            Console.WriteLine("Base class delegate");
            LibraryEngine.ProcessBooksBCL(books, BookFunctions.GetAuthors);
            Console.WriteLine("anomonus functopn");
            LibraryEngine.ProcessBooks(books, delegate (Book b) { return b.ISBN; });
            Console.WriteLine("lamda");

            LibraryEngine.ProcessBooks(books, b => b.PublicationDate.ToShortTimeString());

        }
    }
}
