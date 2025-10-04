using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Expert_Level_Library_Management_System
{
    public class Book: LibraryItem
    {
        public Genres Genre { get; set; }
        public Book( string title,string auther,int year, Location location, Genres genre):base(title, auther, year,  location)
        {
            Genre = genre;
            //IsAvailable = true;
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Book info is title ={Title} auther ={Author} location ={location} genre={Genre}");
        }
    }
}
