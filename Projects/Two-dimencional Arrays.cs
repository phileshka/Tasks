using System;
using System.Collections.Generic;
using System.Text;

namespace Projects
{
    public static class TwoDimencionalArrays
    {
        public static int[,] CreateAndFillTwoDimencionalArray()
        {
            const int minrange = 1;
            const int maxrange = 100;
            const int xLength = 4;
            const int yLength = 3;
            int[,] array = new int[xLength, yLength];
            Random random = new Random();

            for (int i = 0; i < array.GetLength(0); ++i)
            {
                for (int j = 0; j < array.GetLength(1); ++j)
                {
                    array[i, j] = random.Next(minrange, maxrange);
                }
            }

            return array;
        }

        public static int[,] GetMinElementFromTwoDimencionalArray(int[,] array)
        {
            int minElement = array[0, 0];
            for (int i = 0; i < array.GetLength(0); ++i)
            {
                for (int j = 0; j < array.GetLength(1); ++j)
                {
                    if (minElement > array[i, j])
                    {
                        minElement = array[i, j];
                    }
                }
            }

            return array;
        }

        public static int[,] GetMaxElementFromTwoDimencionalArray(int[,] array)
        {
            int maxElement = array[0, 0];
            for (int i = 0; i < array.GetLength(0); ++i)
            {
                for (int j = 0; j < array.GetLength(1); ++j)
                {
                    if (maxElement < array[i, j])
                    {
                        maxElement = array[i, j];
                    }
                }
            }

            return array;
        }

        public static (int minX, int minY) GetIndexOfMinElementFromTwoDimencionalArray(int[,] array)
        {
            int minElement = array[0, 0];
            int minX = 0;
            int minY = 0;
            for (int i = 0; i < array.GetLength(0); ++i)
            {
                for (int j = 0; j < array.GetLength(1); ++j)
                {
                    if (minElement > array[i, j])
                    {
                        minElement = array[i, j];
                        minX = i;
                        minY = j;
                    }
                }
            }

            return (minX, minY);
        }

        public static (int maxX, int maxY) GetIndexOfMaxElementFromTwoDimencionalArray(int[,] array)
        {
            int maxElement = array[0, 0];
            int maxX = 0;
            int maxY = 0;
            for (int i = 0; i < array.GetLength(0); ++i)
            {
                for (int j = 0; j < array.GetLength(1); ++j)
                {
                    if (maxElement < array[i, j])
                    {
                        maxElement = array[i, j];
                        maxX = i;
                        maxY = j;
                    }
                }
            }

            return (maxX, maxY);
        }

        public static int GetNumberOfArrayElementsThatAreLargerAllTheirNeighboursAtTheSameTime(int[,] array)
        {
            int counter = 0;
            for (int i = 0; i < array.GetLength(0); i++)
            {

                for (int j = 0; j < array.GetLength(1); j++)
                {
                    var conditionsPassed = true;
                    for (int k = -1; k <= 1 && conditionsPassed; k++)
                    {
                        int NewIndexI = i - k;
                        for (int l = -1; l <= 1; l++)
                        {
                            int NewIndexJ = j - l;
                            if ((NewIndexI != i || NewIndexJ != j)
                                && NewIndexI >= 0
                                && NewIndexI < array.GetLength(0)
                                && NewIndexJ >= 0
                                && NewIndexJ < array.GetLength(1))

                            {
                                if (array[i, j] <= array[NewIndexI, NewIndexJ])
                                {
                                    conditionsPassed = false;
                                    break;
                                }
                            }
                        }
                    }

                    if (conditionsPassed)
                    {
                        ++counter;
                    }
                }
            }

            return counter;
        }

        public static int[,] ReverseArrayByMainDiagonal(int[,] array)
        {
            const int xLength = 4;
            const int yLength = 3;
            int[,] resultArr = new int[yLength, xLength];
            for (int i = 0; i < array.GetLength(0); ++i)
            {
                for (int j = 0; j < array.GetLength(1); ++j)
                {
                    resultArr[j, i] = array[i, j];
                }
            }

            for (int i = 0; i < resultArr.GetLength(0); ++i)
            {
                for (int j = 0; j < resultArr.GetLength(1); ++j)
                {
                    Console.Write(resultArr[i, j] + " ");
                }

                Console.WriteLine();
            }

            return resultArr;
        }
    }
}
