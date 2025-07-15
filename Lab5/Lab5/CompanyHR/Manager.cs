using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyHR
{
    internal class Manager:Employee
    {
        public double Bonus { get; set; }
      public  List<Employee> TeamMembers {  get; set; }
        public Manager(int id, string fullname, double basesalary, DateTime hireDate,double bouns):base(id,fullname, basesalary,hireDate)
        {
            this.Bonus = bouns;
            TeamMembers = new List<Employee>();
        }
       public  double GetTotalSalary()
        {
            return BaseSalary + Bonus;
        }
         public void AddTeamMember(Employee e)
        {
            if (e != null)
            {
                TeamMembers.Add(e);
            }
        }
        public override  void DisplayInfo()
        {
            Console.WriteLine($"id={id}  fullname={fullName} hireDate= {HireDate} bouns={Bonus}");

        }
        
        public static Manager operator +(Manager a, Manager b)
        {
            var newManger= new Manager(
                id:a.id+b.id,
                fullname:a.fullName+b.fullName,
                basesalary:a.BaseSalary+b.BaseSalary,
                hireDate: DateTime.Now,
                bouns: a.Bonus + a.Bonus
                );
            foreach (Employee e in a.TeamMembers) { 
                newManger.TeamMembers.Add(e);
            }
            foreach (Employee e in b.TeamMembers)
            {
                newManger.TeamMembers.Add (e);
            }
            return newManger;
        }

    }
}
