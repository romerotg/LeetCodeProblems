using System.Collections.Generic;

namespace LeetCodeProblems.Recursion_I.Conclusion
{
	public class TreeNode
	{
		public int val;
		public TreeNode left;
		public TreeNode right;
		public TreeNode(int x) { val = x; }
	}

	public class UniqueBinarySearchTreesII
	{
		public IList<TreeNode> GenerateTrees(int n)
		{
			List<TreeNode> result = new List<TreeNode>();
			if (n <= 0)
				return result;
			if (n == 1)
			{
				result.Add(new TreeNode(1));
				return result;
			}

			IList<TreeNode> prevTrees = GenerateTrees(n - 1);

			foreach (TreeNode root in prevTrees)
				result.AddRange(_AddValue(root, n));

			return result;
		}

		private IList<TreeNode> _AddValue(TreeNode root, int n)
		{
			List<TreeNode> trees = new List<TreeNode>();

			// n as root
			trees.Add(new TreeNode(n) { left = root });

			int countRight = _CountRight(root);

			for (int i = 0; i < countRight; i++)
			{
				bool added = false;
				int count = i;

				TreeNode rootClone = new TreeNode(root.val) { left = _CloneTree(root.left) };
				TreeNode prevNode = root;
				TreeNode prevClone = rootClone;
				TreeNode node = root.right;
				while (node != null)
				{
					TreeNode clone = new TreeNode(node.val) { left = _CloneTree(node.left) };

					if (!added && count == 0)
					{
						prevClone.right = new TreeNode(n);
						prevClone.right.left = clone;
						added = true;
					}
					else
						prevClone.right = clone;

					prevClone = clone;
					prevNode = node;
					node = node.right;
					count--;
				}

				if (!added)
					prevClone.right = new TreeNode(n);

				trees.Add(rootClone);
			}

			return trees;
		}

		private int _CountRight(TreeNode root)
		{
			if (root == null)
				return 0;

			return 1 + _CountRight(root.right);
		}

		private TreeNode _CloneTree(TreeNode root)
		{
			if (root == null)
				return null;

			return new TreeNode(root.val)
			{
				left = _CloneTree(root.left),
				right = _CloneTree(root.right)
			};
		}
	}
}
