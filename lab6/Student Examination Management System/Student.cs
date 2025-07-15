using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Examination_Management_System
{
    public abstract class Student :IAssessable
    {
        private static int StudentID = 1;
        public int id;
        public static int TotalStudents=0;
        public  string FullName             {get;set;}
        public  string Major                {get;set;}
        public  StudentContact Contact      {get;set;}
        public bool IsActive { get; set; }
        public string[] subjects = new string[10];
        public int[] scores = new int[10];
        public int scoreCount = 0;

        public Student()
        {
            id = StudentID++;
            TotalStudents++;
            IsActive = true;

        }
        public Student(string FullName,string Major, StudentContact Contact)
        {
            this.FullName = FullName;
            this.Major = Major;
            this.Contact = Contact;
            IsActive = true;
            id = StudentID++;
            TotalStudents++;
        }
        public void   AddScore(string subject, int score)
        {
            if (scoreCount > 10)
            {
                Console.WriteLine("Cant  this subject and score capacity is full");
            }
            else
            {
                scores[scoreCount] = score;
                subjects[scoreCount] = subject;
                scoreCount++;
            }
        }

        public abstract  void DisplayGrades();
    }
}
