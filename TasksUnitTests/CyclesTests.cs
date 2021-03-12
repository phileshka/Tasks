using NUnit.Framework;
using Projects;
using System;

namespace CyclesTests
{
    class CyclesTests
    {
        [TestCase(2, 3, 9)]
        [TestCase(1, 4, 4)]
        [TestCase(0, 5, 1)]
        public void GetDegreeOfTheNumber_WhenValuesAreValid_ShouldReturnValueMultiplyOnHimself(int a, int b, int expected)
        {
            int actual = Cycles.GetDegreeOfTheNumber(a, b);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(333, new int[] { 333, 666, 999 })]
        public void GetAllNumbersThatDivisibleOnAFromAToThousand_WhenNumbersValidDivideOnThousand_ShouldReturnArray(int a, int[] expected)
        {
            int[] arr = Cycles.GetAllNumbersThatDivisibleOnAFromAToThousand(a);

            Assert.AreEqual(expected, arr);
        }

        [Test]
        public void GetAllNumbersThatDivisibleOnAFromAToThousand_WhenValuesAreNotValid_ShouldThrowException()
        {
            Assert.Throws<IndexOutOfRangeException>(() => { Cycles.GetAllNumbersThatDivisibleOnAFromAToThousand(1200); });
        }

        [TestCase(9, 3)]
        [TestCase(0, 0)]
        [TestCase(25, 5)]
        public void GetAllPositiveNumbersWhoseSquareLessThanA_WhenSquareLessThanA_ShouldReturnValue(int a, int expected)
        {
            int actual = Cycles.GetAllPositiveNumbersWhoseSquareLessThanA(a);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(24, 12)]
        [TestCase(99, 33)]
        [TestCase(25, 5)]
        public void GetTheBiggestDivisior_WhenValueIsValid_ShouldReturnValue(int a, int expected)
        {
            int actual = Cycles.GetTheBiggestDivisior(a);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(15, 6, 21)]
        public void GetSumOfAllNumbersThatDivideOnSeven_WhenWithoutResidue_ShouldRerunSum(int a, int b, int expected)
        {
            int actual = Cycles.GetSumOfAllNumbersThatDivideOnSevenWithoutResidue(a, b);

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void GetSumOfAllNumbersThatDivideOnSeven_WhenWithResidue_ShouldRerunException()
        {
            Assert.Throws<ArgumentException>(() => { Cycles.GetSumOfAllNumbersThatDivideOnSevenWithoutResidue(8, 10); });
        }

        [TestCase(3,2)]
        [TestCase(7,13)]
        [TestCase(2,1)]
        public void GetTheNumberOfFibonacciLine_WhenFibonacciIsValid_ShouldReturnNumber(int n,int expected)
        {
            int actual = Cycles.GetTheNumberOfFibonacciLine(n);

            Assert.AreEqual(expected, actual);
        }

        //[Test]
        //public void GetTheNumberOfFibonacciLine_WhenFibonacciIsNotValid_ShouldReturnException()
        //{
        //    Assert.Throws<IndexOutOfRangeException>(() => Cycles.GetTheNumberOfFibonacciLine(49));
        //}

       [TestCase(22,11,11)]
       [TestCase(100,70,10)]
       [TestCase(12,7,1)]
        public void GetTheirGreatestCommonDivisorUsingEuclidAlgorithm_WhenValidAAndB_ShourdReturnDivisior(int a,int b,int expected)
        {
            int actual = Cycles.GetTheirGreatestCommonDivisorUsingEuclidAlgorithm(a, b);

            Assert.AreEqual(expected, actual);
        }

        //public void GetBinarySearch_WhenValidValue_ShouldReturnValue(int n, int expected)
        //{
        //    int actual = Cycles.GetBinarySearch(n);

        //    Assert.AreEqual(expected, actual);
        //}

        [TestCase(112456,3)]
        [TestCase(111111,6)]
        [TestCase(222222,0)]
        public void CountNumberOfOddDigitsOfThisNumber_WhenValuesAreValid_ShouldReturnNumber(int number,int expected)
        {
            int actual = Cycles.CountNumberOfOddDigitsOfThisNumber(number);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(123456,"654321")]
        [TestCase(14567,"76541")]
        [TestCase(21111,"11112")]
        public void GetNumberMirror_WhenValidValues_ShouldReversedValues(int number,string expected)
        {
            string actual = Cycles.GetNumberMirror(number);

            Assert.AreEqual(expected,actual);
        }

        [TestCase("1234","5678","no")]
        [TestCase("1234","5648","yes")]
        [TestCase("0000","0000","yes")]
        public void GetTheSameDigitsInDiffNumbers_WhenValuesAreValid_ShouldReturnAnswer(string a, string b,string expected)
        {
            string actual = Cycles.GetTheSameDigitsInDiffNumbers(a, b);

            Assert.AreEqual(expected, actual);
        }
    }
}
