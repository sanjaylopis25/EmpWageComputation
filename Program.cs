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
            const int Workingdays = 20;
            int TotalEmpWage = 0;
            int timehr = 0;
            int EmployeeWage = 0;
            for (int day=1; day<= Workingdays; day++)
            {
                Random random = new Random();
                int attendance = random.Next(0, 3);
                switch (attendance)
                {
                    case Fulltime:
                        timehr = 8;
                        Console.WriteLine("Full time Employee Is Present");
                        EmployeeWage = Wageperhr * timehr;
                        TotalEmpWage = TotalEmpWage + EmployeeWage;
                        Console.WriteLine("Daily Wage of an Employee is " + EmployeeWage);
                        break;
                    case Parttime:
                        timehr = 4;
                        Console.WriteLine("Part time Employee Is Present");
                        EmployeeWage = Wageperhr * timehr;
                        TotalEmpWage = TotalEmpWage + EmployeeWage;
                        Console.WriteLine("Daily Wage of an Employee is " + EmployeeWage);
                        break;
                    default:
                        Console.WriteLine("Employee Is Absent");
                        timehr = 0;
                        EmployeeWage = Wageperhr * timehr;
                        TotalEmpWage = TotalEmpWage + EmployeeWage;
                        Console.WriteLine("Daily Wage of an Employee is " + EmployeeWage);
                        break;
                }
            }
            Console.WriteLine("Total Wage of an Employee per 20 days a month is " + TotalEmpWage);
        }
    }
}
