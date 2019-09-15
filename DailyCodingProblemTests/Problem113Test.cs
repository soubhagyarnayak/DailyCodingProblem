using DailyCodingProblem;
using NUnit.Framework;

namespace DailyCodingProblemTests
{
    public class Problem113Test
    {
        [Test]
        public void TestReverseWords()
        {
            string output = Problem113.ReverseWords("hello world here");
            Assert.AreEqual("here world hello", output);
            output = Problem113.ReverseWords("soubhagya r nayak ");
            Assert.AreEqual(" nayak r soubhagya", output);
        }
    }
}
