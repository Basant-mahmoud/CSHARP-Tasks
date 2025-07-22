using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smart_University_Management_System
{
   public class Instructor : Person,IEvaluable
    {
        public string Title { get; set; }
        public DepartmentType deptype { get; set; }
        public Instructor(Address address, string name, string email, string phone, string title, DepartmentType deptype) : base(address, name, email, phone)
        {
            Title = title;
            this.deptype = deptype;
        }
        public override void DisplayProfile()
        {
            Console.WriteLine($"instractor info is {Name} address{Address} Title {Title} Gmail {Email} phone {Phone}");

        }

        public void EvaluatePerformance()
        {
            Console.WriteLine($"{Name}'s Performance Evaluation: Teaching performance under review.");
        }
    }
}
