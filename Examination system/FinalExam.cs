using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination_system_
{
    class FinalExam : Exam
    {
        public FinalExam(Subject subject, int time) : base(subject, time) { }

        public override void Display()
        {
            Console.WriteLine($"--- Final Exam ({Subject.SubjectName}) ---");
            Console.WriteLine($"Time: {TimeInMinutes} minutes\n");

            double score = 0;

            foreach (var q in Questions)
            {
                q.Display();
                Console.Write("Your Answer: ");
                string userAnswer = Console.ReadLine()?.Trim();
                Console.WriteLine();

               
            }

        }

    }
}
