using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllEmployeeWageComputationProgram
{
    class UC3AddParTimeEmpWage
    {
        //Created a Method for PartTime
        public static void PartTime()
        {
            //Constants
            int IS_PART_TIME = 1;
            int IS_FULL_TIME = 2;
            int EMP_RATE_PER_HR = 20;
            //Variables
            int empHr = 0;
            int empWage = 0;

            Random random = new Random();
            //Computation
            int empCheck = random.Next(0, 3);
            if(empCheck == IS_PART_TIME)
            {
                empHr = 4;
            }
            else if(empCheck == IS_FULL_TIME)
            {
                empHr = 8;
            }
            else
            {
                empHr = 0;
            }
            empWage = empHr * EMP_RATE_PER_HR;
            Console.WriteLine("Employee Wage is: " + empWage);
        }
    }
}
