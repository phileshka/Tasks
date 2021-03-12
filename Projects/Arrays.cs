using System;
using System.Collections.Generic;
using System.Text;

namespace Projects
{
     public static class Arrays
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
            return arr[GetIndexMaxValueFromArray(arr)];
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
            for (int i = 0; i < arr.Length / 2; i++)
            {
                Variables.Swap(ref arr[i], ref arr[arr.Length-1-i]);
            }

            return arr;
        }

        public static int CountTheNumberOfOddElementsInArray(int[] arr)
        {
            int odd = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 1)
                {
                    odd++;
                }
            }

            return odd;
        }

        public static int[] ReverseFirstHalfOfArrayWithSecond(int[] arr)
        {
            const int arraylength = 10;
            var slide = arraylength / 2 + arraylength % 2;

            for (int i = 0; i < arraylength; ++i)
            {
                Variables.Swap(ref arr[i], ref arr[i + slide]);
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
                Variables.Swap(ref arr[i], ref arr[min]);
            }

            return arr;
        }

        public static int[] SortArrayFromBiggestToSmallest(int[] arr)
        {
            for (int i = 1; i < arr.Length; i++)
            {
                int j = i;

                while (j > 0 && arr[j] > arr[j - 1])
                {
                    Variables.Swap(ref arr[j], ref arr[j - 1]);
                    j--;
                }
            }

            return arr;
        }
    }
}
