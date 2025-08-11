using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace advancedC__lab1
{
    class EmployeeSearch
    {
        private int[] NationalIDs;
        private Employee[] Employees;

        public EmployeeSearch(Employee[] employees)
        {
            Employees = employees;
            NationalIDs = employees.Select(e => e.NationalID).ToArray();
        }

        //id
        public Employee this[int nationalId]
        {
            get
            {
                var index = Array.IndexOf(NationalIDs, nationalId);
                if (index >= 0)
                    return Employees[index];
                throw new KeyNotFoundException("Employee not found with this National ID");
            }
        }

        // history
        public Employee[] this[HiringDate date]
        {
            get
            {
                return Employees.Where(e => e.HireDate.Equals(date)).ToArray();
            }
        }

        // name
        public Employee[] this[string name]
        {
            get
            {
                return Employees.Where(e => e.Name.Equals(name, StringComparison.OrdinalIgnoreCase)).ToArray();
            }
        }
    }
   }
