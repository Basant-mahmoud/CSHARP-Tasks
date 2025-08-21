using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Event
{
    class SalesPerson:Employee
    {
        public int AchievedTarget { get; set; }
        public bool CheckTarget(int Quota)
        {
            if(AchievedTarget< Quota)
            {
                // لو فشل ف تحقيق التارجت شيله
                OnEmployeeLayOff(new EmployeeLayOffEventArgs
                {
                    Cause = LayOffCause.FailedSalesTarget
                });
                return false;
            }
            return true;
        }
        public override bool RequestVacation(DateTime From, DateTime To)
        {
          
            return true;
        }

        public override void EndOfYearOperation()
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
