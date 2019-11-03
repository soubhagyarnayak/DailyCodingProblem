using DailyCodingProblem;
using NUnit.Framework;
using System.Collections.Generic;

namespace DailyCodingProblemTests
{
    class Problem170Test
    {
        [Test]
        public void TestWordLadder()
        {
            List<string> actual = Problem170.FindTransformPath("dog", "cat", new HashSet<string>() { "dot", "dop", "dat", "cat" });
            Assert.AreEqual(new List<string>() { "dog", "dot", "dat", "cat" }, actual);

            actual = Problem170.FindTransformPath("dog", "cat", new HashSet<string>() { "dot", "tod", "tat", "dar" });
            Assert.IsNull(actual);
        }  
    }
}
