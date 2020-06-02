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
            book.AddGrade(2);
            book.AddGrade(10);

            var stats = book.GetStats();

            
            Console.WriteLine($"The lowest grade is {stats.Low}");
            Console.WriteLine($"The highest grade is {stats.High}");
            Console.WriteLine($"The average grade is {stats.Average:N2}");
            Console.WriteLine($"The Book contains {stats.Count} members");

        }
    }
}
