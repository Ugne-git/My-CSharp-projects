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
                try
                {
                var grade = double.Parse(input);
                book.AddGrade(grade);
                }
                catch(ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                catch(FormatException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    Console.WriteLine("**");
                }
            }
            

            var stats = book.GetStats();

            Console.WriteLine($"The Grade book \"{book.Name}\" contains {stats.Count} members");
            Console.WriteLine($"The lowest grade is - {stats.Low}");
            Console.WriteLine($"The highest grade is - {stats.High}");
            Console.WriteLine($"The average grade is - {stats.Average:N2}");
            Console.WriteLine($"The average grade description is \"{stats.GradeDescr}\"");
            Console.WriteLine($"The average grade converted in US Grade is - \"{stats.USGrade}\"");

        }
    }
}
