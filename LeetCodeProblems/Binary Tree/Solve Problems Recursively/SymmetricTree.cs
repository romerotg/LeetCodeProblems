namespace LeetCodeProblems.Binary_Tree.Solve_Problems_Recursively
{
	public class SymmetricTree
	{
		public class TreeNode
		{
			public int val;
			public TreeNode left;
			public TreeNode right;
			public TreeNode(int x) { val = x; }
		}

		public bool IsSymmetric(TreeNode root)
		{
			if (root == null)
				return true;
			return _IsSymmetric(root.left, root.right);
		}

		private bool _IsSymmetric(TreeNode left, TreeNode right)
		{
			if (left == null && right == null)
				return true;
			if (left == null || right == null)
				return false;
			if (left.val != right.val)
				return false;

			return _IsSymmetric(left.left, right.right) && _IsSymmetric(left.right, right.left);
		}
	}
}
