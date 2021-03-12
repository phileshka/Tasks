using NUnit.Framework;
using Projects;
using System;

namespace TasksUnitTests
{
    class BranchesTests
    {
        [TestCase(5, 2, 7)]
        [TestCase(2, 2, 4)]
        [TestCase(0, 7, -7)]
        public void CalculateValue_DefineFunctionBetweenDigits_ShouldCalculate(int a, int b,
            int expected)
        {
            int actual = Branches.CalculateValue(a, b);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(1, 1, 1)]
        [TestCase(1, -1, 2)]
        [TestCase(-1, -1, 3)]
        [TestCase(-1, 2, 4)]
        [TestCase(0, 0, 0)]
        public void DefineQuarter_WhenXAndYValid_ShouldWriteQuarter(int x, int y, int expected)
        {
            int actual = Branches.DefineQuarter(x, y);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(3, 5, 1, new int[] { 1, 3, 5 })]
        [TestCase(7, 4, 2, new int[] { 2, 4, 7 })]
        [TestCase(4, 0, 9, new int[] { 0, 4, 9 })]
        public void GetAscansingOrder_WhenABCValid_ShouldReturnArray(int a, int b, int c, int[] expected)
        {
            int[] actual = Branches.GetAscansingOrder(a, b, c);

            Assert.AreEqual(expected, actual);
        }

        public void GetSquareEquation_WhenValidValues_ShouldRerurnRoots(double a, double b, double c,int expected)
        {

        }

        [TestCase(19, "Девятнадцать")]
        [TestCase(10, "Десять")]
        [TestCase(25, "Двадцать Пять")]
        public void GetNumber_WhenValueIsValid_ShouldReturnString(int value, string expected)
        {
            string actual = Branches.GetNumber(value);

            Assert.AreEqual(expected, actual);
        }
    }
}
