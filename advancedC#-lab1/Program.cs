namespace advancedC__lab1
{
    internal class Program
    {
        static void Main()
        {
            Employee[] EmpArr =
      {
            new Employee(1, 111, "Ahmed", Gender.Male, 5000m, new HiringDate(15, 3, 2020), SecurityLevel.DBA),
            new Employee(2, 222, "Sara", Gender.Female, 3000m, new HiringDate(10, 1, 2022), SecurityLevel.Guest),
            new Employee(3, 333, "Ahmed", Gender.Male, 8000m, new HiringDate(15, 3, 2020),
                         SecurityLevel.Guest | SecurityLevel.Developer | SecurityLevel.Secretary | SecurityLevel.DBA)
        };

            EmployeeSearch search = new EmployeeSearch(EmpArr);
            Console.WriteLine(" Search by NationalID (222):");
            Console.WriteLine(search[222]);
            Console.WriteLine(".........................");
            Console.WriteLine(" Search by HiringDate (15/03/2020):");
            foreach (var emp in search[new HiringDate(15, 3, 2020)])
                Console.WriteLine(emp);
            Console.WriteLine(".........................");
            Console.WriteLine(" Search by Name (Ahmed):");
            foreach (var emp in search["Ahmed"])
                Console.WriteLine(emp);
        }
    }
}
