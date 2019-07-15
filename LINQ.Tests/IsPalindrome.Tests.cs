using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;

namespace LINQ.Tests
{
    [TestFixture]
    class IsPalindrome
    {
        [TestCase("Де помити мопед")]
        [TestCase("Я несу гусеня")]
        [TestCase("Step on no pets")]
        [TestCase("Able was I ere I saw Elba")]
        public static void CheckIsPalindrome(string CheckinString)
        {
            bool actual;
            actual = LINQ.Extensions.IsPalindrome(CheckinString);
            Assert.IsTrue(actual);
        }

        [TestCase("Де помити велосипед")]
        [TestCase("Я несу каченя")]
        [TestCase("Step on no animals")]
        [TestCase("I saw Elba")]
        public static void CheckIsNotPalindrome(string CheckinString)
        {
            bool actual;
            actual = LINQ.Extensions.IsPalindrome(CheckinString);
            Assert.IsFalse(actual);
        }
    }
}
