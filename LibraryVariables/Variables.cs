using System;


namespace LibraryVariables
{
    public class Variables
    {
        //Variables
        public static double SolveFractionalEquation(double a, double b)
        {
            if (a == b)
            {
                throw new Exception("Error double a and double b doesn't equal");
            }

            double result = (5 * a + (double)Math.Pow(b, 2)) / (b - a);
            return (int)result;
        }

        public static int[] ReturnsTheRemainderOfTheDivisionAndResult(int a, int b)
        {
            int division = a / b;
            int ramainderOfTheDucusion = a % b;
            int[] ArraySolution = new int[] { division, ramainderOfTheDucusion };
            return ArraySolution;
        }

        public static double SolvesAQuadraticEquation(double a, double b, double c)
        {
            double x = (c - b) / a;
            return x;
        }

        public static int[] DoDiscriminantSolution(int x1, int y1, int x2, int y2)
        {
            int a = (x1 - y2) / (x1 - x2);
            int b = y2 - a * x2;
            int[] calculateResult = new int[] { a, b };
            return calculateResult;
        }

        //Conditions

        public static int ConpaireAndGetASolution(int a, int b)
        {
            int calculateResult = 0;

            if (a > b)
            {
                calculateResult = a + b;
            }
            else if (a == b)
            {
                calculateResult = a * b;
            }
            else if (a < b)
            {
                calculateResult = a - b;
            }
            return calculateResult;
        }

        public static string DefiningAQuarterInACoordinateSystem(int x, int y)
        {
            string coordinate = "";
            if (x > 0 && y > 0)
            {
                coordinate = $"Точка с координатами {x}, {y} находится во 2 четверти";
            }
            else if (x < 0 && y < 0)
            {
                coordinate = $"Точка с координатами {x}, {y} находится в 3 четверти";
            }
            else if (x < 0 && y > 0)
            {
                coordinate = $"Точка с координатами {x}, {y} находится в 1 четверти";
            }
            else if (x > 0 && y < 0)
            {
                coordinate = $"Точка с координатами {x}, {y} находится в 4 четверти";
            }
            else if (x == 0 && y == 0)
            {
                coordinate = $"Точка с координатами {x}, {y} находится в позиции ноль";
            }
            return coordinate;
        }

        public static string BringFromLargestToSSmallest(int a, int b, int c)
        {
            string largestToSSmallest = "";

            if (a > b && a > c && b > c)
            {
                largestToSSmallest = $"{c}, {b}, {a} от меньшему к большему";
            }
            else if (b > a && b > c && a > c)
            {
                largestToSSmallest = $"{c}, {a}, {b} от меньшему к большему";
            }
            else if (c > a && c > b && a > b)
            {
                largestToSSmallest = $"{b}, {a}, {c} от меньшему к большему";
            }
            else if (a > b && a > c && c > b)
            {
                largestToSSmallest = $"{b}, {c}, {a} от меньшему к большему";
            }
            else if (b > a && b > c && c > a)
            {
                largestToSSmallest = $"{a}, {c}, {b} от меньшему к большему";
            }
            else if (c > a && c > b && b > a)
            {
                largestToSSmallest = $"{a}, {b}, {c} от меньшему к большему";
            }
            else if (c > a && c > b && b == a)
            {
                largestToSSmallest = $"{a}, {b}, {c} от меньшему к большему";
            }
            else if (c == a && c == b && b == a)
            {
                largestToSSmallest = $"{a}, {b}, {c} от меньшему к большему";
            }
            else if (c == a && c > b)
            {
                largestToSSmallest = $"{b}, {a}, {c} от меньшему к большему";
            }
            else if (c > a && c == b)
            {
                largestToSSmallest = $"{a}, {b}, {c} от меньшему к большему";
            }

            return largestToSSmallest;
        }

        public static double[] SolutionQuadraticEquationStandard(double a, double b, double c)
        {
            if (a == 0)
            {
                throw new Exception("Parameter a can't be 0");
            }

            double d = b * b - 4 * a * c;

            if (d < 0)
            {
                return new double[0];
            }
            else if (d == 0)
            {
                return new double[1] { -b / (2 * a) };
            }
            else
            {
                return new double[2] { (-b + Math.Sqrt(d)) / (2 * a), (-b - Math.Sqrt(d)) / (2 * a) };
            }
        }

        public static string WriteNumberInWords(int a)
        {
            string solution = "";
            string[] numbers =
            {
                "ноль",
                "один",
                "два",
                "три",
                "четыре",
                "пять",
                "шесть",
                "cемь",
                "восемть",
                "девять",
                "десять",
                "одиннадцать",
                "двенадцать",
                "тринадцать",
                "четырнадцать",
                "пятнадцать",
                "шестьнадцать",
                "семнадцать",
                "восемнадцать",
                "девятнадцать",
                "двадцать",
                "двадцать один",
                "двадцать два",
                "двадцать три",
                "двадцать четыре",
                "двадцать пять",
                "двадцать шесть",
                "двадцать семь",
                "двадцать восемь",
                "двадцать девять",
                "тридцать",
                "тридцать один",
                "тридцать два",
                "тридцать три",
                "тридцать четыре",
                "тридцать пять",
                "тридцать шесть",
                "тридцать семь",
                "тридцать восемь",
                "тридцать девять",
                "сорок",
                "сорок один",
                "сорок два",
                "сорок три",
                "сорок четыре",
                "сорок пять",
                "сорок шесть",
                "сорок семь",
                "сорок восемь",
                "сорок девять",
                "пятьдесят",
                "пятьдесят один",
                "пятьдесят два",
                "пятьдесят три",
                "пятьдесят четрые",
                "пятьдесят пять",
                "пятьдесят шесть",
                "пятьдесят семь",
                "пятьдесят восемь",
                "пятьдесят девять",
                "шестьдесят",
                "шестьдесят один",
                "шестьдесят два",
                "шестьдесят три",
                "шестьдесят четыре",
                "шестьдесят пять",
                "шестьдесят шесть",
                "шестьдесят семь",
                "шестьдесят восемь",
                "шестьдесят девять",
                "семдесят",
                "семдесят один",
                "семдесят два",
                "семдесят три",
                "семдесят четыре",
                "семдесят пять",
                "семдесят шесть",
                "семдесят семь",
                "семдесят восемь",
                "семдесят девять",
                "восемдесят",
                "восемдесят один",
                "восемдесят два",
                "восемдесят три",
                "восемдесят четыре",
                "восемдесят пять",
                "восемдесят шесть",
                "восемдесят семь",
                "восемдесят восемь",
                "восемдесят девять",
                "девяносто",
                "девяносто одия",
                "девяносто два",
                "девяносто три",
                "девяносто четыре",
                "девяносто пять",
                "девяносто шесть",
                "девяносто cемь",
                "девяносто восемть",
                "девяносто девять"
            };

            if (a < 0)
            {
                for (int i = 0; i < numbers.Length; i++)
                {
                    if (-a == i)
                    {
                        solution ="минус " + numbers[i];
                    }
                }
            }
            else if (a > 99 || a < 9)
            {
                solution = "введите 2-х значное число";
            }
            else
            {
                for (int i = 0; i < numbers.Length; i++)
                {
                    if (a == i)
                    {
                        solution = numbers[i];
                    }
                }
            }
            
            return solution;

        }


    }
}