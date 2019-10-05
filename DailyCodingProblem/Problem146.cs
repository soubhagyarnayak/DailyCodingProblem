using System;

/*
 * This question was asked by BufferBox.
 * Given a binary tree where all nodes are either 0 or 1, prune the tree so that subtrees containing all 0s are removed.
 * For example, given the following tree:

   0
  / \
 1   0
    / \
   1   0
  / \
 0   0
 should be pruned to:

   0
  / \
 1   0
    /
   1
   
    We do not remove the tree at the root or its left child because it still has a 1 as a descendant.
 * 
 * 
 * MEDIUM
 * 
 */
namespace DailyCodingProblem
{
    public static class Problem146
    {
        public static BinaryTreeNode Prune(BinaryTreeNode root)
        {
            PruneInternal(root);
            return root;
        }

        private static bool PruneInternal(BinaryTreeNode node)
        {
            if(node == null)
            {
                return true;
            }
            if (PruneInternal(node.Left))
            {
                node.Left = null;
            }
            if (PruneInternal(node.Right))
            {
                node.Right = null;
            }
            return (node.Value==0) && (node.Left==null) && (node.Right==null);
        }
    }
}
