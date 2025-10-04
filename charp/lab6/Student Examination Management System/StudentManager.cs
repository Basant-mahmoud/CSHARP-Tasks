using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Examination_Management_System
{
   static class StudentManager
    {
        static public Student[] students = new Student[100];
         private static int count = 0;
        public static void AddStudent(Student s)
        {
            if (count < 100)
            {
                students[count] = s;
                count++;
                Console.WriteLine("student is add successfly");
            }
            else
            {
                Console.WriteLine($"Cant add this student memory is Full");
            }

        }
        public static void AddStudent(Student[] s)
        {
            foreach (var std in s)
            {
                AddStudent(s);
            }

        }
        public static void AddScoreToStudent(int id, string subject, int score)
        {
            for (int i = 0; i < count; i++)
            {
                if (students[i].id == id)
                {
                    students[i].AddScore(subject, score);
                    return;
                }
            }
            Console.WriteLine(" Student not found.");
        }
        public static void SearchByName(string name)
        {
            foreach (var student in students)
            {
                if (student != null && student.FullName == name)
                {
                    Console.WriteLine($" Found: {student.FullName} | ID: {student.id} | Major: {student.Major}");
                    return;
                }
            }
            Console.WriteLine(" Student not found.");
        }
        public static void ListAllStudents()
        {
            Console.WriteLine("List All Student In System");
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine($"ID: {students[i].id}, Name: {students[i].FullName}, Major: {students[i].Major}, Status: {(students[i].IsActive ? "Active" : "Inactive")}");
            }
        }
        public static void ListAllAvailableStudents()
        {
            Console.WriteLine("List All Student In System");
            for (int i = 0; i < count; i++)
            {
                if (students[i].IsActive)
                {
                    Console.WriteLine($"ID: {students[i].id}, Name: {students[i].FullName}, Major: {students[i].Major}, Status: {(students[i].IsActive ? "Active" : "Inactive")}");

                }
            }
        }
        public static void GetTopScoringStudent()
        {
            if (count == 0)
            {
                Console.WriteLine(" No students found.");
                return;
            }
            Student TopStudent = null;
            int higest = -1;
            for (int i = 0; i < count; i++)
            {
                int total = 0;
                for (int j = 0; j < students[i].subjects.Length; j++)
                {
                    if (!string.IsNullOrEmpty(students[i].subjects[j]))
                        total += students[i].scores[j];
                }

                if (total > higest)
                {
                    higest = total;
                    TopStudent = students[i];
                }
            }
            if (TopStudent != null)
            {
                Console.WriteLine($" Top Scoring Student: {TopStudent.FullName} (ID: {TopStudent.id}) with total score: {higest}");
            }



        }
        public static void GetAverageScoreByMajor(string major)
        {
            int totalScore = 0;
            int totalSubjects = 0;

            for (int i = 0; i < count; i++)
            {
                if (students[i].Major.Equals(major, StringComparison.OrdinalIgnoreCase))
                {
                    for (int j = 0; j < students[i].subjects.Length; j++)
                    {
                        if (!string.IsNullOrEmpty(students[i].subjects[j]))
                        {
                            totalScore += students[i].scores[j];
                            totalSubjects++;
                        }
                    }
                }
            }

            if (totalSubjects == 0)
            {
                Console.WriteLine($" No subjects found for major: {major}");
            }
            else
            {
                double avg = (double)totalScore / totalSubjects;
                Console.WriteLine($" Average score for major '{major}' is: {avg:F2}");
            }
        }
        public static void RemoveStudentByID(int id)
        {
            for (int i = 0; i < count; i++)
            {
                if (students[i].id == id)
                {
                    Console.WriteLine($"Student {students[i].FullName} (ID: {id}) removed.");
                    for (int j = i; j < count - 1; j++)
                    {
                        students[j] = students[j + 1];
                    }
                    students[count - 1] = null;
                    count--;
                    return;
                }
            }

            Console.WriteLine($" No student found with ID: {id}");
        }


    }
}
