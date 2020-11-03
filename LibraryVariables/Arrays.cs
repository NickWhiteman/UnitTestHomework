using System;
namespace LibraryVariables
{
    public class Arrays
    {
        public static int GetMaxElementArrays(int[] array)
        {
            int max = array[0];

            for (int j = 0; j < array.Length; j++)
            {
                if (array[j] > max)
                {
                    max = array[j];
                }
            }

            return max;
        }

        public static int GetMinElementArrays(int[] array)
        {
            int min = array[0];

            for (int j = 1; j < array.Length; j++)
            {
                if (array[j] < min)
                {
                    min = array[j];
                }
            }

            return min;
        }

        public static int GetIndexMaxElementArrays(int[] array)
        {
            int indexMaxElem = 0;
            int max = array[0];

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > max)
                {
                    indexMaxElem = i;
                }
            }
            return indexMaxElem;
        }

        public static int GetIndexMinElementArrays(int[] array)
        {
            int min = array[0];
            int indexMinElem = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < min)
                {
                    indexMinElem = i;
                }
            }

            return indexMinElem;
        }

        public static int GetAmountElementOddArray(int[] array)
        {
            int amountOddElem = 0;

            for (int j = 0; j < array.Length; j++)
            {
                if (j % 2 != 0)
                {
                    amountOddElem += array[j];
                }
            }

            return amountOddElem;

        }

        public static int[] GetReversArray(int[] array)
        {
            int count = 0;
            int[] reversArray = new int[array.Length];

            for (int i = array.Length - 1; i >= 0; i--)
            {
                reversArray[count] = array[i];
                count++;
            }

            return reversArray;
        }

        public static int GetCountOddElementArray(int[] array)
        {
            int CountOddElementArray = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 != 0)
                {
                    CountOddElementArray++;
                }
            }
            return CountOddElementArray;
        }

        public static int[] GetShifterArray(int[] array)
        {
            for (int j = 0; j < array.Length / 2; j++)
            {
                int item = array[j];
                array[j] = array[j + (array.Length + 1) / 2];
                array[j + (array.Length + 1) / 2] = item;
            }

            return array;
        }

        public static int[] GetBubbleSort(int[] array)
        {
            int item;

            for (int i = 0; i < array.Length; i++)
            {

                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] > array[j])
                    {
                        item = array[i];
                        array[i] = array[j];
                        array[j] = item;
                    }
                }
            }
            return array;
        }

        public static int[] GetInsertSort(int[] array)
        {
            int item;

            for (int i = 0; i < array.Length; i++)
            {
                int min = i;
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[j] < array[min])
                    {
                        min = j;
                    }
                }
                item = array[min];
                array[min] = array[i];
                array[i] = item;
            }
            return array;
        }

        //Методы Двумерных массивов

        public static int GetMinElemTwoDimensionalArrays(int[,] array)
        {
            int min = array[0, 0];

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (array[i, j] < min)
                    {
                        min = array[i, j];
                    }
                }
            }
            return min;
        }

        public static int GetMaxElemTwoDimensionalArrays(int[,] array)
        {
            int max = array[0, 0];

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (array[i, j] > max)
                    {
                        max = array[i, j];
                    }
                }
            }
            return max;
        }

        public static int[] GetIndexMinElemTwoDimensionalArrays(int[,] array)
        {
            int min = array[0, 0];
            int[] minIndex = new int[2];

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (array[i, j] < min)
                    {
                        min = array[i, j];
                        minIndex[0] = i;
                        minIndex[1] = j;
                    }
                }
            }
            return minIndex;
        }

        public static int[] GetIndexMaxElemTwoDimensionalArrays(int[,] array)
        {
            int max = array[0, 0];
            int[] maxIndex = new int[2];

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (array[i, j] > max)
                    {
                        max = array[i, j];
                        maxIndex[0] = i;
                        maxIndex[1] = j;
                    }
                }
            }
            return maxIndex;
        }

        public static int[,] GetTransponingTwoDimansionalArrays(int[,] array)
        {
            int[,] transponingArray = new int[array.GetLength(1), array.GetLength(0)];

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    transponingArray[j,i] = array[i, j];
                }
            }
            return transponingArray;
        }

        public static int GetCountElemGreaterNeighbors(int[,] array)
        {
            //Решение сделано неправильно, перепешу и этот коментарий будет удален
            int countElement = 0;

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if ((i - 1 < 0) || (array[i, j] > array[i - 1, j]))
                    {
                        countElement++;
                    }
                    else if ((j - 1 < 0) || (array[i, j] > array[i, j - 1]))
                    {
                        countElement++;
                    }
                    else if ((i + 1 < 0) || (array[i, j] > array[i + 1, j]))
                    {
                        countElement++;
                    }
                    else if ((j + 1 < 0) || (array[i, j] > array[i, j + 1]))
                    {
                        countElement++;
                    }
                }
            }
            return countElement;
        }
    }
}
