using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smart_University_Management_System
{
    public static class UniversityStats
    {
        public static int TotalStudent = 0;
        public static void IncrementStudentCount()
        {
            TotalStudent++;
        }

       
        public static void NumberStudent()
        {
            Console.WriteLine($"Total Student is {TotalStudent}");
        }
    }
}
