using System;
using LibraryVariables;

namespace TestTest
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] array = new int[,]
            {
                { 2, 4, 6, 1 },
                { 0, 3, 7, 1 },
                { 1, 9, 8, 1 }
            };

            int arrayDo = Arrays.GetCountElemGreaterNeighbors(array);
            Console.Write(arrayDo);
        }
    }
}
