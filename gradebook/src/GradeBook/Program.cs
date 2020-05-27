using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            var grades = new List<double>() {7.7, 9.3, 8, 5};
            grades.Add(7.7);

            var result = 0.0;
            foreach(var number in grades)
            {
                result += number;
            }
            result /= grades.Count;
            System.Console.WriteLine($"The average grade is {result:N2}");

            if (args.Length > 0)
            {
            Console.WriteLine($"Hello, {args[0]}!");
            }
            else
            {
                Console.WriteLine("Goodbye!");
            }
           
        }
    }
}
