using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace advancedC__lab1
{
    struct Employee
    {
        public int Id { get; set; }
        public int NationalID { get; set; } // new
        public string Name { get; set; }
        public Gender Gender { get; set; }
        public decimal Salary { get; set; }
        public HiringDate HireDate { get; set; }
        public SecurityLevel SecurityLevel { get; set; }

        public Employee(int id, int nationalId, string name, Gender gender, decimal salary, HiringDate hireDate, SecurityLevel securityLevel)
        {
            Id = id;
            NationalID = nationalId;
            Name = name;
            Gender = gender;
            Salary = salary;
            HireDate = hireDate;
            SecurityLevel = securityLevel;
        }

        public override string ToString()
        {
            return $"ID: {Id}, Name: {Name}, Gender: {Gender}, NationalID: {NationalID}, " +
                   $"Salary: {string.Format(CultureInfo.CurrentCulture, "{0:C}", Salary)}, " +
                   $"Hire Date: {HireDate}, Security Level: {SecurityLevel}";
        }
    }
}
