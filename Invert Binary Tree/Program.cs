using System.Collections.Generic;

namespace Invert_Binary_Tree
{
  class Program
  {
    static void Main(string[] args)
    {
      TreeNode root = new TreeNode(4);
      root.left = new TreeNode(2);
      root.right = new TreeNode(7);
      root.left.left = new TreeNode(1);
      root.left.right = new TreeNode(3);
      root.right.left = new TreeNode(6);
      root.right.right = new TreeNode(9);
      Program p = new Program();
      TreeNode result = p.InvertTree(root);
    }
    public class TreeNode
    {
      public int value;
      public TreeNode left, right;
      public TreeNode(int value)
      {
        this.value = value;
        left = right = null;
      }
    }
    public TreeNode InvertTree(TreeNode root)
    {
      if (root == null) return null;
      Queue<TreeNode> queue = new Queue<TreeNode>();
      queue.Enqueue(root);
      while(queue.Count > 0)
      {
        TreeNode node = queue.Dequeue();
        TreeNode temp = node.left;
        node.left = node.right;
        node.right = temp;

        if (node.left != null) queue.Enqueue(node.left);
        if (node.right != null) queue.Enqueue(node.right);
      }
      return root;
    }
  }
}
