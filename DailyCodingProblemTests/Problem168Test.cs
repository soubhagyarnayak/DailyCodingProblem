using NUnit.Framework;

namespace DailyCodingProblem
{
    public class Problem168Test
    {
        [Test]
        public void TestMatrixRotation()
        {
            int[][] data = new int[][]
            {
                new int[]{1,2,3 },
                new int[]{4,5,6 },
                new int[]{7,8,9 }
            };
            Problem168.RotateBy90Degrees(data);
            int[][] expected = new int[][]
            {
                new int[]{7,4,1},
                new int[]{8,5,2},
                new int[]{9,6,3}
            };
            Assert.AreEqual(expected, data);
        }
    }
}
