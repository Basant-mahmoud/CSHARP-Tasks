using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Event
{
    class BoardMember :Employee
    {
        public override void EndOfYearOperation()
        {
           // not has constarin
        }
        public override bool RequestVacation(DateTime From, DateTime To)
        {
            return true; //no constrain
        }
        // اسقاله
        public void Resgin()
        {
            OnEmployeeLayOff(new EmployeeLayOffEventArgs
            {
                Cause = LayOffCause.Resigned
            });
        }


    }
}
