using DailyCodingProblem;
using NUnit.Framework;
using System.Collections.Generic;

namespace Tests
{
    public class Problem118Test
    {
        [Test]
        public void TestReturnSortedSquares()
        {
            var input = new List<int>() { -9, -2, 0, 2, 3 };
            var output = Problem118.ReturnSortedSquares(input);
            var expectedOutput = new List<int>() { 0, 4, 4, 9, 81 };
            Assert.AreEqual(expectedOutput, output);
        }

        [Test]
        public void TestReturnSortedSquaresAllNegative()
        {
            var input = new List<int>() { -9, -7, -6, -5, -1 };
            var output = Problem118.ReturnSortedSquares(input);
            var expectedOutput = new List<int>() { 1, 25, 36, 49, 81 };
            Assert.AreEqual(expectedOutput, output);
        }

        [Test]
        public void TestReturnSortedSquaresAllPositives()
        {
            var input = new List<int>() { 3, 6, 9, 10, 11 };
            var output = Problem118.ReturnSortedSquares(input);
            var expectedOutput = new List<int>() { 9, 36, 81, 100, 121 };
            Assert.AreEqual(expectedOutput, output);
        }

        [Test]
        public void TestReturnSortedSquaresEmpty()
        {
            var input = new List<int>() {  };
            var output = Problem118.ReturnSortedSquares(input);
            var expectedOutput = new List<int>() {  };
            Assert.AreEqual(expectedOutput, output);
        }
    }
}