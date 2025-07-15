namespace Student_Examination_Management_System
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            StudentContact contact1 = new StudentContact { Email = "ali@example.com", Phone = "01012345678", Address = "Cairo" };
            StudentContact contact2 = new StudentContact { Email = "sara@example.com", Phone = "01087654321", Address = "Alex" };

            
            RegularStudent s1 = new RegularStudent("Ali Ahmed", "Computer Science", contact1);
            ScholarshipStudent s2 = new ScholarshipStudent("Sara Mostafa", "Computer Science", contact2, 3000);

            
            StudentManager.AddStudent(s1);
            StudentManager.AddStudent(s2);

            StudentManager.AddScoreToStudent(s1.id, "Math", 90);
            StudentManager.AddScoreToStudent(s1.id, "Programming", 95);
            StudentManager.AddScoreToStudent(s2.id, "Math", 98);
            StudentManager.AddScoreToStudent(s2.id, "Physics", 85);

            StudentManager.ListAllStudents();

         
            StudentManager.GetTopScoringStudent();

            
            StudentManager.GetAverageScoreByMajor("Computer Science");

            
            StudentManager.RemoveStudentByID(s1.id);

            
            StudentManager.ListAllStudents();

            Console.WriteLine("\n End of Test.");
        }
    }
}
