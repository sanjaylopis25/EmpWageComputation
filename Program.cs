using System;

namespace EmpWageComputation
{
    class Program
    {
        static void Main(string[] args)
        {
            int Wageperhr = 20;
            const int Fulltime = 1;
            const int Parttime = 2;
            int timehr = 0;
            int EmployeeWage = 0;
            Random random = new Random();
            int attendance = random.Next(0, 3);
            switch (attendance)
            {
                case Fulltime :
                    timehr = 8;
                    Console.WriteLine("Full time Employee Is Present");
                    EmployeeWage = Wageperhr * timehr;
                    Console.WriteLine("Daily Wage of an Employee is " + EmployeeWage);
                    Console.ReadLine();
                    break;
                case Parttime:
                    timehr = 4;
                    Console.WriteLine("Part time Employee Is Present");
                    EmployeeWage = Wageperhr * timehr;
                    Console.WriteLine("Daily Wage of an Employee is " + EmployeeWage);
                    Console.ReadLine();
                    break;
                default:
                    Console.WriteLine("Employee Is Absent");
                    timehr = 0;
                    EmployeeWage = Wageperhr * timehr;
                    Console.WriteLine("Daily Wage of an Employee is " + EmployeeWage);
                    Console.ReadLine();
                    break;
            }
        }
    }
}
