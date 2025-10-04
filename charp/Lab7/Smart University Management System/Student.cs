using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Smart_University_Management_System
{
    public class Student : Person,IEvaluable
    {
        private double gpa;
        public double GPA 
        { 
            get { return gpa; }
            set 
            { 
                if(value<0.0||value>4)
                    throw new ArgumentException("GPA must be between 0.0 and 4.0");
                else
                {
                    gpa = value;
                }
            } 
        }
        public GradeLevel Level { get; set; }
        public Course[] EnrolmentCourse = new Course[5];
        private int courseCount = 0;
        public Student(Address address, string name, string email, string phone, GradeLevel Level, double GPA) :base( address,  name,  email,  phone)
        {
            this.Level = Level;
            this.GPA = GPA;
            //UniversityStats.IncrementStudentCount();
        }
        

        public void EvaluatePerformance()
        {
            Console.WriteLine($"{Name}'s Performance Evaluation: GPA = {GPA}");

        }

        public override void DisplayProfile()
        {
            Console.WriteLine($"Student info is {Name} address{Address} Gpa {GPA} Gmail {Email} phone {Phone}");
        }
        public void Enrollment(Course course)
        {
            if (courseCount < 5)
            {
                EnrolmentCourse[courseCount] = course;
                courseCount++;
            }
            else
            {
                throw new Exception("Cant Enrool In More than 5 courses");
            }
        }
    }
}
