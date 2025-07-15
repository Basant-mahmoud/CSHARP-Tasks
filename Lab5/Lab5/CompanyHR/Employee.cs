using Lab5;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyHR
{
    internal class Employee:Person
    {
        public double BaseSalary {  get; set; }
        public DateTime HireDate {  get; set; }
        public static int TotalEmployees {  get; set; } 
       public static double TotalPayroll { get; set; }
        public Employee(int id,string fullname,double basesalary,DateTime hireDate):base(id,fullname)
        {
            BaseSalary=basesalary;
            HireDate=hireDate;
            TotalEmployees++;
            TotalPayroll += TotalEmployees;
        }
        public virtual void DisplayInfo()
        {
            Console.WriteLine($"id= {id} fullname={fullName} baseSalary={BaseSalary} hireDate={HireDate}");
        }

    }
}
