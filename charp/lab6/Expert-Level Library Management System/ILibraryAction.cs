using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Expert_Level_Library_Management_System
{
   public  interface ILibraryAction
    {
        public void Borrow(string memberName);
        public void Return();
    }
}
