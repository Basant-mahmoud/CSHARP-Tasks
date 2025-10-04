namespace IncreaseSalary
{
    internal class Program
    {
        static void AddBonus(ref int salary)
        {
            salary += 1000;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your Salary");
            int salary = int.Parse(Console.ReadLine());
            AddBonus(ref salary);
            Console.WriteLine($" your Salary after bouns is {salary}");

        }
    }
}
