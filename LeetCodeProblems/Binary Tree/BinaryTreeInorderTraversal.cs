using System.Collections.Generic;

namespace LeetCodeProblems.Binary_Tree
{
	public class BinaryTreeInorderTraversal
	{
		public class TreeNode
		{
			public int val;
			public TreeNode left;
			public TreeNode right;
			public TreeNode(int x) { val = x; }
		}

		public IList<int> InorderTraversal(TreeNode root)
		{
			List<int> result = new List<int>();

			Stack<TreeNode> stack = new Stack<TreeNode>();
			TreeNode current = root;

			while (current != null || stack.Count > 0)
			{
				while (current != null)
				{
					stack.Push(current);
					current = current.left;
				}

				current = stack.Pop();

				result.Add(current.val);

				current = current.right;
			}

			return result;
		}

		public IList<int> InorderTraversal2(TreeNode root)
		{
			List<int> result = new List<int>();
			if (root != null)
				_InorderTraversal2(root, result);
			return result;
		}

		private void _InorderTraversal2(TreeNode root, List<int> list)
		{
			if (root.left != null)
				_InorderTraversal2(root.left, list);

			list.Add(root.val);

			if (root.right != null)
				_InorderTraversal2(root.right, list);
		}
	}
}
