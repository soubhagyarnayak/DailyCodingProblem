/*
 * This problem was asked by Amazon.
 * Given a node in a binary search tree, return the next bigger element, also known as the inorder successor.
 * For example, the inorder successor of 22 is 30.
   10
  /  \
 5    30
     /  \
   22    35
   You can assume each node has a parent pointer.
 * 
 */
namespace DailyCodingProblem
{
    public class BstNode
    {
        public BstNode Left { get; set; }

        public BstNode Right { get; set; }

        public int Value { get; set; }

        public BstNode(int value)
        {
            this.Value = value;
            this.Left = null;
            this.Right = null;
        }
    }

    public static class Problem133
    {
        public static BstNode FindInOrderSuccessor(BstNode node, BstNode root)
        {
            BstNode result = null;
            if(node.Right == null)
            {
                BstNode current = root;
                while (true)
                {
                    if(current.Value == node.Value)
                    {
                        break;
                    }
                    if (current.Value > node.Value)
                    {
                        result = current;
                        current = current.Left; 
                    }
                    else if(current.Value < node.Value)
                    {
                        current = current.Right;
                    }
                }
            }
            else
            {
                result = node.Right;
                while(result.Left != null)
                {
                    result = result.Left;
                }
            }
            return result;
        }
    }
}
