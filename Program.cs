using System;

namespace EmpWageComputation
{
    class Program
    {
        static void Main(string[] args)
        {
            int Wageperhr = 20;
            int Fulltime = 0;
            int EmployeeWage = 0;
            Random random = new Random();
            int attendance = random.Next(0, 2);
            if (attendance == 1)
            {
                Fulltime = 8;
                Console.WriteLine("Employee Is Present");
                EmployeeWage = Wageperhr * Fulltime;
                Console.WriteLine("Daily Wage of an Employee is "+EmployeeWage);
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Employee Is Absent");
                Fulltime = 0;
                EmployeeWage = Wageperhr * Fulltime;
                Console.WriteLine("Daily Wage of an Employee is " + EmployeeWage);
                Console.ReadLine();
            }
        }
    }
}
