using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Examination_Management_System
{
    class TransferStudent : Student
    {
        public string PreviousUniversity { get; set; }
        public TransferStudent(string previousUniversity, string FullName, string Major, StudentContact Contact)
            :base(FullName,Major,Contact)
        {
            PreviousUniversity = previousUniversity;
        }

        public override void DisplayGrades()
        {
            Console.WriteLine($"\nGrades for TransferStudent Student {FullName} (ID: {id}):");
            for (int i = 0; i < scoreCount; i++)
            {
                Console.WriteLine($"{subjects[i]}: {scores[i]}");
            }
            Console.WriteLine($"PreviousUniversity: {PreviousUniversity}");
        }
    }
}
