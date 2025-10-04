using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Examination_Management_System
{
    class RegularStudent : Student
    {
        public RegularStudent(string fullname,string major,StudentContact contract) : base(fullname, major, contract)
        {

        }
        public override void DisplayGrades()
        {
            Console.WriteLine($" student info is Name = {FullName} and Id ={id}");
            for(int i=0;i< scoreCount; i++)
            {
                Console.WriteLine($" subject = {subjects[i]} Score ={scores[i]}");

            }
        }
    }
}
