using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smart_University_Management_System
{
    public abstract class Person
    {
       
        public Address Address;
        public string Name { get; set; }
        public string Email     { get; set; }
        public string Phone { get; set; }
        public Person(Address address, string name, string email, string phone)
        {
            Address = address;
            Name = name;
            Email = email;
            Phone = phone;
        }

        public abstract void DisplayProfile();
    }
}
