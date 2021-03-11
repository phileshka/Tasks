using System;
using System.Collections.Generic;
using System.Text;

namespace Projects
{
    class Cicles
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

        public static int[] GetAllNumbersThatDivideBy1000(int a)
        {
            const int range = 1000;
            int[] array = new int[range];
            int j = 0;

            for (int i = a; i < array.Length; i += a)
            {
                if (i % a == 0)
                {
                    array[j++] = i;
                }
                else
                {
                    throw new ArgumentException();
                }
            }

            return array;
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
                throw new ArgumentException();
            }

            else
            {
                int a = 1;
                int b = 1;
                int sum = 0;

                int j = 2;
                while (j <= n)
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
                    a -= b;
                else
                    b -= a;
            }
            return a;
        }

        //public static int 8

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

        public static string  GetNumberMirror(int number)
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

        //public static 11

        public static string GetTheSameDigitsInDiffNumbers(string a,string b)
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
                return("no");

            }
            else
            {
                return("yes");
            }
        }
    }
}

