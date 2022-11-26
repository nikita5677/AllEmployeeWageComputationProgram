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
            //UC10
            EmpWageBuilderArray empWageBuilder = new EmpWageBuilderArray();
            empWageBuilder.addCompanyEmpWage("TCS", 20, 4, 150);
            empWageBuilder.addCompanyEmpWage("Amazon", 25, 7, 200);
            empWageBuilder.addCompanyEmpWage("Infosys", 23, 3, 100);
            empWageBuilder.addCompanyEmpWage("Wipro", 28, 4, 160);
            empWageBuilder.addCompanyEmpWage("Hansen", 15, 2, 180);
            empWageBuilder.addCompanyEmpWage("Reliance", 25, 7, 240);
            empWageBuilder.addCompanyEmpWage("Apple", 40, 5, 260);
            empWageBuilder.computeEmpWage();
        }
    }
}