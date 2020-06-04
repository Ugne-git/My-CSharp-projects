using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Codewars_solutions
{
    class Solutions
    {
        static void Main(string[] args)
        {
            //TestHowModulusWorks();
            //DigitalRoot();
           
            SumMultiples();
            //Console.ReadLine();
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
        //If we list all the natural numbers below 10 that are multiples of 3 or 5, we get 3, 5, 6 and 9. 
        //The sum of these multiples is 23.
        //Finish the solution so that it returns the sum of all the multiples of 3 or 5 below the number passed in.
        //Note: If the number is a multiple of both 3 and 5, only count it once.

        static void SumMultiples()

        {
            int sum = 0;
            Console.WriteLine("Enter a number: ");
            var input = Console.ReadLine();
            int value = int.Parse(input);
            while (value > 0)
            {
                value = value - 1;
                if (value % 3 == 0 || value % 5 == 0)
                {
                    sum = value + sum;
                }
            }

            Console.WriteLine($"The sum of multiples of 3 and 5 is: {sum}");
            Console.WriteLine("***********");
            UserInput();
        }
        static void UserInput()
        {
        Console.WriteLine("Press 1 - to continue, or 2 - to quit");
            var input = Console.ReadLine();
      
            switch (input)
            {
                case "1":
                    Console.Clear();
                    SumMultiples();
                    break;
                case "2":
                    Console.Clear();
                    Console.WriteLine("Good Bye!");
                    Thread.Sleep(1500);
                    break;
            }

        }
    }
}