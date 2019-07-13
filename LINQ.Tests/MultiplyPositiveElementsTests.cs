using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using Students_Groups_LINQ_;

namespace LINQ.Tests
{
    [TestFixture]
    public class MultiplyPositiveElementsTests
    {
        [TestCase(new int[]{1,2,3,4,5}, 120)]
        [TestCase(new int[] { 1, 2, 3, 2, 1 }, 12)]
        [TestCase(new int[] { 1, 1,1,1,1 }, 1)]
        public void TestArrayWithOnlyPositiveElements(int[] a, double expected)
        {
            double actual;
            actual = Students_Groups_LINQ_.Program.MultiplyPositiveElements(a);
            Assert.AreEqual(actual, expected);
        }

        [TestCase(new int[] { 1, 2, 3, 4, 0 }, 24)]
        [TestCase(new int[] { 1, 2, 0, 2, 1 }, 4)]
        [TestCase(new int[] { 1, 1, 0, 1, 1 }, 1)]
        public void TestArrayWithZero(int[] a, double expected)
        {
            double actual;
            actual = Students_Groups_LINQ_.Program.MultiplyPositiveElements(a);
            Assert.AreEqual(actual, expected);
        }

        [TestCase(new int[] { 1, 2, 3, -4, 0 }, 6)]
        [TestCase(new int[] { -1, 2, 0, -2, 1 }, 2)]
        [TestCase(new int[] { -1, -1, 0, -1, -1 }, 0)]
        public void TestArrayWithNegativeElements(int[] a, double expected)
        {
            double actual;
            actual = Students_Groups_LINQ_.Program.MultiplyPositiveElements(a);
            Assert.AreEqual(actual, expected);
        }
    }
}
