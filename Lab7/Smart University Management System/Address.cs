using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smart_University_Management_System
{
    public struct Address
    {
        public string street, city, postacode;
        public Address(string street, string city, string postacode)
        {
            this.street = street;
            this.city = city;
            this.postacode = postacode;
        }
        public override string ToString()
        {
            return $" {street}  {city} {postacode}";
        }
    }
}
