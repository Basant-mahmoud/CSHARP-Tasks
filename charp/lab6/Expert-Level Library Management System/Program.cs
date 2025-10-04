namespace Expert_Level_Library_Management_System
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Location loc1 = new Location("Fiction", 1);
            Location loc2 = new Location("Science", 2);
            Location loc3 = new Location("Reference", 3);
            Book book1 = new Book("The Hobbit", "J.R.R. Tolkien", 1937, loc1, Genres.Fiction);
            Book book2 = new Book("A Brief History of Time", "Stephen Hawking", 1988, loc2, Genres.Science);
            ReferenceBook refBook = new ReferenceBook("Encyclopedia", "Various", 2020, loc3, Genres.NonFiction);
            Magazine mag1 = new Magazine("National Geographic", "Editors", 2023,  loc2, 120);
            LibraryManager.additem(book1);
            LibraryManager.additem(book2);
            LibraryManager.additem(refBook);
            LibraryManager.additem(mag1);
            Console.WriteLine("Show Available item ");
            LibraryManager.ListAllItems();
            book1.Borrow("Alice");
            refBook.Borrow("Bob"); // should not be allowed
            mag1.Borrow("Charlie");

            // List available items
            Console.WriteLine("Available Items:");
            LibraryManager.ListAllAvailableItems();

            // Return item
            Console.WriteLine("\n🔄 Returning an item:");
            book1.Return();

            // Search by title
            Console.WriteLine("\n🔍 Searching for 'The Hobbit':");
            LibraryManager.SearchByTitle("The Hobbit");
            Console.WriteLine("\n🔃 Sorting items by title:");
            LibraryManager.SortByTitle();
            LibraryManager.ListAllItems();
            Console.WriteLine("\n🗑 Removing 'National Geographic':");
            LibraryManager.RemoveItemByTitle("National Geographic");
            LibraryManager.ListAllItems();

           /* // Add 100+ items to trigger resize
            Console.WriteLine(" Adding many items to test array resize:");
            for (int i = 0; i < 105; i++)
            {
                var book = new Book($"Book {i}", "Author", 2000 + i % 20, loc1, Genres.Mystery);
                LibraryManager.additem(book);
            }*/

            Console.WriteLine("Final available items:");
            LibraryManager.ListAllAvailableItems();

            Console.WriteLine(" DONE.");

        }
    }
}
