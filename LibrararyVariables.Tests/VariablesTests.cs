using NUnit.Framework;
using LibraryVariables;

namespace LibrararyVariables.Tests
{
    public class VariablesTests
    {
        [TestCase(5, 6, 61)]
        [TestCase(4, 2, -12)]
        [TestCase(7, 8, 99)]
        [TestCase(2, 3, 19)]

        public void SolveFractionalEquationTest(double a, double b, double expected)
        {
            //double expected = 61; //ожидаемое значение
            double actual = Variables.SolveFractionalEquation(a, b); // тестируемый метод
            Assert.AreEqual(expected, actual);
        }

        [TestCase(12, 5, new double[2] { 2, 2 })]
        [TestCase(2, 5, new double[2] { 0, 2 })]
        [TestCase(3, 9, new double[2] { 0, 3 })]

        public void ReturnsTheRemainderOfTheDivisionAndResultTest(int a, int b, double[] expected)
        {
            int[] actual = Variables.ReturnsTheRemainderOfTheDivisionAndResult(a, b); // тестируемый метод
            Assert.AreEqual(expected, actual);
        }

        [TestCase(3, 6, 8, 0.6666666666666666)]
        [TestCase(12, 4, 7, 0.25)]
        [TestCase(43, 34, 67, 0.7674418604651163)]

        public void SolvesAQuadraticEquationTest(double a, double b, double c, double expected)
        {
            double actual = Variables.SolvesAQuadraticEquation(a, b, c);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(4, 6, 3, 6, new int[2] { -2, 12 })]
        [TestCase(8, 7, 4, 1, new int[2] { 1, -3 })]
        [TestCase(8, 6, 5, 3, new int[2] { 1, -2 })]

        public void DoDiscriminantSolutionTest(int x1, int y1, int x2, int y2, int[] expected)
        {
            int[] actual = Variables.DoDiscriminantSolution(x1, y1, x2, y2);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(12, 43, -31)]
        [TestCase(32, 65, -33)]
        [TestCase(46, 34, 80)]

        public void ConpaireAndGetASolutionTest(int a, int b, int expected)
        {
            int actual = Variables.ConpaireAndGetASolution(a, b);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(5, 12, 5, new double[2] { -0.53667504192892, -1.86332495807108 })]
        [TestCase(6, 34, 23, new double[2] { -0.7852990454259153, -4.881367621240751 })]
        [TestCase(12, 43, 13, new double[2] { -0.3333333333333333, -3.25 })]

        public void SolutionQuadraticEquationStandardTest(double a, double b, double c, double[] expected)
        {
            double[] actual = Variables.SolutionQuadraticEquationStandard(a, b, c);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(0, 12, 5)]
        [TestCase(0, 34, 23)]
        [TestCase(0, 43, 13)]

        public void SolutionQuadraticEquationStandardNegativeTest(double a, double b, double c)
        {
            try
            {
                double[] actual = Variables.SolutionQuadraticEquationStandard(a, b, c);
            }
            catch
            {
                Assert.Pass();
            }
            Assert.Fail();
        }

        [TestCase(4, 2, 16)]
        [TestCase(5, 6, 15625)]
        [TestCase(2, 1, 2)]

        public void GetExponentiation(int a, int b, double expected)
        {
            double actual = Cycles.GetExponentiation(a, b);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(360, new int[2] { 360, 720 })]
        [TestCase(650, new int[1] { 650 })]
        [TestCase(446, new int[2] { 446, 892 })]
        public void GiveNumbersThatDivideThousand(int a, int[] expected)
        {
            int[] actual = Cycles.GiveNumbersThatDivideThousand(a);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(0)]
        [TestCase(-25)]
        [TestCase(-450)]
        public void GiveNumbersThatDivideThousandNegative(int a)
        {
            try
            {
                int[] actual = Cycles.GiveNumbersThatDivideThousand(a);
            }
            catch
            {
                Assert.Pass();
            }

        }

        [TestCase(12, 3)]
        [TestCase(4, 1)]
        [TestCase(34, 5)]
        public void ReturnsPositiveNumberOfNumbers(int a, int expected)
        {
            double actual = Cycles.ReturnsPositiveNumberOfNumbers(a);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(0)]
        [TestCase(-23)]
        [TestCase(-3)]
        public void ReturnsPositiveNumberOfNumbersNegative(int a)
        {
            try
            {
                double actual = Cycles.ReturnsPositiveNumberOfNumbers(a);
            }
            catch
            {
                Assert.Pass();
            }
        }

        [TestCase(539, 539)]
        [TestCase(44, 22)]
        [TestCase(23, 23)]
        public void GetGreatestDivider(int a, int expected)
        {
            double actual = Cycles.GetGreatestDivider(a);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(30, 25, 28)]
        [TestCase(12, 37, 98)]
        [TestCase(-12, 23, 35)]
        public void GetAmountFromRange(int a, int b, int expected)
        {
            double actual = Cycles.GetAmountFromRange(a, b);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(7, new int[] { 0, 1, 1, 2, 3, 5, 8 })]
        [TestCase(12, new int[] { 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89 })]
        [TestCase(23, new int[] { 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377, 610, 987, 1597, 2584, 4181, 6765, 10946, 17711 })]

        public void ReturnFibonacciRange(int a, int[] expected)
        {
            int[] actual = Cycles.ReturnFibonacciRange(a);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(0)]
        [TestCase(-12)]
        [TestCase(-23)]
        public void ReturnFibonacciRangeNegative(int a)
        {
            try
            {
                int[] actual = Cycles.ReturnFibonacciRange(a);
            }
            catch
            {
                Assert.Pass();
            }
        }

