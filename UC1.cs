﻿using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeWageComputationProblemPart1
{
    internal class UC1
    { 
        public void UseCase()
    
        {
        const int Is_Full_Time = 1;
        Random randomNumber = new Random();
        int checkingNum = randomNumber.Next(0, 2);
            if (checkingNum == Is_Full_Time)
            {
                Console.WriteLine( "Emp is present");
            }
            else
            {
                Console.WriteLine("Emp is absent");

            }

        }

    }
}
