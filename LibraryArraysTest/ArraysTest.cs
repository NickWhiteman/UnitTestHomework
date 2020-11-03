using System;
using NUnit.Framework;
using LibraryVariables;

namespace LibrararyArrays.Tests
{
    public class TwoDimensionalArrayTest
    {
        private static int[,] TDArrayMock;
        private static int[,] expectedMock;

        void SetMock(int n)
        {
            switch (n)
            {
                case 1:
                    TDArrayMock = new int[,]
                    {
                        { 2, 4, 6 },
                        { 0, 3, 7 },
                        { 1, 9, 8 }
                    };
                    break;
                case 2:
                    TDArrayMock = new int[,]
                    {
                        { 12, 4, 7 },
                        { 11, 0, 23 },
                        { 19, 34, -4 }
                    };

                    break;
                case 3:
                    TDArrayMock = new int[,]
                    {
                        { 22, 1, 6 },
                        { 0, 3, 17 },
                        { 11, 9, 18 }
                    };
                    break;
                default:
                    throw new Exception();
            }
        }

        void SetExpectedMock(int e)
        {
            switch (e)
            {
                case 1:
                    expectedMock = new int[,]
                    {
                        { 2, 0, 1 },
                        { 4, 3, 9 },
                        { 6, 7, 8 }
                    };
                    break;
                case 2:
                    expectedMock = new int[,]
                    {
                        { 12, 11, 19 },
                        { 4, 0, 34 },
                        { 7, 23, -4 }
                    };
                    break;
                case 3:
                    expectedMock = new int[,]
                    {
                        { 22, 0, 11 },
                        { 1, 3, 9 },
                        { 6, 17, 18 }
                    };
                    break;
                default:
                    throw new Exception();
            }
        }


        [TestCase(1, 1)]
        [TestCase(2, 2)]
        [TestCase(3, 3)]
        public void GetTransponingTwoDimansionalArrays(int n, int e)
        {
            SetMock(n);
            SetExpectedMock(e);
            int[,] actual = Arrays.GetTransponingTwoDimansionalArrays(TDArrayMock);
            int[,] expected = expectedMock;

            Assert.AreEqual(expected, actual);
        }

        [TestCase(1, 0)]
        [TestCase(2, -4)]
        [TestCase(3, 0)]
        public void GetMinElemTwoDimensionalArrays(int n, int expected)
        {
            SetMock(n);
            int actual = Arrays.GetMinElemTwoDimensionalArrays(TDArrayMock);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(1, 9)]
        [TestCase(2, 34)]
        [TestCase(3, 22)]
        public void GetMaxElemTwoDimensionalArrays(int n, int expected)
        {
            SetMock(n);
            int actual = Arrays.GetMaxElemTwoDimensionalArrays(TDArrayMock);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(1, new int[] { 1, 0 })]
        [TestCase(2, new int[] { 2, 2 })]
        [TestCase(3, new int[] { 1, 0 })]
        public void GetIndexMinElemTwoDimensionalArrays(int n, int[] expected)
        {
            SetMock(n);
            int[] actual = Arrays.GetIndexMinElemTwoDimensionalArrays(TDArrayMock);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(1, new int[] { 2, 1 })]
        [TestCase(2, new int[] { 2, 1 })]
        [TestCase(3, new int[] { 0, 0 })]
        public void GetIndexMaxElemTwoDimensionalArrays(int n, int[] expected)
        {
            SetMock(n);
            int[] actual = Arrays.GetIndexMaxElemTwoDimensionalArrays(TDArrayMock);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(1, 1)]
        [TestCase(2, 3)]
        [TestCase(3, 3)]
        public void GetCountElemGreaterNeighbors(int n, int expected)
        {
            SetMock(n);
            int actual = Arrays.GetCountElemGreaterNeighbors(TDArrayMock);
            Assert.AreEqual(expected, actual);
        }

    }
}
