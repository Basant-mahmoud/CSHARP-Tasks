using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination_system_
{
    public abstract class Question : IDisplayable
    {
        public string Header { get; set; }
        public string Body { get; set; }
        public double Marks { get; set; }

        public virtual object CorrectAnswer { get; set; }

        public Question(string header, string body, double marks)
        {
            Header = header;
            Body = body;
            Marks = marks;
        }

        public abstract void Display();
    }

}