using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination_system_
{
    class PracticeExam:Exam
    {
        public PracticeExam(Subject subject, int time) : base(subject, time) { }

        public override void Display()
        {
            Console.WriteLine($"--- Practice Exam ({Subject.SubjectName}) ---");
            Console.WriteLine($"Time: {TimeInMinutes} minutes\n");

            double score = 0;

            foreach (var q in Questions)
            {
                q.Display();
                Console.Write("Your Answer: ");
                string answer = Console.ReadLine()?.Trim();

                ShowCorrectAnswer(q);
                Console.WriteLine();
            }

        }


        private void ShowCorrectAnswer(Question q)
        {
            if (q is TrueFalseQuestion tfq)
            {
                Console.WriteLine($"Correct Answer: {(tfq.CorrectAnswer ? "True" : "False")}");
            }
            else if (q is ChooseOneQuestion coq)
            {
                Console.WriteLine($"Correct Answer: {coq.Choices[coq.CorrectChoiceIndex]}");
            }
            else if (q is ChooseAllQuestion caq)
            {
                Console.WriteLine("Correct Answers:");
                foreach (int idx in caq.CorrectChoices)
                {
                    Console.WriteLine($"- {caq.Choices[idx]}");
                }
            }
        }

        
    }
}
