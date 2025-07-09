namespace GetStudentInfo
{
    internal class Program
    {
        static void GetStudentInfo(string name, out int age, out double grade)
        {
            age = 20;
            grade = 85.5;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Student Name");
            string StudentName = Console.ReadLine();
            GetStudentInfo(StudentName, out int age, out double grade);
            Console.WriteLine($"Student With Name is {StudentName} and age is {age} and grade is {grade}");
        }
    }
}
