using Lab5;

namespace CompanyHR
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee e1 = new Employee(1, "ahmed", 5268, new DateTime(2020, 1, 10));
            Employee e2 = new Employee(2, "basant", 4568, new DateTime(2001, 5, 10));
            Employee e3 = new Employee(3, "walaa", 5268, new DateTime(2020, 1, 10));
            Employee e4 = new Employee(4, "jana", 4568, new DateTime(2001, 5, 10));
            Console.WriteLine($"total employee ={Employee.TotalEmployees}");
            Console.WriteLine($"total payload ={Employee.TotalPayroll}");
            Manager m1 = new Manager(1, "khaled", 1456, new DateTime(2020, 1, 5), 500);
            m1.AddTeamMember(e1);
            m1.AddTeamMember(e2);
            Console.WriteLine("manager info is ");
            m1.DisplayInfo();
            Manager m2 = new Manager(1, "afhraf", 1456, new DateTime(2020, 1, 5), 500);
            m2.AddTeamMember(e3);
            Console.WriteLine("after merge");
            Manager mergedManager = m1 + m2;
            Console.WriteLine($"Merged Manager created with total salary: {mergedManager.GetTotalSalary()}");
            Console.WriteLine($"Team Size: {mergedManager.TeamMembers.Count}");


        }
    }
}
