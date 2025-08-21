using System;

namespace Student_Management_System
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> students = new List<string>();
            Dictionary<string, List<double>> studentgrade = new Dictionary<string, List<double>>();
            Console.WriteLine("=== Student Management System ===");
            Console.Write("Enter number of students: ");
            int studentCount;
            while (!int.TryParse(Console.ReadLine(), out studentCount) || studentCount <= 0)
            {
                Console.WriteLine("Invalid number, please enter a positive integer.");
            }

            Console.Write("Enter number of subjects per student: ");
            int subjectCount;
            while (!int.TryParse(Console.ReadLine(), out subjectCount) || subjectCount <= 0)
            {
                Console.WriteLine("Invalid number, please enter a positive integer.");
            }
            while (students.Count < studentCount)
            {
                Console.WriteLine($"enter student name {students.Count + 1} :");
                string name = Console.ReadLine().Trim();
                if (string.IsNullOrWhiteSpace(name))
                {
                    Console.WriteLine("name cant be empty");
                    continue;
                }
                if (students.Contains(name, StringComparer.OrdinalIgnoreCase))
                {
                    Console.WriteLine("Doublicated Name Not Allowed");
                    continue;
                }
                students.Add(name);
            }
            foreach(var student in students)
            {
                List<double> grades = new List<double>();
                Console.WriteLine($"enter grades for {student} (at least 3 grades)");
                while (grades.Count < subjectCount)
                {
                    Console.Write($"Grade {grades.Count + 1}: ");
                    if (double.TryParse(Console.ReadLine(), out double grade))
                    {
                        if (grade < 0 || grade > 100)
                        {
                            Console.WriteLine("Grade must be between 0 and 100!");
                            continue;
                        }
                        grades.Add(grade);
                    }
                    else
                    {
                        Console.WriteLine("Invalid number, try again!");
                    }
                }

                studentgrade[student] = grades;
            }
            students.Sort();
            Console.WriteLine("students and grades");
            foreach(var student in students)
            {
                string gradesstr = string.Join(',', studentgrade[student]);
                double avg = studentgrade[student].Average();
                Console.WriteLine($"Name: {student}");
                Console.WriteLine($"Grades: {gradesstr}");
                Console.WriteLine($"Average: {avg:F2}\n");
            }
            Console.WriteLine("=== Top 3 Students by Average ===");
            var top = studentgrade.Select(s => new { Name = s.Key, Avarege = s.Value.Average() })
                 .OrderByDescending(s => s.Avarege)
                 .Take(3);
            foreach(var s in top)
            {
                Console.WriteLine($"{s.Name}- Avarage:{s.Avarege:F2}");
            }
            Console.WriteLine("Search for student enter student Nme");
            string searchName = Console.ReadLine().Trim();
            var foundStudent = students.FirstOrDefault(s => s.Equals(searchName, StringComparison.OrdinalIgnoreCase));
            if (foundStudent != null)
            {
                Console.WriteLine($"Name :{foundStudent}");
                Console.WriteLine($"Grades:{string.Join(",", studentgrade[foundStudent])}");
                Console.WriteLine($"Average: {studentgrade[foundStudent].Average():F2}");

            }
            else
            {
                Console.WriteLine("Student not found.");
            }
            //remove
            Console.Write("\nEnter student name to remove: ");
            string removeName = Console.ReadLine().Trim();
            var studentToRemove = students.FirstOrDefault(s => s.Equals(removeName, StringComparison.OrdinalIgnoreCase));
            if (studentToRemove != null)
            {
                students.Remove(studentToRemove);
                studentgrade.Remove(studentToRemove);
                Console.WriteLine($"{studentToRemove} removed successfully!");
            }
            else
            {
                Console.WriteLine("Student not found.");
            }

            // Display final list
            Console.WriteLine("\n=== Updated Students List ===");
            foreach (var student in students)
            {
                Console.WriteLine(student);
            }


        }


    }
    
}
