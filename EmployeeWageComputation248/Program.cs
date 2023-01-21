using System;

namespace EmployeeWageComputation248
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int FULL_TIME = 1;
            int EMP_RATE_PER_HR = 20;
            int empHrs = 0, empWage = 0;

            Console.WriteLine("Welcome Employee Wage Computation");
            //UC1- EmployeeAttendence
            Random random = new Random();
            int empAttendence = random.Next(0, 2);//0 or 1
            if (empAttendence == FULL_TIME)
            {
                Console.WriteLine("Emloyee is Present");
                empHrs = 8;
            }
            else
            {
                Console.WriteLine("Employee is Absent");
                empHrs = 0;
            }
            empWage = empHrs * EMP_RATE_PER_HR;
            //Console.WriteLine("Emplyee" + EmpWage + "Wage:");
            Console.WriteLine("Emplyee Wage {0}",empWage);
            Console.ReadLine();
        }
    }
}