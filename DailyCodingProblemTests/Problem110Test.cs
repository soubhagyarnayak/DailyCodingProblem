using DailyCodingProblem;
using NUnit.Framework;
using System.Collections.Generic;

namespace DailyCodingProblemTests
{
    public class Problem110Test
    {
        [Test]
        public void TestFindAllPathsFromRootToLeafs()
        {
            List<List<int>> paths = Problem110.FindAllPathsFromRootToLeafs(null);
            Assert.AreEqual(0, paths.Count);

            paths = Problem110.FindAllPathsFromRootToLeafs(new BinaryTreeNode(10));
            Assert.AreEqual(1, paths.Count);
            Assert.AreEqual(new List<int>() { 10 }, paths[0]);

            BinaryTreeNode root = new BinaryTreeNode(1);
            root.Left = new BinaryTreeNode(2);
            root.Right = new BinaryTreeNode(3);
            root.Right.Left = new BinaryTreeNode(4);
            root.Right.Right = new BinaryTreeNode(5);

            paths = Problem110.FindAllPathsFromRootToLeafs(root);
            Assert.AreEqual(3, paths.Count);
        }
    }
}
