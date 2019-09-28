using DailyCodingProblem;
using NUnit.Framework;

namespace DailyCodingProblemTests
{
    public class Problem138Test
    {
        [Test]
        public void TestFindMinCoins()
        {
            int result = Problem138.FindMinCoins(new int[] { 1, 5, 10, 25 }, 16);
            Assert.AreEqual(3, result);

            result = Problem138.FindMinCoins(new int[] { 5, 10, 25 }, 16);
            Assert.AreEqual(-1, result);

            result = Problem138.FindMinCoins(new int[] { 2, 5, 10, 25 }, 16);
            Assert.AreEqual(4, result);
        }
    }
}
