using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeWageComputationProblemPart1
{
    internal class UC2
    {
        const int Is_Full_Time = 1;
        const int Emp_Rate_Per_Hour = 10;
        public void UseCaseTwo()
        {
            int empHrs = 0;
            int empWage = 0;
            Random randomNumber = new Random();
            int checkingNum = randomNumber.Next(0, 2);
            if (checkingNum == Is_Full_Time)
            {
                Console.WriteLine("Emp is present");
                empHrs = 8;
            }
            else
            {
                Console.WriteLine("Emp is absent");
                empHrs = 0;

            }
            empWage = empHrs * Emp_Rate_Per_Hour;
            Console.WriteLine("Emp Wage: "+ empWage);
        }
    }
}
S
