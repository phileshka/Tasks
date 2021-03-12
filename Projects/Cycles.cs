using System;
using System.Collections.Generic;
using System.Text;

namespace Projects
{
    public static class Cycles
    {
        public static int GetDegreeOfTheNumber(int a, int b)
        {
            int result = 1;
            for (int i = 0; i < a; ++i)
            {
                result *= b;
            }

            return result;
        }

        public static int[] GetAllNumbersThatDivisibleOnAFromAToThousand(int a)
        {
            if (a != 0 && a <= 1000)
            {
                int[] array = new int[1000 / a];
                int j = 0;
                for (int i = a; i <= 1000; i += a)
                {
                    array[j] = i;
                    ++j;
                }

                return array;
            }

            else
            {
                throw new IndexOutOfRangeException();
            }
        }

        public static int GetAllPositiveNumbersWhoseSquareLessThanA(int a)
        {
            int counter = 0;

            for (int i = 0; i * i < a; i++)
            {
                counter++;
            }

            return counter;
        }

        public static int GetTheBiggestDivisior(int a)
        {
            int i = a;

            while (a % --i != 0) ;

            return i;
        }

        public static int GetSumOfAllNumbersThatDivideOnSevenWithoutResidue(int a, int b)
        {
            int max = Math.Max(a, b);
            int min = Math.Min(a, b);
            int sum = 0;
            for (int i = min; i < max; i++)
            {
                if (i % 7 == 0)
                {
                    sum += i;
                }
                else
                    throw new ArgumentException();
            }

            return sum;
        }

        public static int GetTheNumberOfFibonacciLine(int n)
        {
            if (n > 48 && n < 1)
            {
                throw new IndexOutOfRangeException();
            }

            else
            {
                int a = 1;
                int b = 1;
                int sum = 0;

                int j = 1;
                
                while (++j <= n)
                {
                    sum = a + b;
                    a = b;
                    b = sum;
                    j++;
                }

                return a;
            }
        }

        public static int GetTheirGreatestCommonDivisorUsingEuclidAlgorithm(int a, int b)
        {
            while (a != b)
            {
                if (a > b)
                {
                    a -= b;
                }
                else
                {
                    b -= a;
                }
            }

            return a;
        }

        public static double GetBinarySearch(int n)
        {
            //Console.WriteLine("Введите число");
            //Console.Write("num: ");
            //int num = CheckNumber();
            int left = 0;
            int num = Math.Abs(n);
            int right = Math.Abs(n);
            int mid = 0;

            if (num == 1)
            {
                return Math.Sign(n) * num;
            }

            while (true)
            {
                mid = left + (right - left) / 2;
                int cube = mid * mid * mid;
                if (cube == num)
                {
                    return Math.Sign(n) * mid;
                }
                else if (num < cube || mid > 1290)
                {
                    right = mid;
                }
                else
                {
                    left = mid + 1;
                }

                if (left == right)
                {
                    return -1;
                }

                return mid;
            }
        }

        public static int CountNumberOfOddDigitsOfThisNumber(int number)
        {
            int odd = 0;
            while (number > 0)
            {
                if (number % 2 != 0)
                {
                    odd++;
                }
                number /= 10;
            }

            return odd;
        }

        public static string GetNumberMirror(int number)
        {
            string i = "";
            if (number != 0 && number > 0)
            {
                while (number > 0)
                {
                    i += number % 10;
                    number = number / 10;

                }

                return i;
            }
            else
                throw new ArgumentException();
        }

        //public static string GetSumOfEvenValuesMoreThanSumOddValues(int a)
        //{
        //    for (int i = 1; i < a; i++)
        //    {
        //        double temp = 0;
        //        string s = Convert.ToString(i);
        //        foreach (var symbol in s)
        //        {
        //            int tempNumber = Convert.ToInt32(Char.GetNumericValue(symbol));
        //            if (tempNumber % 2 == 0)
        //            {
        //                temp += tempNumber;
        //            }
        //            else
        //            {
        //                temp -= tempNumber;
        //            }
        //        }

        //        if (temp > 0)
        //        {
        //            return i;
        //        }

        //        return i;
        //    }
        //}

        public static string GetTheSameDigitsInDiffNumbers(string a, string b)
        {
            bool noequalnumber = true;
            for (int i = 0; i < a.Length; i++)
            {

                for (int j = 0; j < b.Length; j++)
                {

                    if (a[i] == b[j])
                    {
                        noequalnumber = false;

                    }

                }

            }
            if (noequalnumber)
            {
                return ("no");

            }
            else
            {
                return ("yes");
            }
        }
    }
}

