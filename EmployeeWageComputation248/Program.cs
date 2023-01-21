using System;

namespace EmployeeWageComputation248
{
    internal class program
    {
        static void Main(string[] args)
        {
            const int FULL_TIME = 1;
            const int PART_TIME = 2;
            const int MAX_WORKING_DAYS = 20;
            const int EMP_RATE_PER_HR = 20;
            int empHrs = 0, empWage = 0, totalWage=0, day=1;
            
            Console.WriteLine("Welcome Employee Wage Computation");
            //UC1- EmployeeAttendence
            Random random = new Random();
            for (day = 1; day <= MAX_WORKING_DAYS; day++)
            {
                int empAttendence = random.Next(0, 3);//0 or 1
                switch (empAttendence)
                {
                    case FULL_TIME:
                        Console.WriteLine("\n Full Employee is Present");
                        empHrs = 8;
                        break;
                    case PART_TIME:
                        Console.WriteLine("\n Part Employee is Present");
                        empHrs = 4;
                        break;
                    default:
                        Console.WriteLine("\n Employee is Absent");
                        empHrs = 0;
                        break;
                }
                empWage = empHrs * EMP_RATE_PER_HR;
                Console.WriteLine("Day{0} Employee Wage:{1}",day, empWage);
                //totalWage = totalWage + empWage;
                totalWage += empWage;
            }
            Console.WriteLine("Total Emplyee Wage {0} days:{1}", (day - 1), totalWage);
            Console.ReadLine();
        }
    }
}