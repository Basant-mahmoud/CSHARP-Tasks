using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatePractice
{
    public delegate string BookDelegate(Book b);

    class LibraryEngine
    {
        public static void ProcessBooksUserDefined(List<Book>blist, BookDelegate fPtr)
        {
            foreach(var book in blist)
            {
                Console.WriteLine(fPtr(book));
            }
        }
        //base class delegate 
        public static void ProcessBooksBCL(List<Book> blist, Func<Book, string>fPtr)
        {
            foreach (var book in blist)
            {
                Console.WriteLine(fPtr(book));
            }
        }
        public static void ProcessBooks(List<Book> blist, Func<Book, string> fPtr)
        {
            foreach (var book in blist)
            {
                Console.WriteLine(fPtr(book));
            }
        }

        // anomouns
        /* Func<Book, string> getISBN = delegate (Book b)
         {
             return b.ISBN;
         };
         //lamda
         Func<Book, string> getDate = b => b.PublicationDate.ToShortDateString();*/



    }
}
