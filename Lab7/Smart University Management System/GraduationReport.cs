using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smart_University_Management_System
{
    sealed class GraduationReport
    {
        public void Generate(Student student)
        {
            Console.WriteLine($"Graduation Report for {student.Name}: GPA = {student.GPA}");
        }
    }
}
