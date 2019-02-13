namespace LeetCodeProblems.Binary_Tree.Solve_Problems_Recursively
{
	public class PathSum
	{
		public class TreeNode
		{
			public int val;
			public TreeNode left;
			public TreeNode right;
			public TreeNode(int x) { val = x; }
		}

		public bool HasPathSum(TreeNode root, int sum)
		{
			return _HasPathSum(root, sum, 0);
		}

		private bool _HasPathSum(TreeNode root, int targetSum, int currentSum)
		{
			if (root == null)
				return false;

			currentSum = currentSum + root.val;

			if (currentSum == targetSum && root.left == null && root.right == null)
				return true;

			return _HasPathSum(root.left, targetSum, currentSum) || _HasPathSum(root.right, targetSum, currentSum);
		}
	}
}
