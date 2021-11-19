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
            const int EmployeeHrs = 100;
            int TotalEmpWage = 0;
            int timehr = 0;
            int EmployeeWage = 0;
            int TotalEmpHrs = 0;
            int TotalWorkingDays = 1;
            while (TotalEmpHrs <= EmployeeHrs && TotalWorkingDays < Workingdays)
            {
                TotalWorkingDays++;
                Random random = new Random();
                int attendance = random.Next(0, 3);
                switch (attendance)
                {
                    case Fulltime:
                        timehr = 8;
                        //Added TotalEmpHrs variable because time hr changes in loop but workingdays don't
                        TotalEmpHrs = TotalEmpHrs + timehr;
                        Console.WriteLine("Full time Employee Is Present");
                        EmployeeWage = Wageperhr * timehr;
                        TotalEmpWage = TotalEmpWage + EmployeeWage;
                        Console.WriteLine("Daily Wage of an Employee is " + EmployeeWage);
                        break;
                    case Parttime:
                        timehr = 4;
                        TotalEmpHrs = TotalEmpHrs + timehr;
                        Console.WriteLine("Part time Employee Is Present");
                        EmployeeWage = Wageperhr * timehr;
                        TotalEmpWage = TotalEmpWage + EmployeeWage;
                        Console.WriteLine("Daily Wage of an Employee is " + EmployeeWage);
                        break;
                    default:
                        Console.WriteLine("Employee Is Absent");
                        timehr = 0;
                        TotalEmpHrs = TotalEmpHrs + timehr;
                        EmployeeWage = Wageperhr * timehr;
                        TotalEmpWage = TotalEmpWage + EmployeeWage;
                        Console.WriteLine("Daily Wage of an Employee is " + EmployeeWage);
                        break;
                }
                
            }
            Console.WriteLine("Total Employee Hours: "+TotalEmpHrs+ ". Total Working Days: "+TotalWorkingDays);
            Console.WriteLine("Total Wage of an Employee per 20 days a month is " + TotalEmpWage);
            Console.ReadLine();
        }
    }
}
