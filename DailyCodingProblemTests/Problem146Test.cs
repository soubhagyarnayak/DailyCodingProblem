using DailyCodingProblem;
using NUnit.Framework;

namespace DailyCodingProblemTests
{
    public class Problem146Test
    {
        [Test]
        public void TestPrune()
        {
            BinaryTreeNode root = new BinaryTreeNode(0);
            root.Left = new BinaryTreeNode(1);
            root.Right = new BinaryTreeNode(0);
            root.Right.Left = new BinaryTreeNode(1);
            root.Right.Right = new BinaryTreeNode(0);
            root.Right.Left.Left = new BinaryTreeNode(0);
            root.Right.Left.Right = new BinaryTreeNode(0);
            var result = Problem146.Prune(root);
            Assert.AreEqual(0, root.Value);
            Assert.AreEqual(1, root.Left.Value);
            Assert.AreEqual(0, root.Right.Value);
            Assert.AreEqual(1, root.Right.Left.Value);
            Assert.IsNull(root.Right.Right);
            Assert.IsNull(root.Right.Left.Left);
            Assert.IsNull(root.Right.Left.Right);
        }
    }
}
