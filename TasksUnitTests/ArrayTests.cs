using NUnit.Framework;
using Projects;
using System;

namespace TasksUnitTests
{
    class ArrayTests
    {

        [TestCase(new int[] { 4, 7, 6, 8 }, 0)]
        [TestCase(new int[] { 3, 2, 1, 5 }, 2)]
        [TestCase(new int[] { 1, -4, 0, 7 }, 1)]
        public void GetIndexMinValueFromArray_WhenArrayIsValid_ShouldReturnIndexOfMinElement(int[] arr, int expected)
        {
            int actual = Arrays.GetIndexMinValueFromArray(arr);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 4, 7, 6, 8 }, 4)]
        [TestCase(new int[] { 3, 2, 1, 5 }, 1)]
        [TestCase(new int[] { 1, -4, 0, 7 }, -4)]
        public void GetMinValueFromArray_WhenArrayIsValid_ShouldReturnMinValue(int[] arr, int expected)
        {
            int actual = Arrays.GetMinValueFromArray(arr);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 4, 9, 6, 8 }, 1)]
        [TestCase(new int[] { 3, 2, 1, 5 }, 3)]
        [TestCase(new int[] { 1, -4, 0, 7 }, 3)]
        public void GetIndexMaxValueFromArray_WhenArrayIsValid_ShouldReturnIdexOfMaxElement(int[] arr, int expected)
        {
            int actual = Arrays.GetIndexMaxValueFromArray(arr);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 4, 9, 6, 8 }, 9)]
        [TestCase(new int[] { 3, 2, 1, 5 }, 5)]
        [TestCase(new int[] { 1, -4, 0, 7 }, 7)]
        public void GetMaxValueFromArray_WhenArrayIsValid_ShouldReturnMaxValue(int[] arr, int expected)
        {
            int actual = Arrays.GetMaxValueFromArray(arr);

            Assert.AreEqual(expected, actual);
        }

       [TestCase(new int[] {1,2,3,4,5,6},12)]
       [TestCase(new int[] {1,0,3,0,5,0},0)]
       [TestCase(new int[] {1,-2,3,0,5,-1},-3)]
        public void GetSumArrayElementsWithOddIndex_WhenValuesAreValid_ShouldReturnSum(int[] arr,int expected)
        {
            int actual = Arrays.GetSumArrayElementsWithOddIndex(arr);

            Assert.AreEqual(expected, actual);
        }
        
        [TestCase(new int[] { 3, 2, 1 }, new int[] { 1, 2, 3 })]
        [TestCase(new int[] { 2, 2, 8 }, new int[] { 8, 2, 2 })]
        [TestCase(new int[] { 3, 0, 0 }, new int[] { 0, 0, 3 })]
        public void GetReverseArray_WhenArrayIsValid_ShouldReverseArray(int[] arr, int[] expected)
        {
            int[] actual = Arrays.GetReverseArray(arr);

            Assert.AreEqual(expected, arr);
        }

        [TestCase(new int[] { 2, 5, 4, 3, 1 }, 3)]
        [TestCase(new int[] { 2, 2, 2, 2, 2 }, 0)]
        [TestCase(new int[] { 2, 2, 4, 6, 1 }, 1)]
        public void CountTheNumberOfOddElementsInArray_WhenNumbersAreValid_ShouldReturnValue(int[] arr, int expected)
        {
            int actual = Arrays.CountTheNumberOfOddElementsInArray(arr);

            Assert.AreEqual(expected, actual);
        }

        //[TestCase(new int[] { 1, 2, 3 }, new int[] { 3, 2, 1 })]
        //public void ReverseFirstHalfOfArrayWithSecond_WhenArraysAreValid_ShouldReturnFirstHalfOfArrayWithSecond(int[] arr, int[] expected)
        //{
        //    int[] actual = Arrays.ReverseFirstHalfOfArrayWithSecond(arr);

        //    Assert.AreEqual(expected, actual);
        //}

        [TestCase(new int[] { 3, 7, 2, 4 }, new int[] { 2, 3, 4, 7 })]
        [TestCase(new int[] { 3, -2, 0, 4 }, new int[] { -2, 0, 3, 4 })]
        [TestCase(new int[] { 33, 7, 2, 8 }, new int[] { 2, 7, 8, 33 })]
        public void SortArrayFromSmallestToBiggest_WhenArrayIsValid_ShouldReturnSortedArrayFromSmallestToBiggest(int[] arr, int[] expected)
        {
            int[] actual = Arrays.SortArrayFromSmallestToBiggest(arr);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 3, 7, 2, 4 }, new int[] { 7, 4, 3, 2 })]
        [TestCase(new int[] { 3, -2, 0, 4 }, new int[] { 4, 3, 0, -2 })]
        [TestCase(new int[] { 33, 7, 2, 8 }, new int[] { 33, 8, 7, 2 })]
        public void SortArrayFromBiggestToSmallest_WhenArrayIsValid_ShouldReturnSortedFrimBiggestToSmallest(int[] arr, int[] expected)
        {
            int[] actual = Arrays.SortArrayFromBiggestToSmallest(arr);

            Assert.AreEqual(expected, actual);
        }
    }
}
