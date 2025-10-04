using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination_system_
{
    public class ChooseOneQuestion : Question
    {
        public List<string> Choices { get; set; }
        public int CorrectChoiceIndex { get; set; }

        public ChooseOneQuestion(string header, string body, double marks, List<string> choices, int correctChoiceIndex)
            : base(header, body, marks)
        {
            Choices = choices;
            CorrectChoiceIndex = correctChoiceIndex;
        }

        public override void Display()
        {
            Console.WriteLine($"{Header}: {Body} (Marks: {Marks})");
            for (int i = 0; i < Choices.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {Choices[i]}");
            }
        }
    }

}