        [TestCase(2, 5, 1)]
        [TestCase(4, 2, 2)]
        [TestCase(23, 34, 1)]
        public void EuclideanAlgorithm(int a, int b, int expected)
        {
            int actual = Cycles.EuclideanAlgorithm(a, b);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(7, 3)]
        [TestCase(22, 11)]
        [TestCase(12, 6)]
        public void GetAmountOddNumbers(int a, int expected)
        {
            int actual = Cycles.GetAmountOddNumbers(a);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(7253, 3527)]
        [TestCase(22764, 46722)]
        [TestCase(365, 563)]
        public void GetMirrorNumbers(int a, int expected)
        {
            int actual = Cycles.GetMirrorNumbers(a);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(12, new int[] { 2, 4, 6, 8, 10, 12 })]
        [TestCase(22, new int[] { 2, 4, 6, 8, 10, 12, 14, 16, 18, 20, 22 })]
        [TestCase(36, new int[] { 2, 4, 6, 8, 10, 12, 14, 16, 18, 20, 22, 24, 26, 28, 30, 32, 34, 36 })]
        public void PrintNumbersRangeWithEvenNumbersGreaterThanOddNumbers(int a, int[] expected)
        {
            int[] actual = Cycles.PrintNumbersRangeWithEvenNumbersGreaterThanOddNumbers(a);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 5, 3, 12, 5, 1, 9 }, 12)]
        [TestCase(new int[] { 24, 3, 1, 25, 11, 9 }, 25)]
        [TestCase(new int[] { 1, 2, 3, 5, 1, 19 }, 19)]
        public void GetMaxElementArrays(int[] a, int expected)
        {
            int actual = Arrays.GetMaxElementArrays(a);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 5, 3, 12, 5, 1, 9 }, 1)]
        [TestCase(new int[] { 24, 3, 1, 25, 11, 9 }, 1)]
        [TestCase(new int[] { 1, 2, 3, 5, 1, 19 }, 1)]
        public void GetMinElementArrays(int[] a, int expected)
        {
            int actual = Arrays.GetMinElementArrays(a);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { -5, 3, -12, 5, 1, 9 }, 5)]
        [TestCase(new int[] { 24, 3, 1, -25, 11, 9 }, 0)]
        [TestCase(new int[] { 1, 2, 3, 5, 1, -19 }, 3)]
        public void GetIndexMaxElementArrays(int[] a, int expected)
        {
            int actual = Arrays.GetIndexMaxElementArrays(a);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { -5, 3, -12, 5, 1, 9 }, 2)]
        [TestCase(new int[] { -24, 3, 1, 25, -11, 9 }, 0)]
        [TestCase(new int[] { 1, 2, 3, 5, 1, -19 }, 5)]
        public void GetIndexMinElementArrays(int[] a, int expected)
        {
            int actual = Arrays.GetIndexMinElementArrays(a);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { -5, 3, -12, 5, 1, 9 }, 17)]
        [TestCase(new int[] { -24, 3, 1, 25, -11, 9 }, 37)]
        [TestCase(new int[] { 1, 2, 3, 5, 1, -19 }, -12)]
        public void GetAmountElementOddArray(int[] a, int expected)
        {
            int actual = Arrays.GetAmountElementOddArray(a);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { -5, 3, -12, 5, 1, 9 }, new int[] { 9, 1, 5, -12, 3, -5 })]
        [TestCase(new int[] { -24, 3, 1, 25, -11, 9 }, new int[] { 9, -11, 25, 1, 3, -24 })]
        [TestCase(new int[] { 1, 2, 3, 5, 1, -19 }, new int[] { -19, 1, 5, 3, 2, 1 })]
        public void GetReversArray(int[] a, int[] expected)
        {
            int[] actual = Arrays.GetReversArray(a);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { -5, 3, -12, 5, 1, 9 }, 5)]
        [TestCase(new int[] { -24, 3, 1, 25, -11, 9 }, 5)]
        [TestCase(new int[] { 1, 2, 3, 5, 1, -19, 1 }, 6)]
        public void GetCountOddElementArray(int[] a, int expected)
        {
            int actual = Arrays.GetCountOddElementArray(a);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { -5, 3, -12, 5, 1, 9 }, new int[] { 5, 1, 9, -5, 3, -12 })]
        [TestCase(new int[] { -24, 3, 1, 25, -11, 9 }, new int[] { 25, -11, 9, -24, 3, 1 })]
        [TestCase(new int[] { 1, 2, 3, 5, 1, -19, 1 }, new int[] { 1, -19, 1, 5, 1, 2, 3 })]
        public void GetShifterArray(int[] a, int[] expected)
        {
            int[] actual = Arrays.GetShifterArray(a);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { -5, 3, -12, 5, 1, 9 }, new int[] { -12, -5, 1, 3, 5, 9 })]
        [TestCase(new int[] { -24, 3, 1, 25, -11, 9 }, new int[] { -24, -11, 1, 3, 9, 25 })]
        [TestCase(new int[] { 1, 2, 3, 5, 1, -19, 1 }, new int[] { -19, 1, 1, 1, 2, 3, 5 })]
        public void GetBubbleSort(int[] a, int[] expected)
        {
            int[] actual = Arrays.GetBubbleSort(a);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { -5, 3, -12, 5, 1, 9 }, new int[] { -12, -5, 1, 3, 5, 9 })]
        [TestCase(new int[] { -24, 3, 1, 25, -11, 9 }, new int[] { -24, -11, 1, 3, 9, 25 })]
        [TestCase(new int[] { 1, 2, 3, 5, 1, -19, 1 }, new int[] { -19, 1, 1, 1, 2, 3, 5 })]
        public void GetInsertSort(int[] a, int[] expected)
        {
            int[] actual = Arrays.GetInsertSort(a);
            Assert.AreEqual(expected, actual);
        }
    }
}