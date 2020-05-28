using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            var book = new Book("Ugne's Grade Book");
            book.AddGrade(9.5);
            book.AddGrade(7);
            book.AddGrade(6.5);
            book.ShowStats();

            var grades = new List<double>() {7.7, 9.3, 8, 5};
            grades.Add(7.7);

            var result = 0.0;
            var highGrade = double.MinValue;
            var lowGrade = double.MaxValue;

            foreach(var number in grades)
            {
                highGrade = Math.Max(number, highGrade);
                lowGrade = Math.Min(number, lowGrade);
                result += number;
            }

            result /= grades.Count;

            Console.WriteLine($"The lowest grade is {lowGrade}");
            Console.WriteLine($"The highest grade is {highGrade}");
            Console.WriteLine($"The average grade is {result:N2}");
        }
    }
}
