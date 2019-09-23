using DailyCodingProblem;
using NUnit.Framework;

namespace DailyCodingProblemTests
{
    public class Problem133Test
    {
        [Test]
        public void TestFindInOrderSuccessor()
        {
            BstNode root = new BstNode(10);
            root.Left = new BstNode(5);
            root.Right = new BstNode(30);
            root.Right.Left = new BstNode(22);
            root.Right.Right = new BstNode(35);
            BstNode result = Problem133.FindInOrderSuccessor(root.Left, root);
            Assert.AreEqual(10, result.Value);
            result = Problem133.FindInOrderSuccessor(root.Right.Left, root);
            Assert.AreEqual(30, result.Value);
            result = Problem133.FindInOrderSuccessor(root.Right, root);
            Assert.AreEqual(35, result.Value);
            result = Problem133.FindInOrderSuccessor(root.Right.Right, root);
            Assert.AreEqual(null, result);
            result = Problem133.FindInOrderSuccessor(root, root);
            Assert.AreEqual(22, result.Value);
        }
    }
}
