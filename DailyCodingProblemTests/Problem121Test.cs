using DailyCodingProblem;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace DailyCodingProblemTests
{
    public class Problem121Test
    {
        [Test]
        public void TestIsPalindromeNaive()
        {
            Assert.IsTrue(Problem121.IsPalindromeNaive("waterrfetawx", 2));
            Assert.IsFalse(Problem121.IsPalindromeNaive("waterrfetawx", 1));
            Assert.IsTrue(Problem121.IsPalindromeNaive("", 3));
            Assert.IsTrue(Problem121.IsPalindromeNaive(null, 0));
        }

        [Test]
        public void IsPalindromeDP()
        {
            Assert.IsTrue(Problem121.IsPalindromeDP("waterrfetawx", 2));
            Assert.IsFalse(Problem121.IsPalindromeDP("waterrfetawx", 1));
            Assert.IsTrue(Problem121.IsPalindromeDP("", 3));
            Assert.IsTrue(Problem121.IsPalindromeDP(null, 0));
        }
    }
}
