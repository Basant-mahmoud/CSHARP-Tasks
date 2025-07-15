using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    internal class Person
    {
        public int id { get; set; }
        public string fullName { get; set; }
        public Person(int id, string fullName)
        {
            if(id == 0)
            {
                Console.WriteLine("id must be greter thab 0");
                throw new ArgumentException("ID must be greater than 0.");

            }
            else
            {
                this.id = id;

            }
            if(fullName == null)
            {
                Console.WriteLine("full name must have value");
                throw new ArgumentException("ID must be greater than 0.");


            }
            else
            {
                this.fullName = fullName;
            }
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"id= {id} fullname={fullName}");
        }
        public void DisplayInfo(bool showId)
        {
            if (showId)
            {
                Console.WriteLine($"id={id}  fullname={fullName}");
            }
            else
            {
                Console.WriteLine($"id not exist");

            }
        }
    }
}
