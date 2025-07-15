using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Examination_Management_System
{
    class ScholarshipStudent :Student
    {
        public double ScholarshipAmount { get; set; }
        public ScholarshipStudent(string name, string major, StudentContact contact, double amount)
       : base(name, major, contact)
        {
            ScholarshipAmount = amount;
        }
        public override void DisplayGrades()
        {
            Console.WriteLine($"\nGrades for Scholarship Student {FullName} (ID: {id}):");
            for (int i = 0; i < scoreCount; i++)
            {
                Console.WriteLine($"{subjects[i]}: {scores[i]}");
            }
            Console.WriteLine($"Scholarship Amount: {ScholarshipAmount}");
        }
    }
}
