using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagementSystem
{
    class Student
    {
       public  int Id {get;set;} 
       public string Name { get; set; }
       public  Gender gender { get; set; }
       public  SubjectResult[] Results { get; set; }

        public double CalculateAvarage()
        {
            if(Results==null|| Results.Length == 0)
            {
                return 0;
            }
            double sum = 0;
            for(int i = 0; i < Results.Length; i++)
            {
                sum += Results[i].Grade;
            }
            return sum / Results.Length;

        }

    }
}
