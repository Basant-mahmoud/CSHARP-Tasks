using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Expert_Level_Library_Management_System
{
    public  static class LibraryManager
    {
        private static LibraryItem[] items = new LibraryItem[100];
        private static int count = 0;
        public static void additem(LibraryItem item)
        {
            if (count < items.Length)
            {
                items[count] = item;
                count++;
                Console.WriteLine($"Item '{item.Title}' added.");
            }
            else
            {
                Console.WriteLine($"Resize Array");
                LibraryItem[] newArray = new LibraryItem[items.Length + 50];
                for(int i = 0; i < count; i++)
                {
                    newArray[i] = items[i];
                }
                items = newArray;
                items[count++] = item;

            }

        }
        public static void additem(LibraryItem[] arritem)
        {
            foreach(var item  in arritem)
            {
                additem(item);
            }

        }
        public static void SearchByTitle(string title)
        {
            for(int i = 0; i < count; i++)
            {
                if (items[i].Title == title)
                {
                    if (items[i].IsAvailable)
                    {
                        Console.WriteLine($"this item in libaray in location {items[i].location}");
                    }
                    Console.WriteLine($"this item is Borrow");

                }
            }
        }
       public static void ListAllItems()
        {
            Console.WriteLine(" all  Items:");

            for (int i = 0; i < count; i++)
            {
                items[i].DisplayInfo();
            }
        }
        public static void ListAllAvailableItems()
        {
            Console.WriteLine(" Available Items:");
            for (int i = 0; i < count; i++)
            {
                if (items[i].IsAvailable)
                {
                    items[i].DisplayInfo();
                }
               
            }
        }
        public static void RemoveItemByTitle(string title)
        {
            for(int i = 0; i < count; i++)
            {
                if (items[i].Title == title)
                {
                    Console.WriteLine($"Item '{items[i].Title}' removed.");
                    for(int j = i; j < count - 1; j++)
                    {
                        items[j] = items[j + 1];
                    }
                    items[count - 1] = null;
                    count--;
                    return;
                }
            }
            Console.WriteLine($"Cant find this item");

        }
        //Buble Sort
        public static void SortByTitle()
        {
            for (int i = 0; i < count; i++)
            {
                for(int j = 0; j < count-1; j++)
                {
                    // لو الايتم الاول اكبر 
                    if (string.Compare(items[j].Title, items[j+1].Title, StringComparison.OrdinalIgnoreCase) > 0)
                    {
                        var swap = items[j];
                        items[j] = items[j + 1];
                        items[j + 1] = swap;
                    }

                }
                
            }
            Console.WriteLine(" Items sorted by title.");
        }

        public static void countborrowed()
        {
            int countBorrow = 0;
            for(int i = 0; i < count; i++)
            {
                if (items[i].IsAvailable == false)
                {
                    countBorrow++;
                }
            }
            Console.WriteLine($"Number of Count Borrow Item is {countBorrow}");
        }
    }
}
