using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Event
{
    class Employee
    {
        public event EventHandler<EmployeeLayOffEventArgs> EmployeeLayOff;

        protected virtual void OnEmployeeLayOff
             (EmployeeLayOffEventArgs e)
        {
            EmployeeLayOff?.Invoke(this, e);
        }

        public int EmployeeID { get; set; }

        public DateTime BirthDate { get; set; }

        public int VacationStock { get; set; }

        public  virtual bool RequestVacation(DateTime From, DateTime To)
        {
            int day = (To - From).Days + 1;
            VacationStock -= day;
            if (VacationStock < 0)
            {
                OnEmployeeLayOff(new EmployeeLayOffEventArgs
                {
                    Cause = LayOffCause.VocationStockNegation
                });
                return false;
            }
            return true;
        }

        public virtual void EndOfYearOperation()
        {
            int age = DateTime.Now.Year - BirthDate.Year;
            if (BirthDate.Date > DateTime.Now.AddYears(-age)) age--;
            if (age > 60)
            {
                OnEmployeeLayOff(new EmployeeLayOffEventArgs
                {
                    Cause = LayOffCause.AgeAbove60
                });
            }

        }
    }
}
