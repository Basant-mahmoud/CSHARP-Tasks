namespace EmployeeAttendance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee[] employees = new Employee[3];
            for(int i = 0; i < employees.Length; i++)
            {
                Console.WriteLine($"Enter id of employee {i + 1}");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();

                Console.Write("Department: ");
                string department = Console.ReadLine();

                Console.WriteLine("Attendance Status (Choose one):");
                foreach(var status in Enum.GetValues(typeof(AttendanceStatus)))
                {
                    Console.WriteLine($"{(int)status }- {status}");

                }
                Console.Write("Enter status: ");
                int statusInput = int.Parse(Console.ReadLine());
                
                AttendanceStatus parsedStatus = (AttendanceStatus)statusInput;

                employees[i].SetId(id);
                employees[i].SetName(name);
                employees[i].SetDepartment(department);
                employees[i].SetStatus(parsedStatus);

                Console.WriteLine("\n--- Employee Details ---");
                employees[i].Print();
            }

        }
    }
}
