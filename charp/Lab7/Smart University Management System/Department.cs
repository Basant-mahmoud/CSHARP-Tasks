using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smart_University_Management_System
{
   public class Department
    {
       // public string Name { get; set; }
        public DepartmentType department { get; set; }
        public Course[] Courses = new Course[5];
        private int courseCount = 0;
        public Department( DepartmentType department)
        {
            //Name = name;
            this.department = department;
            
        }
        public void AddCourse(params Course[] courses)
        {
            foreach(var course in courses)
            {
                if (courseCount < 5)
                {
                    Courses[courseCount] = course;
                    courseCount++;
                }
                else
                {
                    throw new Exception("Department is Full");
                }
            }
        }

        public void DepartmentReport()
        {
            Console.WriteLine($"Department: ({department})");

            bool hasCourses = false;

            for (int i = 0; i < courseCount; i++)
            {
                if (Courses[i] != null)
                {
                    Console.WriteLine($"- Course: {Courses[i].Name} (Instructor: {Courses[i].instructor?.Name ?? "N/A"})");
                    hasCourses = true;
                }
            }

            if (!hasCourses)
            {
                Console.WriteLine("No courses in this department yet.");
            }
        }




    }
}
