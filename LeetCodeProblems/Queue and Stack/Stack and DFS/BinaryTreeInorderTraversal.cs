using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.Queue_and_Stack.Stack_and_DFS
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
			if (root == null)
				return new List<int>();

			List<int> result = new List<int>();
			Stack<TreeNode> stack = new Stack<TreeNode>();
			HashSet<TreeNode> visited = new HashSet<TreeNode>();

			stack.Push(root);

			while (stack.Count > 0)
			{
				TreeNode node = stack.Peek();

				if (node.left != null && !visited.Contains(node.left))
				{
					stack.Push(node.left);
					visited.Add(node.left);
				}
				else
				{
					node = stack.Pop();
					result.Add(node.val);
					if (node.right != null)
						stack.Push(node.right);
				}
			}

			return result;
		}

		public IList<int> InorderTraversal2(TreeNode root)
		{
			IList<int> list = new List<int>();
			_InorderTraversal(root, list);
			return list;
		}

		private void _InorderTraversal(TreeNode root, IList<int> list)
		{
			if (root == null)
				return;

			_InorderTraversal(root.left, list);
			list.Add(root.val);
			_InorderTraversal(root.right, list);
		}
	}
}
