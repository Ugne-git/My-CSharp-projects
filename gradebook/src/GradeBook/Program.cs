using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            var book = new Book("Ugne's Grade Book");


            while(true)
            {
                Console.WriteLine("Enter a greade or paste 'q' to quit");
                var input = Console.ReadLine();
                if(input == "q")
                {
                    break;

                }
                var grade = double.Parse(input);
                book.AddGrade(grade);
            }
            

            var stats = book.GetStats();

            Console.WriteLine($"The Grade book contains {stats.Count} members");
            Console.WriteLine($"The lowest grade is {stats.Low}");
            Console.WriteLine($"The highest grade is {stats.High}");
            Console.WriteLine($"The average grade is {stats.Average:N2}");
            Console.WriteLine($"The average grade in letters is {stats.Iskaita}");

        }
    }
}
