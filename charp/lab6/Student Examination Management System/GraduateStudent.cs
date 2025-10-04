using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Examination_Management_System
{
    class GraduateStudent : Student
    {
       public string Title         {get;set;}
       public string AdvisorName { get; set; }
        public GraduateStudent(string title, string advisorName, string FullName, string Major, StudentContact Contact)
       :base(FullName, Major, Contact)
        {
            Title = title;
            AdvisorName = advisorName;
        }

        public override void DisplayGrades()
        {
            Console.WriteLine($"\nGrades for TransferStudent Student {FullName} (ID: {id}):");
            for (int i = 0; i < scoreCount; i++)
            {
                Console.WriteLine($"{subjects[i]}: {scores[i]}");
            }
            Console.WriteLine($"Title: {Title} AdvisorName: {AdvisorName}");
        }
    }
}
