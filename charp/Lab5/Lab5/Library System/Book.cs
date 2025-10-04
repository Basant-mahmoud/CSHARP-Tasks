using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_System
{
    internal class Book:LibraryItem
    {
          public  string Genre      {get;set;}


          public int BorrowCount { get; set; }
        public Book(string title,string auther,string gender) : base(title, auther)
        {
            this.Genre = gender;
            BorrowCount = 0;

        }

       public  void Borrow()
        {
            BorrowCount++;
        }
       public override void ShowInfo()
        {
            Console.WriteLine($"title is {Title} ant Auther is {Author} gender={Genre} num of borrow={BorrowCount}");

        }
        public static bool operator >(Book a, Book b)
        {
            return a.BorrowCount > b.BorrowCount;
        }
        public static bool operator <(Book a, Book b)
        {
            return a.BorrowCount > b.BorrowCount;
        }


    }
}
