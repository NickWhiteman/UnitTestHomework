using System;
using LibraryVariables;

namespace TestLibrary
{
    class Program
    {
        static void Main(string[] args)
        {


            int[] test = new int[] { -5, 3, -12, 5, 1, 9 };
            int[] test1 = Cycles.PrintNumbersRangeWithEvenNumbersGreaterThanOddNumbers(22);
            int[] test2 = Cycles.PrintNumbersRangeWithEvenNumbersGreaterThanOddNumbers(36);

            //Console.WriteLine($"{test}");
            //Console.WriteLine($"{test1}");
            //Console.WriteLine($"{test2}");

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            for (int i = 0; i < test.Length; i++)
            {
                Console.Write($"{test[i]}, ");
            }

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            for (int i = 0; i < test1.Length; i++)
            {
                Console.Write($"{test1[i]}, ");
            }

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            for (int i = 0; i < test2.Length; i++)
            {
                Console.Write($"{test2[i]}, ");
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            //Console.WriteLine($"{test.Length}");
            //Console.WriteLine($"{test1.Length}");
            //Console.WriteLine($"{test2.Length}");
        }
    }
}
