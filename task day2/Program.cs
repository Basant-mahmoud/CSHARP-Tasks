using static System.Runtime.InteropServices.JavaScript.JSType;
using static task_day2.Program;
using System.Linq;
using System.Collections.Immutable;
namespace task_day2
{
    internal class Program
    {
        static int boxingCount = 0;
        static int unboxingCount = 0;
        public enum Gender { M,F  };
        [Flags]
        public enum Security_level
        {
            None = 0,
            Guest = 1,
            Developer = 2,
            Secretary = 4,
            DBA = 8,
            SecurityOfficer = 16 // Full permissions

        }
        public struct Hire_date
        {
            int day;
            int year;
            int month;
            public Hire_date(int day, int year, int month)
            {
                this.day = day;
                this.year = year;
                this.month = month;
            }
            public override string ToString()
            {
                return $"{day}/{month}/{year}";
            }
            public int Compareto(Hire_date other)
            {
                return (year, month, day).CompareTo((other.year, other.month, other.day));
            }

        }

        struct Employee
        {
            private  int id ;
            private float salary;
            private Hire_date hire_date ;
            private Security_level security;
            private Gender gender;
            private int age;
            public Employee(int id,float salary, Hire_date hire_date, Security_level security, Gender gender, int age)
            {
                this.id = id;
                this.salary = salary;
                this.hire_date=hire_date;
                this.security = security;
                this.gender = gender;
                this.age = age;
            }
            public int GetId()
            {
                return id ;
            }
            public float GetSalary()
            {
                return salary;
            }
            public Hire_date GetHireDate()
            {
                return hire_date;
            }
            public Security_level GetSecurity()
            {
                return security;
            }
            public Gender GetGender()
            {
                return gender;
            }
            public int GetAge()
            {
                return age;
            }
            public void SetID(int id)
            {
                this.id =id;
            }
            public void SetSalary(float salary)
            { this.salary = salary;}
            public void SetAge(int age) {  this.age = age;}
            public void SetGender(Gender gender) { this.gender = gender;}
            public void SetSecurity(Security_level security) { this.security = security;}
            public void SetHire_date(Hire_date hire_date) {this.hire_date = hire_date;}
            public override string ToString()
            {
                return $"ID: {id}, Gender: {gender}, Salary: {salary:C}, Hire Date: {hire_date}, Privileges: {security}";
            }

        } 
        static void Main(string[] args)
        {
            Employee[] employees = new Employee[1];
            for (int i = 0; i < employees.Length; i++)
            {
                Console.WriteLine($"enter details for employee {i+1}");
                Console.WriteLine("enter employee ID");
                int id = int.Parse(Console.ReadLine());
                Console.WriteLine("enter employee Gender M,F");
                Gender gender = (Gender)Enum.Parse(typeof(Gender), Console.ReadLine(), true);
                Console.WriteLine("enter employee age");
                int age =int.Parse(Console.ReadLine());
                Console.Write("Enter Hire Date (Day Month Year): ");
                string[] hireDateParts = Console.ReadLine().Split(' ');
                int day = int.Parse(hireDateParts[0]);
                int month = int.Parse(hireDateParts[1]);
                int year = int.Parse(hireDateParts[2]);
                Hire_date hireDate = new Hire_date(day, month, year);
                Console.Write("Enter Security Privileges (Guest, Developer, Secretary, DBA, SecurityOfficer): ");
                Security_level privileges = (Security_level)Enum.Parse(typeof(Security_level), Console.ReadLine(), true);
                Console.WriteLine("enter employee salary");
                float salary =float.Parse(Console.ReadLine());
                employees[i]=new Employee(id, salary, hireDate,privileges,gender,age);


            }
            foreach(var employee in employees)
            {
                Console.WriteLine(employee.ToString());
                Console.WriteLine();    
            }
            Array.Sort(employees, (e1, e2) =>
            {
                object obj1 = e1.GetHireDate(), obj2 = e2.GetHireDate();
                boxingCount += 2;//here boxing
                return ((Hire_date)obj1).Compareto((Hire_date)obj2);
            });
            Console.WriteLine("employes after sorting");
            Console.WriteLine($"\nBoxing occurred {boxingCount} times.");
            Console.WriteLine($"Unboxing occurred {unboxingCount} times.");
        }
    }
}
