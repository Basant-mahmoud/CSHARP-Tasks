using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination_system_
{
    class TrueFalseQuestion:Question
    {
        public bool CorrectAnswer { get; set; }

        public TrueFalseQuestion(string header, string body, double marks, bool correctAnswer)
            : base(header, body, marks)
        {
            CorrectAnswer = correctAnswer;
        }

        public override void Display()
        {
            Console.WriteLine($"{Header}: {Body} (Marks: {Marks})");
            Console.WriteLine("1. True");
            Console.WriteLine("2. False");
        }
    }
}
