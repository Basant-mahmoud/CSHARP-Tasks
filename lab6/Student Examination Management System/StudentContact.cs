using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Examination_Management_System
{
     public struct StudentContact
    {
       public  string Email    {get;set;}
       public  string Phone    {get;set;}
       public  string Address  { get; set;}
        public override string ToString()
        {
           return $"Email is {Email} and Phone is {Phone} address is {Address}";
        }
    }
}
