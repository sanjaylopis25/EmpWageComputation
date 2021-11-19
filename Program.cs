using System;

namespace EmpWageComputation
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int attendance = random.Next(0, 2);
            if (attendance == 1)
            {
                Console.WriteLine("Employee Is Present");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Employee Is Absent");
                Console.ReadLine();
            }
        }
    }
}
