namespace LeetCodeProblems.Binary_Tree.Conclusion
{
	public class ConstructBinaryTreefromInorderandPostorderTraversal
	{
		public class TreeNode
		{
			public int val;
			public TreeNode left;
			public TreeNode right;
			public TreeNode(int x) { val = x; }
		}

		public TreeNode BuildTree(int[] inorder, int[] postorder)
		{
			if (inorder == null || postorder == null)
				return null;
			if (inorder.Length != postorder.Length)
				return null;

			return _BuildTree(inorder, postorder, postorder.Length - 1, 0, inorder.Length - 1);
		}

		private TreeNode _BuildTree(int[] inorder, int[] postorder, int postorderIndex, int start, int end)
		{
			TreeNode root = null;

			if (postorderIndex >= 0)
			{
				for (int i = start; i <= end; i++)
				{
					if (inorder[i] == postorder[postorderIndex])
					{
						root = new TreeNode(inorder[i]);
						root.right = _BuildTree(inorder, postorder, postorderIndex - 1, i + 1, end);
						root.left = _BuildTree(inorder, postorder, (postorderIndex - 2) - (end + i + 1), start, i - 1);
					}
				}
			}

			return root;
		}
	}
}
