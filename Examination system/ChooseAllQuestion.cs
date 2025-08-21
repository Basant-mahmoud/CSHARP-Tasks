using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination_system_
{
    public class ChooseAllQuestion : Question
    {
        public List<string> Choices { get; set; }
        public List<int> CorrectChoices { get; set; }

        public ChooseAllQuestion(string header, string body, double marks, List<string> choices, List<int> correctChoices)
            : base(header, body, marks)
        {
            Choices = choices;
            CorrectChoices = correctChoices;
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
