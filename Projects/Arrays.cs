using System;
using System.Collections.Generic;
using System.Text;

namespace Projects
{
    class Arrays
    {
        public static int[] GenerateAndFillArray()
        {
            const int arraylength = 10;
            int[] arr = new int[arraylength];
            Random random = new Random();
            const int numbers = 100;

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = random.Next(numbers);
            }

            return arr;
        }

        public static int GetMinValueFromArray(int[] arr)
        {
            return arr[GetIndexMinValueFromArray(arr)];
        }

        public static int GetMaxValueFromArray(int[] arr)
        {
            int max = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > arr[max])
                {
                    max = i;
                }
            }

            return arr[max];
        }

        public static int GetIndexMinValueFromArray(int[] arr)
        {
            int min = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < arr[min])
                {
                    min = i;
                }
            }

            return min;
        }

        public static int GetIndexMaxValueFromArray(int[] arr)
        {
            int max = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > arr[max])
                {
                    max = i;
                }
            }

            return max;
        }

        public static int GetSumArrayElementsWithOddIndex(int[] arr)
        {
            int sum = 0;
            for (int i = 1; i < arr.Length; i += 2)
            {
                sum += arr[i];
            }

            return sum;
        }

        public static int[] GetReverseArray(int[] arr)
        {
            int temp = 0;
            for (int i = 0; i < arr.Length / 2; i++)
            {
                temp = arr[i];
                arr[i] = arr[arr.Length - 1 - i];
                arr[arr.Length - 1 - i] = temp;
            }
            
            for (int i = 0; i < arr.Length; i++)
            {

            }

            return arr;
        }

        public static int CountTheNumberOfOddElementsInArray(int[] arr)
        {
            int odd = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 != 0)
                {
                    odd++;
                }
            }

            return odd;
        }

        public static int[] ReverseFirstHalfOfArrayWithSecond(int[] arr)
        {
            const int arraylength = 10;
            int temp = 0;
            for (int i = 0; i < arraylength; ++i)
            {
                temp = arr[i];
                arr[i] = arr[(i + arraylength) / (2 + arraylength % 2)];
                arr[(i + arraylength) / (2 + arraylength % 2)] = temp;
            }

            for (int i = 0; i < arraylength; ++i)
            {
                
            }

            return arr;
        }

        public static int[] SortArrayFromSmallestToBiggest(int[] arr)
        {
            for (int i = 0; i < arr.Length - 1; i++)
            {
                int min = i;
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[j] < arr[min])
                    {
                        min = j;
                    }
                }
                int tmp = arr[i];
                arr[i] = arr[min];
                arr[min] = tmp;
            }

            Console.WriteLine();

            for (int i = 0; i < arr.Length; i++)
            {
                
            }

            return arr;
        }

        public static int[] SortArrayFromBiggestToSmallest(int[] arr)
        {
            int tmp;
            for (int i = 1; i < arr.Length; i++)
            {
                int j = i;
                while (j > 0 && arr[j] > arr[j - 1])
                {
                    tmp = arr[j];
                    arr[j] = arr[j - 1];
                    arr[j - 1] = tmp;
                    j--;
                }
            }

            for (int i = 0; i < arr.Length; i++)
            {
                
            }

            return arr;
        }
    }
}
