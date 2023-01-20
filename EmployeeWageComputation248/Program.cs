namespace EmployeeWageComputation248
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int isPresent = 1;
            Console.WriteLine("Welcome Employee Wage Computation");
            //UC1- EmployeeAttendence
            Random random = new Random();
            int empAttendence = random.Next(0, 2);//0 or 1
            if (empAttendence == isPresent)
            {
                Console.WriteLine("Emloyee is Present");
            }
            else
            {
                Console.WriteLine("Employee is Absent");
            }
            Console.ReadLine();
        }
    }
}