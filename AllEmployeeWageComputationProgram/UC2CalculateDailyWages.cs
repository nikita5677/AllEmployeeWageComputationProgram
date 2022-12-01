using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllEmployeeWageComputationProgram
{
    class UC2CalculateDailyWages
    {
        //Created a Method for Calculate
        public static void Calculate()
        {
            //Constants
            int IS_FULL_TIME = 1;
            int EMP_RATE_PER = 20;
            //Variables
            int empWage = 0;
            int empHr = 0;
            Random random = new Random();
            //Computation
            int empCheck = random.Next(0, 2);
            if(empCheck == IS_FULL_TIME)
            {
                empHr = 8;
            }
            else
            {
                empHr = 0;
            }
            empWage = empHr * EMP_RATE_PER;
            Console.WriteLine("Employee wage is: " + empWage);
        }
    }
}
