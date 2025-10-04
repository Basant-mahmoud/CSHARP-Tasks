using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_System
{
    internal class Magazine:LibraryItem
    {
        public int IssueNumber  { get; set; }
        public DateTime PublishDate { get; set; }
        public Magazine(string title ,string auther ,int issuesNumber,DateTime date):base(title,auther) {
            IssueNumber=issuesNumber;
            PublishDate=date;


        }
        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine($"issuesNumber {IssueNumber} publishdate={PublishDate}");
        }

    }
}
