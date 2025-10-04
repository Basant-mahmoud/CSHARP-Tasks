using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagementSystem
{
    class SubjectResult
    {
        public string SubjectName;
        public int Grade;

        public SubjectResult(string SubjectName, int Grade)
        {
            this.SubjectName = SubjectName;
                this.Grade = Grade;
        }
    }
}
