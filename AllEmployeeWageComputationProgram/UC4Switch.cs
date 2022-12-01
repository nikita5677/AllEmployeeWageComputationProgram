using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllEmployeeWageComputationProgram
{
    class UC4Switch
    {
        //Constants
        public const int IS_PART_TIME = 1;
        public const int IS_FULL_TIME = 2;
        public const int EMP_RATE_PER_HR = 20;
        //Created a method for Employee
        public static void Employee()
        {
            //Variables
            int empHr = 0;
            int empWage = 0;

            Random random = new Random();
            //Computation
            int empCheck = random.Next(0, 3);
            switch(empCheck)
            {
                case IS_PART_TIME:
                    empHr = 4;
                    break;
                case IS_FULL_TIME:
                    empHr = 8;
                    break;
                default:
                    empHr = 0;
                    break;
            }
            empWage = empHr * EMP_RATE_PER_HR; ;
            Console.WriteLine("Employee wage is: " + empWage);
        }
    }
}
