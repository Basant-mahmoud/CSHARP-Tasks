using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smart_University_Management_System
{
   public  class University
    {
        private Student[] students = new Student[50];
        private int countstudent = 0;
        private Instructor[] instructors = new Instructor[50];
        private int countInstractor = 0;
        private Department[] departments = new Department[50];
        private int countdepartment = 0;
        private Course[] Courses = new Course[50];
        private int courseCount = 0;
        public University()
        {
            foreach (DepartmentType deptType in Enum.GetValues(typeof(DepartmentType)))
            {
                if (countdepartment < 50)
                {
                    departments[countdepartment++] = new Department(deptType);
                }
            }
        }

        public void AddStudent(params Student[]  student)
        {
           foreach(var std in student)
            {
                if (countstudent < 50)
                {
                    students[countstudent] = std;
                    UniversityStats.IncrementStudentCount();
                    countstudent++;
                }
                else
                {
                    throw new Exception("Size is Full");

                }
            }
        }
        public void AssignInstructor(params Instructor[] instructor)
        {
            foreach (var ins in instructor)
            {
                if (countstudent < 50)
                {
                    instructors[countInstractor] = ins;
                    countInstractor++;
                }
                else
                {
                    throw new Exception("Size is Full");
                }
            }
        }

        public void AddCourse(params Course[] courses)
        {
            foreach (var course in courses)
            {
                if (courseCount < 50)
                {
                    Courses[courseCount++] = course;
                }
                else
                {
                    throw new Exception("Size is Full");
                }
            }


        }

        public Course FindCourseByName(string name)
        {
            for (int i = 0; i < courseCount; i++)
            {
                if (Courses[i].Name.Equals(name, StringComparison.OrdinalIgnoreCase))
                    return Courses[i];
            }
            return null;
        }
        public Student FindStudentByName(string name)
        {
            for (int i = 0; i < countstudent; i++)
            {
                if (students[i].Name.Equals(name, StringComparison.OrdinalIgnoreCase))
                    return students[i];
            }
            return null;
        }
        public Instructor FindInstructorByName(string name)
        {
            for (int i = 0; i < countInstractor; i++)
            {
                if (instructors[i].Name.Equals(name, StringComparison.OrdinalIgnoreCase))
                    return instructors[i];
            }
            return null;
        }
        public Department FindDepartmentByType(DepartmentType deptType)
        {
            for (int i = 0; i < countdepartment; i++)
            {
                if (departments[i].department == deptType)
                    return departments[i];
            }
            return null;
        }

        public void ViewStudents()
        {
            Console.WriteLine("All Students:");
            for (int i = 0; i < countstudent; i++)
            {
                students[i].DisplayProfile();
            }
        }
        public void ViewInstractors()
        {
            Console.WriteLine("All Instractor:");
            for (int i = 0; i < countInstractor; i++)
            {
                instructors[i].DisplayProfile();
            }
        }
        public void ViewDepartments()
        {
            Console.WriteLine("All Department:");
            foreach(DepartmentType dpt in Enum.GetValues(typeof(DepartmentType)))
            {
                Console.WriteLine($"{dpt}");
            }
        }
        public void SortStudentsByGPA()
        {
            Array.Sort(students, 0, countstudent, Comparer<Student>.Create((a, b) => b.GPA.CompareTo(a.GPA)));
            Console.WriteLine("Sorted by GPA:");
            ViewStudents();
        }
        public void SaveData(string path)
        {
            using StreamWriter writer = new(path);
            for (int i = 0; i < countstudent; i++)
            {
                writer.WriteLine($"{students[i].Name},{students[i].Email},{students[i].GPA}");
            }
        }

        public void LoadData(string path)
        {
            try
            {
                using StreamReader reader = new(path);
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    var parts = line.Split(',');

                    if (parts.Length == 8 &&
                        double.TryParse(parts[3], out double gpa) &&
                        Enum.TryParse(parts[7], out GradeLevel level))
                    {
                        var address = new Address(parts[4], parts[5], parts[6]);

                        var student = new Student(
                            name: parts[0],
                            email: parts[1],
                            phone: parts[2],
                            GPA: gpa,
                            address: address,
                            Level: level
                        );

                        AddStudent(student);
                    }
                    else
                    {
                        Console.WriteLine($"⚠️ Skipping invalid line: {line}");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($" Error loading data: {ex.Message}");
            }
        }





    }
}
