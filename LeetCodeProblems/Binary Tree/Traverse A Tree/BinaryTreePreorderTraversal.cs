using System.Collections.Generic;

namespace LeetCodeProblems.Binary_Tree.Traverse_A_Tre
{
	public class BinaryTreePreorderTraversal
	{
		public class TreeNode
		{
			public int val;
			public TreeNode left;
			public TreeNode right;
			public TreeNode(int x) { val = x; }
		}

		public IList<int> PreorderTraversal(TreeNode root)
		{
			List<int> result = new List<int>();

			Stack<TreeNode> stack = new Stack<TreeNode>();

			if (root != null)
				stack.Push(root);

			while (stack.Count > 0)
			{
				TreeNode node = stack.Pop();

				result.Add(node.val);

				if (node.right != null)
					stack.Push(node.right);

				if (node.left != null)
					stack.Push(node.left);
			}

			return result;
		}

		public IList<int> PreorderTraversal2(TreeNode root)
		{
			List<int> result = new List<int>();

			if (root != null)
				_PreorderTraversal(root, result);

			return result;
		}

		private void _PreorderTraversal(TreeNode root, IList<int> list)
		{
			list.Add(root.val);

			if (root.left != null)
				_PreorderTraversal(root.left, list);

			if (root.right != null)
				_PreorderTraversal(root.right, list);
		}
	}
}
