using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Expert_Level_Library_Management_System
{
    public class Magazine :LibraryItem
    {
        public int IssueNumber { get; set; }

        public Magazine(string title, string auther, int year, Location location, int  issueNumber) : base(title, auther, year, location)
        {
            this.IssueNumber = issueNumber;
        }
        public override void DisplayInfo()
        {
            Console.WriteLine($"Magazine info is title ={Title} auther ={Author} location ={location} IssueNumber={IssueNumber }");
        }
    }
}
