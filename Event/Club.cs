using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Event
{
    class Club
    {
        public int ClubID { get; set; }
        public String ClubName { get; set; }
        List<Employee> Members =new List<Employee>();
        public void AddMember(Employee E)
        {
            Members.Add(E);
            E.EmployeeLayOff += RemoveMember;

        }
        ///CallBackMethod 
        public void RemoveMember(object sender, EmployeeLayOffEventArgs e) 
        {
            ///Employee Will not be removed from the Club if Age>60 
            ///Employee will be removed from Club if Vacation Stock < 0
            Employee emp = sender as Employee;
            if (emp != null && Members.Contains(emp))
            {
                if (e.Cause == LayOffCause.VocationStockNegation)
                {
                    Members.Remove(emp);
                    Console.WriteLine($"Employee {emp.EmployeeID}removed from Club due to {e.Cause}");
                }
            }
        
        }
}
}
