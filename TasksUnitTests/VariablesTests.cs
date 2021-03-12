using NUnit.Framework;
using Projects;
using System;

namespace TasksUnitTests
{
    public class VariablesTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [TestCase(1, 2, 9)]
        [TestCase(0, 3, 3)]
        [TestCase(1, -3, -3)]
        public void GetDecision_WhenValidValues_ShouldCalculateDecision(
            int a, int b, int expected)
        {
            int actual = Variables.GetDecision(a, b);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(0, 0)]
        [TestCase(-3, -3)]
        [TestCase(4, 4)]
        public void GetDecision_WhenBMinusAEqualZero_ShouldThrowException(int a, int b)
        {
            Assert.Throws<ArgumentException>(() =>
            {
                Variables.GetDecision(a, b);
            });
        }

        [TestCase(1, 2, 2, 1)]
        [TestCase(0, 5, 5, 0)]
        [TestCase(-5, 5, 5, -5)]
        [TestCase(0, -1, -1, 0)]
        public void Swap_WhenABPassed_ShouldSwapValues(
            int a, int b, int expectedA, int expectedB)
        {
            Variables.Swap(ref a, ref b);

            Assert.AreEqual(expectedA, a);
            Assert.AreEqual(expectedB, b);
        }

        [TestCase(7, 3, 2, 1)]
        [TestCase(8, 4, 2, 0)]
        [TestCase(9, 5, 1, 4)]
        public void GetDivision_WhenValidAB_ShouldCalculateDeevisionAndDevisionReminder(int a, int b,
            int expectedDivision, int expectedDevisionReminer)
        {
            (int division, int reminder) = Variables.GetDivision(a, b);

            Assert.AreEqual(expectedDivision, division);
            Assert.AreEqual(expectedDevisionReminer, reminder);
        }

        [TestCase(0, 0)]
        [TestCase(-3, 0)]
        [TestCase(4, 0)]
        public void GetDivision_WhenBEqualsZero_ShouldThrowException(int a, int b)
        {
            Assert.Throws<ArgumentException>(() => Variables.GetDivision(5, 0));
        }

        [TestCase(1, 2, 4, 2)]
        [TestCase(1, 2, 2, 0)]
        [TestCase(2, 2, -3, -2.5)]
        public void GetEquationResult_WhenValidABC_ShouldClculateExpectedX(double a, double b, double c, double expectedX)
        {
            double actual = Variables.GetEquationResult(a, b, c);

            Assert.AreEqual(expectedX, actual);
        }

        [Test]
        public void GetEquationResult_WhenAEqualsZero_ShouldThrowException()
        {
            Assert.Throws<ArgumentException>(() => Variables.GetEquationResult(0, 2, 3));
        }

        [TestCase(1, 2, -1, 1, 2, -3)]
        [TestCase(0, -2, 2, 1, 0.5, 2)]
        [TestCase(3, 1, 3, 1, 1, 0)]
        public void GetEquationOfLine_WhenValidValues_ShouldIndentifyQuarter(double x1, double x2, double y1, double y2, double expectedA, double expectedB)
        {
            (double actualA, double actualB) = Variables.GetEquationOfLine(x1, x2, y1, y2);

            Assert.AreEqual(expectedA, actualA);
            Assert.AreEqual(expectedB, actualB);
        }

        [Test]
        public void GetEquationOfLine_WhenDifferenceOfXEqualsZero_ShouldThrowException()
        {
            Assert.Throws<ArgumentException>(() => Variables.GetEquationOfLine(0, 0, 3, 2));
        }
    }
}