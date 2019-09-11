using DailyCodingProblem;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace DailyCodingProblemTests
{
    public class Problem122Test
    {
        [Test]
        public void TestFindMaxCoins()
        {
            int[,] input = new int[,] {
                { 0, 3, 1, 1 },
                { 2, 0, 0, 4 },
                { 1, 5, 3, 1 },
                };
            Assert.AreEqual(12, Problem122.FindMaxCoins(input));
        }
    }
}
