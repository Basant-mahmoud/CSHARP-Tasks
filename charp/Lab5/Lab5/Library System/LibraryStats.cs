using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_System
{
   static  internal class LibraryStats
    {
       public static void PrintTotalItems()
        {
            Console.WriteLine($"total item is {LibraryItem.ItemCount}");
        }
        public static Book GetMostBorrowed(Book[] books)
        {
            if (books == null || books.Length == 0)
            {
                return null;
            }
            Book maxborrow = books[0];
            foreach (Book book in books)
            {
                if (book.BorrowCount > maxborrow.BorrowCount)
                {
                    maxborrow = book;
                }
            }
            return maxborrow;
        }
    }
}
