using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smart_University_Management_System
{
    public class Course
    {
        public string Name { get; set; }
        public  Instructor instructor { get; set; }
        public Student[] students = new Student[10] ;
        private int  countstudent=0;
        public Course(string name,Instructor ins)
        {
            Name = name;
            instructor = ins;
        }

        public void Enroll(params Student[] Stud)
        {
            foreach (var student in Stud)
            {
                if (countstudent < 10)
                {
                    students[countstudent] = student;
                    countstudent++;
                }
                else
                {
                    throw new Exception(" Course is Full");
                }
            }
        }

        public void ListAllStudent()
        {
            Console.WriteLine($"Available student is ");
            for (int i = 0; i < countstudent; i++)
            {
                Console.WriteLine($"{students[i].DisplayProfile}");
            }
            
        }


    }
}
