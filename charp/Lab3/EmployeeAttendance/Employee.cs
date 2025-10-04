using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeAttendance
{
    struct Employee
    {
        int Id;
        string Name;
        string Department;
        AttendanceStatus Status;
        public void SetId(int _Id)
        {
            Id = _Id;
        }
        public void SetName(String _Name)
        {
            Name = _Name;
        }
        public void SetDepartment(String _Department)
        {
            Department = _Department;
        }
        public void SetStatus(AttendanceStatus _Status)
        {
            Status = _Status;
        }
        public void Print()
        {
            Console.WriteLine($"emplyee details id={Id} Name= {Name} Department ={Department} Status={Status}");
        }

    }
}
