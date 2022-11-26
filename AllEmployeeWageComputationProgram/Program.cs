using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllEmployeeWageComputationProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            //UC11
            EmpWageArray empWageBuilder = new EmpWageArray();
            empWageBuilder.addCompanyEmpWage("TechMahindra", 25, 7, 160);
            empWageBuilder.addCompanyEmpWage("TripStack", 22, 10, 230);
            empWageBuilder.addCompanyEmpWage("LG", 23, 3, 100);
            empWageBuilder.addCompanyEmpWage("Wipro", 28, 4, 160);
            empWageBuilder.addCompanyEmpWage("Enzigma", 15, 2, 180);
            empWageBuilder.addCompanyEmpWage("HCL", 25, 7, 240);
            empWageBuilder.addCompanyEmpWage("Samsung", 41, 10, 210);
            empWageBuilder.computeEmpWage();
        }
    }
}