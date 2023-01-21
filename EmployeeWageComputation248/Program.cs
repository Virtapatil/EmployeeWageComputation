using System;

namespace EmployeeWageComputation248
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int FULL_TIME = 1;
            const int PART_TIME = 2;
            int EMP_RATE_PER_HR = 20;
            int empHrs = 0, empWage = 0;
            
            Console.WriteLine("Welcome Employee Wage Computation");
            //UC1- EmployeeAttendence
            Random random = new Random();
            int empAttendence = random.Next(0, 3);//0 or 1
            switch (empAttendence)
            {
                case FULL_TIME:
                    Console.WriteLine("Full Employee is Present");
                    empHrs = 8;
                    break;
                case PART_TIME:
                    Console.WriteLine("Part Employee is Present");
                    empHrs = 4;
                    break;
                default:
                    break;
            }
            empWage = empHrs * EMP_RATE_PER_HR;
            //Console.WriteLine("Emplyee" + EmpWage + "Wage:");
            Console.WriteLine("Emplyee Wage {0}",empWage);
            Console.ReadLine();
        }
    }
}