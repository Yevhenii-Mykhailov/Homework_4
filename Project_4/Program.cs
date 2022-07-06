using System;

namespace Project_4
{
    class Program
    {

        static int FindMinElement(int[] array)
        {
            int min = default;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < array[min])
                {
                    min = i;
                }
            }
            return array[min];
        }

        static int FindMaxElement(int[] array)
        {
            int max = default;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > array[max])
                {
                    max = i;
                }
            }
            return array[max];
        }

        static int FindMinIndexOfElement(int[] array)
        {
            int min = default;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < array[min])
                {
                    min = i;
                }
            }
            return min;
        }

        static int FindMaxIndexOfElement(int[] array)
        {
            int max = default;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > array[max])
                {
                    max = i;    
                }
            }
            return max;
        }

        static int GetSumOfOddIndexElements(int[] array)
        {
            int sum = default;
            for (int i = 0; i < array.Length; i++)
            {
                if (i % 2 != 0)
                {
                    sum += array[i];
                }
            }
            return sum;
        }

        static int[] ReverseArray(int[] array)
        {
            int lastIndex = array.Length - 1;
            for (int i = 0; i < array.Length / 2; i++)
            {
                Swap(ref array[i], ref array[lastIndex]);
                lastIndex--;
            }

            return array;
        }

        static int GetCountOfOdds(int[] array)
        {
            int count = default;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 != 0)
                {
                    ++count;
                }
            }
            return count;
        }

        static int[] SwapHalfOfArray (int[] array)
        {
            int halfOfArray = array.Length / 2;
            int[] resultArray;
            int[] firsHalfArray = GetFirstHalfArray(array, halfOfArray);
            int[] secondHalfArray = GetSecondHalfArray(array, halfOfArray);

            if (array.Length % 2 == 0)
            {
                resultArray = new int[array.Length];
                for (int i = 0; i < halfOfArray; i++)
                {
                    resultArray[i] = secondHalfArray[i];
                }

                for (int i = 0; i < halfOfArray; i++)
                {
                    resultArray[halfOfArray + i] = firsHalfArray[i];
                }
            }
            else
            {
                int[] secondHalfArrayOdd = GetSecondHalfOfArrayOdd(array, halfOfArray);
                resultArray = new int[array.Length];
                for (int i = 0; i < halfOfArray + 1; i++)
                {
                    resultArray[i] = secondHalfArrayOdd[i];
                }

                for (int i = 1; i <= halfOfArray; i++)
                {
                    resultArray[halfOfArray + i] = firsHalfArray[i - 1];
                }
            }

            return resultArray;
        }

        static void InsertionSorting(int[] array)
        {
            for (int i = 1; i < array.Length; i++)
            {
                int value = array[i];
                int flag = 0;
                for (int j = i - 1; j >= 0 && flag != 1;)
                {
                    if (value < array[j])
                    {
                        array[j + 1] = array[j];
                        j--;
                        array[j + 1] = value;
                    }
                    else flag = 1;
                }
            }
        }

        static void SelectionDescendingSorting(int[] array)
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                int smalestIndex = i;
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[j] > array[smalestIndex])
                    {
                        smalestIndex = j;
                    }
                }
                int temp = array[smalestIndex];
                array[smalestIndex] = array[i];
                array[i] = temp;
            }

        }

        static void Main(string[] args)
        {

        }

        private static void Swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }

        private static int[] GetSecondHalfArray(int[] array, int halfOfArray)
        {
            int[] secondHalfArray = new int[halfOfArray];
            for (int i = 0; i < halfOfArray; i++)
            {
                secondHalfArray[i] = array[halfOfArray + i];
            }

            return secondHalfArray;
        }

        private static int[] GetFirstHalfArray(int[] array, int halfOfArray)
        {
            int[] firsHalfArray = new int[halfOfArray];
            for (int i = 0; i < halfOfArray; i++)
            {
                firsHalfArray[i] = array[i];
            }

            return firsHalfArray;
        }

        private static int[] GetSecondHalfOfArrayOdd(int[] array, int halfOfArray)
        {
            int[] secondHalfArrayOdd = new int[halfOfArray + 1];
            for (int i = 0; i < halfOfArray + 1; i++)
            {
                secondHalfArrayOdd[i] = array[array.Length - 1 - i];
            }

            return secondHalfArrayOdd;
        }
    }
}

