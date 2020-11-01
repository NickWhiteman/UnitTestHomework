using System;

namespace LibraryVariables
{
    public class Cycles
    {

        public static double GetExponentiation(int a, int b)
        {
            double resultSolution = 1;
            if (b >= 0)
            {
                for (int i = 0; i < b; i++)
                {
                    resultSolution *= a;
                }
            }
            return resultSolution;
        }

        public static int[] GiveNumbersThatDivideThousand(int a)
        {
            int[] numbersDivides = new int[1000];
            int amountArray = 0;

            if (a == 0)
            {
                throw new Exception("Error: You can't divide by 0");
            }
            else
            {
                for (int i = 1; i <= 1000; i++)
                {
                    if (i % a == 0)
                    {
                        do
                        {
                            numbersDivides[amountArray] = i;
                            amountArray++;
                        }
                        while (false);
                    }
                }

                int[] filterArray = new int[amountArray];

                for (int j = 0; j < numbersDivides.Length; j++)
                {
                    if (numbersDivides[j] > 0)
                    {
                        filterArray[j] = numbersDivides[j];
                    }
                }
                return filterArray;
            }


        }

        public static int ReturnsPositiveNumberOfNumbers(int a)
        {
            int amountNumbers = 0;

            if (a > 0)
            {
                for (int i = 1; i < a; i++)
                {
                    double exponentiation = Math.Pow(i, 2);

                    if (a > exponentiation)
                    {
                        amountNumbers++;
                    }

                }
            }
            else
            {
                throw new Exception("Error: int a - a positive number greater than 0 is expected");
            }

            return amountNumbers;
        }

        public static int GetGreatestDivider(int a)
        {
            int LargeDivisor = 0;

            if (a % 2 == 0)
            {
                return LargeDivisor = a / 2;
 
            }
            else
            {
                return a;
            }
        }

        public static int GetAmountFromRange(int a, int b)
        {
            int amountRange = 0;
            if (b > a)
            {
                for (int i = a; i <= b; i++)
                {
                    if (i % 7 == 0)
                    {
                        amountRange += i;
                    }
                }

                return amountRange;
            }
            else
            {
                int c = a;
                a = b;
                b = c;

                for (int i = a; i <= b; i++)
                {
                    if (i % 7 == 0)
                    {
                        amountRange += i;
                    }
                }

                return amountRange;
            }
        }

        public static int[] ReturnFibonacciRange(int a)
        {
            if (a < 0)
            {
                throw new Exception("I expect a positive number > 0");
            }
            else
            {
                int countNumber = 2;
                int[] fibonacci = new int[100];
                fibonacci[0] = 0;
                fibonacci[1] = 1;
                int fibonacci1 = 1;
                int fibonacci2 = 2;

                for (int i = 2; i < a; i++)
                {
                    int b = fibonacci1;
                    fibonacci1 = fibonacci2;
                    fibonacci2 = b + fibonacci1;
                    fibonacci[i] = b;
                    countNumber++;
                }


                int[] returnFibanacci = new int[countNumber];

                for (int j = 0; j < fibonacci.Length; j++)
                {
                    if (fibonacci[j] > 0)
                    {
                        returnFibanacci[j] = fibonacci[j];
                    }
                }

                return returnFibanacci;
            }
        }

        public static int EuclideanAlgorithm(int a, int b)
        {
            int c = 0;

            if (a > b)
            {
                while (b != 0)
                {
                    c = a % b;
                    a = b;
                    b = c;
                }
                return a;
            }
            else
            {
                while (a != 0)
                {
                    c = b % a;
                    b = a;
                    a = c;
                }
                return b;
            }
        }

        public static int GetHalfDivision(int a)//Выяснить почему не работает
        {
            int n = 0;
            int leftBound = 0;
            int rightBound = a;

            while (Math.Pow(n, 3) != a)
            {
                n = (leftBound + rightBound) / 2;
                if (Math.Pow(n, 3) > a)
                {
                    rightBound = n;
                }
                else
                {
                    leftBound = n;
                }
            }

            return n;
        }

        public static int GetAmountOddNumbers(int a)
        {
            int amountOdd = 0;
                
            for (int i = 0; i < a; i++)
            {
                if (i % 2 != 0)
                {
                    amountOdd++;
                }
            }

            return amountOdd;
        }

        public static int GetMirrorNumbers(int a)
        {
            int revers = 0;

            while (a > 0)
            {
                int remains = a % 10;
                revers = revers * 10 + remains;
                a = a / 10;
            }

            return revers;   
        }

        public static int[] PrintNumbersRangeWithEvenNumbersGreaterThanOddNumbers(int a)
        {
            int even = 0;
            int odd = 0;

            for (int i = 0; i <= a; i++)
            {
                if (i % 2 == 0)
                {
                    even += i;
                }
                else
                {   
                    odd += i;
                }
            }

            int[] arrayCalculate = new int[100];
            int countIteration = -1;
            int countReArray = 0;

            if (even > odd)
            {
                for (int i = 0; i <= a; i++)
                {
                    if (i % 2 == 0)
                    {
                        arrayCalculate[i] = i;
                        countIteration++;
                    }
                }
            }

            int[] solutionResult = new int[countIteration];

            for (int j = 0; j < arrayCalculate.Length; j++) 
            {
                if (arrayCalculate[j] > 0)
                {
                    solutionResult[countReArray] = arrayCalculate[j];
                    countReArray++;
                }
            }

            return solutionResult;

        }

        public static string ReturnsIfTheNumberIsRepeated(int a, int b)
        {
            string StrA = Convert.ToString(a);
            string StrB = Convert.ToString(b);
            string solitionString = "";

            if (a == b)
            {
                solitionString = "Да";
            }
            else
            {
                 if (StrA.Length > StrB.Length)
                 {
                     for (int i = 0; i < StrA.Length; i++)
                     {
                         for (int j = 0; j < StrB.Length; j++)
                         {
                             if (StrA[i] == StrB[j])
                             {
                                 solitionString = "Да";
                                 break;
                             }
                             else
                             {
                                 solitionString = "Нет";
                             }
                         }
                     }
                 }
                 else
                 {
                     for (int i = 0; i < StrB.Length; i++)
                     {
                         for (int j = 0; j < StrA.Length; j++)
                         {
                             if (StrA[j] == StrB[i])
                             {
                                 solitionString = "Да";
                                 break;
                             }
                             else
                             {
                                 solitionString = "Нет";
                             }
                         }
                     }
                 }
            }
           return solitionString;
        }
    }
}
