using DailyCodingProblem;
using NUnit.Framework;

namespace DailyCodingProblemTests
{
    class Problem126Test
    {
        [Test]
        public void TestRotateByReversal()
        {
            int[] input = new int[] { 1, 2, 3, 4, 5, 6 };
            int[] output = Problem126.RotateByReversal(input, 2);
            Assert.AreEqual(new int[] { 3, 4, 5, 6, 1, 2 }, output);
        }

        [Test]
        public void TestRotateByJuggling()
        {
            int[] input = new int[] { 1, 2, 3, 4, 5, 6 };
            int[] output = Problem126.RotateByJuggling(input, 2);
            Assert.AreEqual(new int[] { 3, 4, 5, 6, 1, 2 }, output);
        }
    }
}
