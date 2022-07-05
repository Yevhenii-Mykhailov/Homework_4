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

            int[] newArray = new int [array.Length];
            for (int i = 0, j = 0; i < array.Length; i++)
            {
                if (array[i] > 0)
                {
                    newArray[j++] = array[i];
                }
            }

            return newArray;
        }

        //7. Count the number of odd array elements

        //8. Swap the first and second half of the array, for example, for an array of 1 2 3 4,
        //the result is 3 4 1 2, or for 1 2 3 4 5 -> 4 5 3 1 2.

        //9. Sort the array in ascending order in one of the ways: bubble(Bubble), selection(Select) or inserts(Insert))

        //10. Sort the array in descending order in one of the ways(different from the method in the 9th task):
        //bubble(Bubble), selection(Select) or inserts(Insert))
        static void Main(string[] args)
        {
            int size = 10;
            Random random = new Random();
            int[] array = new int[size];
            for (int i = 0; i < size; i++)
            {
                array[i] = random.Next(-50, 50);
            }

            for (int i = 0; i < size; i++)
            {
                Console.Write(array[i] + " ");
            }

            Console.WriteLine();

            Console.WriteLine(ReverseArray(array));

        }

        private static void Swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }

        private static void PrintArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }

            Console.WriteLine();
        }
    }
}

