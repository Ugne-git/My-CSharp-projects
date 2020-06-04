using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars_solutions
{
    class Number
    {
        static void Main(string[] args)
        {
            //TestHowModulusWorks();
            DigitalRoot();
            Console.ReadLine();
        }
        //Given n, take the sum of the digits of n. If that value has more than one digit, continue reducing 
        //in this way until a single-digit number is produced. This is only applicable to the natural numbers.
        //16  -->  1 + 6 = 7
        //942  -->  9 + 4 + 2 = 15  -->  1 + 5 = 6
        //132189  -->  1 + 3 + 2 + 1 + 8 + 9 = 24  -->  2 + 4 = 6
        //493193  -->  4 + 9 + 3 + 1 + 9 + 3 = 29  -->  2 + 9 = 11  -->  1 + 1 = 2
        static void DigitalRoot()
        {
            int n;
            int root = 0;

            Console.Write("Enter a number: ");
            n = int.Parse(Console.ReadLine());

            while (n > 0 || root > 9)
            {
                if (n == 0)
                {
                    n = root;
                    root = 0;
                }

                root += n % 10;
                n /= 10;
                Console.WriteLine($"root is {root}");
                Console.WriteLine($"n is {n}");
            }

            Console.Write($"Sum is = {root}");
        }

        static void TestHowModulusWorks()
        {
            //int result;
            //int number;

            while (true)
            { 
            Console.WriteLine("Enter a number or type 'q' to quit");
            var input = Console.ReadLine();
            
                if (input == "q")
                {
                    break;
                }
                else
                {
                   var number = int.Parse(input);
                    int result = number % 10;
                    Console.WriteLine(result);
                }
                
            }
            
        }
    }
}
