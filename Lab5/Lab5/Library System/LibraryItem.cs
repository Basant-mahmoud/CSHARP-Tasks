using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_System
{
    internal class LibraryItem
    {
        public static int ItemCount { get; set; }
        private static int Id = 1;
        public string Title { get; set; }
        public string Author { get; set; }
        public LibraryItem(string title, string auther)
        {
            Title = title;
            Author = auther;
            Id++;
            ItemCount++;
        }
        public  virtual void ShowInfo()
        {
            Console.WriteLine($"title is {Title} ant Auther is {Author}");
        }
        public void ShowInfo(string prefix)
        {
            if (Title.Contains(prefix))
            {

                Console.WriteLine($"title is {Title} ant Auther is {Author}");

            }
            else
            {
                Console.WriteLine($"Not Found ");

            }



        }
    }
}
