using System.Collections.Generic;

namespace LeetCodeProblems.Binary_Tree.Traverse_A_Tre
{
	public class BinaryTreePostorderTraversal
	{
		public class TreeNode
		{
			public int val;
			public TreeNode left;
			public TreeNode right;
			public TreeNode(int x) { val = x; }
		}

		public IList<int> PostorderTraversal(TreeNode root)
		{
			List<int> result = new List<int>();

			Stack<TreeNode> stack1 = new Stack<TreeNode>();
			Stack<TreeNode> stack2 = new Stack<TreeNode>();

			if (root != null)
				stack1.Push(root);

			while (stack1.Count > 0)
			{
				TreeNode node = stack1.Pop();
				stack2.Push(node);

				if (node.left != null)
					stack1.Push(node.left);
				if (node.right != null)
					stack1.Push(node.right);
			}

			while (stack2.Count > 0)
			{
				TreeNode node = stack2.Pop();
				result.Add(node.val);
			}

			return result;
		}

		public IList<int> PostorderTraversal2(TreeNode root)
		{
			List<int> result = new List<int>();
			if (root != null)
				_PostorderTraversal2(root, result);
			return result;
		}

		private void _PostorderTraversal2(TreeNode root, List<int> list)
		{
			if (root.left != null)
				_PostorderTraversal2(root.left, list);

			if (root.right != null)
				_PostorderTraversal2(root.right, list);

			list.Add(root.val);
		}
	}
}
