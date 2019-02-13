namespace LeetCodeProblems.Binary_Tree.Conclusion
{
	public class ConstructBinaryTreefromPreorderandInorderTraversal
	{
		public class TreeNode
		{
			public int val;
			public TreeNode left;
			public TreeNode right;
			public TreeNode(int x) { val = x; }
		}

		public TreeNode BuildTree(int[] preorder, int[] inorder)
		{
			if (inorder == null || preorder == null)
				return null;
			if (inorder.Length != preorder.Length)
				return null;

			return _BuildTree(inorder, preorder, 0, 0, inorder.Length - 1);
		}

		private TreeNode _BuildTree(int[] inorder, int[] preorder, int preorderIndex, int start, int end)
		{
			TreeNode root = null;

			if (preorderIndex < preorder.Length)
			{
				for (int i = start; i <= end; i++)
				{
					if (inorder[i] == preorder[preorderIndex])
					{
						root = new TreeNode(inorder[i]);
						root.right = _BuildTree(inorder, preorder, (preorderIndex + 2) + (i - 1 - start), i + 1, end);
						root.left = _BuildTree(inorder, preorder, preorderIndex + 1, start, i - 1);
					}
				}
			}

			return root;
		}
	}
}
