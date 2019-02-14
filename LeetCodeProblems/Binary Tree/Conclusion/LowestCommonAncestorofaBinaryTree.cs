using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.Binary_Tree.Conclusion
{
	public class LowestCommonAncestorofaBinaryTree
	{
		public class TreeNode
		{
			public int val;
			public TreeNode left;
			public TreeNode right;
			public TreeNode(int x) { val = x; }
		}

		public TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q)
		{
			if (root == null || p == null || q == null)
				return null;

			List<TreeNode> pAncestors = new List<TreeNode>();
			_GetAncestors(root, p, pAncestors);

			List<TreeNode> qAncestors = new List<TreeNode>();
			_GetAncestors(root, q, qAncestors);

			HashSet<TreeNode> pAncestorsHash = new HashSet<TreeNode>(pAncestors);

			foreach (TreeNode qAncestor in qAncestors)
			{
				if (pAncestorsHash.Contains(qAncestor))
					return qAncestor;
			}

			return null;
		}

		private void _GetAncestors(TreeNode root, TreeNode target, List<TreeNode> ancestors)
		{
			if (root == null)
				return;

			if (root.val == target.val)
			{
				ancestors.Add(root);
				return;
			}

			_GetAncestors(root.left, target, ancestors);
			if (ancestors.Count > 0)
			{
				ancestors.Add(root);
				return;
			}

			_GetAncestors(root.right, target, ancestors);
			if (ancestors.Count > 0)
			{
				ancestors.Add(root);
				return;
			}
		}
	}
}
