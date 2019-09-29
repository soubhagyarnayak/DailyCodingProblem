
/*
 * This problem was asked by Facebook.
 * Given a binary tree, return all paths from the root to leaves.
 * For example, given the tree:

   1
  / \
 2   3
    / \
   4   5
   Return [[1, 2], [1, 3, 4], [1, 3, 5]].
 * 
 */
using System.Collections.Generic;

namespace DailyCodingProblem
{
    public static class Problem110
    {
        public static List<List<int>> FindAllPathsFromRootToLeafs(BinaryTreeNode root)
        {
            List<List<int>> paths = new List<List<int>>();
            if(root == null)
            {
                return paths;
            }
            List<int> pathFromRoot = new List<int>();
            return FindAllPathsFromRootToLeafs(root, pathFromRoot);
        }

        private static List<List<int>> FindAllPathsFromRootToLeafs(BinaryTreeNode node, List<int> pathFromRoot)
        {
            List<List<int>> paths = new List<List<int>>();
            var temp = new List<int>(pathFromRoot);
            temp.Add(node.Value);
            if (node.Left == null && node.Right == null)
            {
                paths.Add(temp);
            }
            else
            {
                if(node.Left != null)
                {
                    paths.AddRange(FindAllPathsFromRootToLeafs(node.Left, temp));
                }
                if(node.Right != null)
                {
                    paths.AddRange(FindAllPathsFromRootToLeafs(node.Right, temp));
                }
            }
            return paths;
        }
    }

    public class BinaryTreeNode
    {
        public BinaryTreeNode Left { get; set; }

        public BinaryTreeNode Right { get; set; }

        public int Value { get; set; }

        public BinaryTreeNode(int value)
        {
            Value = value;
        }
    }
}
