using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Expert_Level_Library_Management_System
{
   public  struct Location
    {
        public string Section;
        public int ShelfNumber;
       public Location(string section,int shelfnumber)
        {
            this.Section = section;
            this.ShelfNumber = shelfnumber;

        }
        public override string ToString()
        {
            return $"section is {Section} and shelfNumber is {ShelfNumber}";
        }

    }
}
