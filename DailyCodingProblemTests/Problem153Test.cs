using DailyCodingProblem;
using NUnit.Framework;

namespace DailyCodingProblemTests
{
    public class Problem153Test
    {
        [Test]
        public void TestFindSmallestDistance()
        {
            int actual = Problem153.FindSmallestDistance("hello", "world", "dog cat hello cat dog dog hello cat world");
            Assert.AreEqual(1, actual);

            actual = Problem153.FindSmallestDistance("quick", "frog", "the quick the brown quick brown the frog");
            Assert.AreEqual(2, actual);
        }
    }
}
