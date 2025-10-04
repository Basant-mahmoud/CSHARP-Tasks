using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination_system_
{
     public class Subject
    {
        public string SubjectName { get; set; }
        public string SubjectCode { get; set; }

        public Subject(string name, string code)
        {
            SubjectName = name;
            SubjectCode = code;
        }
    }
}
