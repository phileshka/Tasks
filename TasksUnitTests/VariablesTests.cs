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
        public void GetDecision_WhenValidAB_ShouldCalculateDecision(
            int a, int b, int expected)
        {
            int actual = Variables.GetDecision(a, b);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(0, 0)]
        [TestCase(-3, -3)]
        [TestCase(4, 4)]
        public void GetDecision_WhenBMinusAEqualZero_ShouldThrowException()
        {
            Assert.Throws<Exception>(() =>
            {
                Variables.GetDecision(5, 5);
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

        [TestCase]
        public void GetDivision(double a, double b,
            double expectedDivision, int expectedDevisionReminer)
        {
            (double division, double reminder) = Variables.GetDivision(a, b);

            Assert.AreEqual(expectedDivision, division);
            Assert.AreEqual(expectedDevisionReminer, reminder);
        }
    }
}