using System;

namespace LeetCodeProblems.Binary_Tree.Solve_Problems_Recursively
{
	public class MaximumDepthofBinaryTree
	{
		public class TreeNode
		{
			public int val;
			public TreeNode left;
			public TreeNode right;
			public TreeNode(int x) { val = x; }
		}

		public int MaxDepth(TreeNode root)
		{
			return _MaxDepth(root, 0);
		}

		private int _MaxDepth(TreeNode root, int depth)
		{
			if (root == null)
				return depth;

			int leftDepth = _MaxDepth(root.left, depth + 1);
			int rightDepth = _MaxDepth(root.right, depth + 1);

			return Math.Max(leftDepth, rightDepth);
		}
	}
}
