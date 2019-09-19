using DailyCodingProblem;
using NUnit.Framework;
using System.Collections.Generic;

namespace DailyCodingProblemTests
{
    public class Problem128Test
    {
        [Test]
        public void TestFetchTowerOfHanoiSteps()
        {
            var expected = new List<string>()
            {
                "Move 1 to 3",
                "Move 1 to 2",
                "Move 3 to 2",
                "Move 1 to 3",
                "Move 2 to 1",
                "Move 2 to 3",
                "Move 1 to 3"
            };
            var actual = Problem128.FetchTowerOfHanoiSteps(3);
            Assert.AreEqual(expected, actual);
        }
    }
}
