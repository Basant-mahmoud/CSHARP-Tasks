using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Expert_Level_Library_Management_System
{
    class ReferenceBook : Book
    {
        public ReferenceBook(string title, string auther, int year, Location location, Genres genre) : base(title, auther, year, location, genre)
        {
        }
        public override void Borrow(string memberName)
        {
            Console.WriteLine($"you cant borrow this book{memberName}");
        }
    }
}
