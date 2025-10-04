using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Expert_Level_Library_Management_System
{
    public abstract class LibraryItem:ILibraryAction
    {
        public static int TotalItems = 0;
        public static int NextID = 1;
        private int id;
        public string Title      {get;set;}
        public string Author     {get;set;}
        public int Year          {get;set;}
        public bool IsAvailable  {get;set;}
        public Location location { get; set; }
         public LibraryItem()
        {
            TotalItems++;
            IsAvailable = true;
            id=NextID++;

        }
        public LibraryItem(string Title, string Author, int Year, Location location)
        {
            this.Title = Title;
            this.Author = Author;
            this.Year = Year;
            this.IsAvailable = true;
            this.location = location;
            TotalItems++;
            NextID++;
        }
        public abstract void DisplayInfo();
        public virtual void  Borrow(string memberName)
        {
            if (IsAvailable)
            {
                IsAvailable = false;
                Console.WriteLine($"item {memberName} now is borrow");
            }
            else
            {
                Console.WriteLine($"item {memberName} is not available you cant borrow it .");
            }

        }
       public void Return()
        {
            IsAvailable = true;
            Console.WriteLine($"item is return now .");

        }

    }
}
