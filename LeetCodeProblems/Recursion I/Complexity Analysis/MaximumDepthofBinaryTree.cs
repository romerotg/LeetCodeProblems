using System;

namespace LeetCodeProblems.Recursion_I.Complexity_Analysis
{
	public class TreeNode
	{
		public int val;
		public TreeNode left;
		public TreeNode right;
		public TreeNode(int x) { val = x; }
	}

	public class MaximumDepthofBinaryTree
	{
		public int MaxDepth(TreeNode root)
		{
			return _MaxDepth(root, 0);
		}

		private int _MaxDepth(TreeNode root, int depth)
		{
			if (root == null)
				return depth;

			return Math.Max(_MaxDepth(root.left, depth + 1), _MaxDepth(root.right, depth + 1));
		}
	}
}
