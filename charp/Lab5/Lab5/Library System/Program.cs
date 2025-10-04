namespace Library_System
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book b1 = new Book("Clean Code", "khaled", "Programming");
            Book b2 = new Book("Pragmatic Programmer", "basant", "OS");
            for(int i = 0; i < 7; i++)
            {
                b1.Borrow();

            }
            for (int i = 0; i < 5; i++)
            {
                b2.Borrow();
            }
           
            if (b1 < b2)
            {
                Console.WriteLine($"Most popular is {b1.Title}");
            }
            else
            {
                Console.WriteLine($"Most popular is {b2.Title}");
            }
            Console.WriteLine($"info");
            b1.ShowInfo();
            Console.WriteLine($"info");
            b2.ShowInfo();
            Magazine m1 = new Magazine("magzine", "walaa", 2, new DateTime(2020, 1, 2));
            Magazine m2 = new Magazine("magzine", "noor", 2, new DateTime(2020, 1, 2));
            LibraryStats.PrintTotalItems();
            var most=LibraryStats.GetMostBorrowed(new Book[] { b1, b2 });
            Console.WriteLine($"most borrow is {most.Title}");

        }
    }
}
