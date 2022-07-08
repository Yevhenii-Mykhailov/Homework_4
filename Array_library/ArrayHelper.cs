using System;

namespace Array_library
{
    public class ArrayHelper
    {
        public static int GetMinElement(int[] array)
        {
            return array[GetMinIndexOfElement(array)];
        }

        public static int GetMaxElement(int[] array)
        {
            return array[GetMaxIndexOfElement(array)];
        }

        public static int GetMinIndexOfElement(int[] array)
        {
            if (array == null || array.Length == 0)
            {
                throw new ArgumentException("Array null or empty");
            }

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

        public static int GetMaxIndexOfElement(int[] array)
        {
            if (array == null || array.Length == 0)
            {
                throw new ArgumentException("Array null or empty");
            }

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

        public static int GetSumOfOddIndexElements(int[] array)
        {
            if (array == null)
            {
                throw new NullReferenceException();
            }

            int sum = default;

            for (int i = 1; i < array.Length; i +=2)
            {
                sum += array[i];
            }

            return sum;
        }

        public static int[] ReverseArray(int[] array)
        {
            if (array == null)
            {
                throw new NullReferenceException();
            }

            int lastIndex = array.Length - 1;
            int halfSize = array.Length / 2;
            for (int i = 0; i < halfSize; i++)
            {
                Swap(ref array[i], ref array[lastIndex--]);
            }

            return array;
        }
        
        public static int GetCountOfOdds(int[] array)
        {
            if (array == null)
            {
                throw new NullReferenceException();
            }

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
        
        public static int[] SwapHalfOfArray(int[] array)
        {
            if (array == null)
            {
                throw new NullReferenceException();
            }

            int halfSize = array.Length / 2;
            int rightSideStartPosition = halfSize + array.Length % 2;
            for (int i = 0; i < halfSize; i++)
            {
                Swap(ref array[i], ref array[rightSideStartPosition + i]);
            }

            return array;
        }

        public static int[] InsertionSorting(int[] array)
        {
            if (array == null)
            {
                throw new NullReferenceException();
            }

            for (int i = 1; i < array.Length; i++)
            {
                int value = array[i];
                for (int j = i - 1; j >= 0;)
                {
                    if (value < array[j])
                    {
                        array[j + 1] = array[j];
                        j--;
                        array[j + 1] = value;
                    }
                    else
                    {
                        break;
                    }
                }
            }

            return array;
        }

        public static int[] SelectionDescendingSorting(int[] array)
        {
            if (array == null)
            {
                throw new NullReferenceException();
            }

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

                Swap(ref array[smalestIndex], ref array[i]);
            }

            return array;
        }

        private static void Swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }
    }
}

