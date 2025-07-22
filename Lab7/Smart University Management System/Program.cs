using System;
   namespace Smart_University_Management_System
    {
        class Program
        {
            static void Main(string[] args)
            {
                University university = new University();
                bool exit = false;

                while (!exit)
                {
                    Console.WriteLine("\n===== Smart University Management System =====");
                    Console.WriteLine("1. Add Student");
                    Console.WriteLine("2. Assign Instructor");
                    Console.WriteLine("3. Enroll in Course");
                    Console.WriteLine("4. View Department");
                    Console.WriteLine("5. Show total student in Unversity");
                    Console.WriteLine("6. add Course");
                    Console.WriteLine("0. Exit");
                    Console.Write("Enter your choice: ");
                    string choice = Console.ReadLine();

                    switch (choice)
                    {
                        case "1":
                            AddStudentMenu(university);
                            break;
                        case "2":
                            AssignInstructorMenu(university);
                            break;
                        case "3":
                            EnrollInCourseMenu(university);
                            break;
                        case "4":
                            university.ViewDepartments();
                            break;
                        case "5":
                            UniversityStats.NumberStudent(); 
                            break;
                    case "6":
                        AddCourse(university);
                        break;
                    case "0":
                            exit = true;
                            Console.WriteLine("Goodbye!");
                            break;
                        default:
                            Console.WriteLine("Invalid choice, try again.");
                            break;
                    }
                }
            }

            static void AddStudentMenu(University university)
            {

                Console.Write("Enter name: ");
                string name = Console.ReadLine();

                Console.Write("Enter email: ");
                string email = Console.ReadLine();

                Console.Write("Enter phone: ");
                string phone = Console.ReadLine();

                Console.Write("Enter GPA: ");
                double gpa = double.Parse(Console.ReadLine());

                Console.Write("Enter street: ");
                string street = Console.ReadLine();

                Console.Write("Enter city: ");
                string city = Console.ReadLine();

                Console.Write("Enter postal code: ");
                string postal = Console.ReadLine();

                Console.Write("Enter level (Freshman, Sophomore, Junior, Senior): ");
                GradeLevel level = (GradeLevel)Enum.Parse(typeof(GradeLevel), Console.ReadLine(), true);

                Address address = new Address(street, city, postal);

                Student student = new Student(address,name, email, phone, level, gpa);
                university.AddStudent(student);
               
                Console.WriteLine(" Student added successfully.");
            }

            static void AssignInstructorMenu(University university)
            {
                Console.Write("Enter name: ");
                string name = Console.ReadLine();

                Console.Write("Enter email: ");
                string email = Console.ReadLine();

                Console.Write("Enter phone: ");
                string phone = Console.ReadLine();

                Console.Write("Enter department type (IT, HR, Business, Engineering): ");
                DepartmentType dept = (DepartmentType)Enum.Parse(typeof(DepartmentType), Console.ReadLine(), true);
            Console.Write("Enter your title ");

            string title = Console.ReadLine();
                Console.Write("Enter street: ");
                string street = Console.ReadLine();

                Console.Write("Enter city: ");
                string city = Console.ReadLine();

                Console.Write("Enter postal code: ");
                string postal = Console.ReadLine();

                Address address = new Address(street, city, postal);

                Instructor instructor = new Instructor(address, name, email, phone,title, dept);
                university.AssignInstructor(instructor);

                Console.WriteLine(" Instructor assigned successfully.");
            }

        static void EnrollInCourseMenu(University university)
        {
            Console.Write("Enter course name: ");
            string courseName = Console.ReadLine();

            Console.Write("Enter student name to enroll: ");
            string studentName = Console.ReadLine();

            Course course = university.FindCourseByName(courseName);
            Student student = university.FindStudentByName(studentName);

            if (course == null)
            {
                Console.WriteLine(" Course not found.");
                return;
            }

            if (student == null)
            {
                Console.WriteLine(" Student not found.");
                return;
            }

            try
            {
                course.Enroll(student);
                Console.WriteLine(" Student enrolled successfully.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($" Error: {ex.Message}");
            }
        }
        public static void AddCourse(University university)
        {
            Console.WriteLine("Enter department name (choose from below):");
            university.ViewDepartments();

            string deptInput = Console.ReadLine(); ;

            if (!Enum.TryParse(deptInput, true, out DepartmentType deptType))
            {
                Console.WriteLine(" Invalid department type.");
                return;
            }

            Department dept = university.FindDepartmentByType(deptType);
            if (dept == null)
            {
                Console.WriteLine(" Department not found.");
                return;
            }

            Console.Write("Enter course name: ");
            string courseName = Console.ReadLine();

            Console.Write("Enter instructor name: ");
            string instName = Console.ReadLine();

            Instructor inst = university.FindInstructorByName(instName);
            if (inst == null)
            {
                Console.WriteLine(" Instructor not found.");
                return;
            }

            Course course = new Course(courseName, inst);

            try
            {
                dept.AddCourse(course);         //  إضافة للكورس في القسم
                Console.WriteLine("Courses in  department.");
                dept.DepartmentReport();
                university.AddCourse(course);   // (إضافة للكورس في الجامعة
                Console.WriteLine("Course added successfully to department.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($" Error: {ex.Message}");
            }
        }
        



    }
}


