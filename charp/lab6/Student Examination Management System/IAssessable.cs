using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Examination_Management_System
{
    public interface IAssessable
    {
       public  void AddScore(string subject, int score)  ;
        public void DisplayGrades();

    }
}
