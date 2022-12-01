using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllEmployeeWageComputationProgram
{
    class UC1EmpAttendance
    {
        //Created a method For Attendance
        public static void Attendance()
        {
            //Constants
            int IS_FULL_TIME = 1;
            Random random = new Random();
            //Computation
            int empcheck = random.Next(0, 2);
            if(empcheck == IS_FULL_TIME)
            {
                Console.WriteLine("Employee Is Present");
            }
            else
            {
                Console.WriteLine("Employee is absent");
            }
        }
    }
}
