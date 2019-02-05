using System.Collections.Generic;

namespace LeetCodeProblems.Hash_Table.Practical_Application___Design_the_Key
{
	public class FindDuplicateSubtreesQ
	{
		public IList<TreeNode> FindDuplicateSubtrees(TreeNode root)
		{
			Dictionary<string, int> nodesHashmap = new Dictionary<string, int>();
			IList<TreeNode> result = new List<TreeNode>();
			_TreeNodeToString(root, nodesHashmap, result);
			return result;
		}

		private string _TreeNodeToString(TreeNode root, Dictionary<string, int> nodesHashmap, IList<TreeNode> result)
		{
			if (root == null)
				return "#";

			string key = $"{root.val},{_TreeNodeToString(root.left, nodesHashmap, result)},{_TreeNodeToString(root.right, nodesHashmap, result)}";

			if (nodesHashmap.ContainsKey(key))
			{
				nodesHashmap[key]++;
				if (nodesHashmap[key] == 2)
					result.Add(root);
			}
			else
				nodesHashmap.Add(key, 1);

			return key;
		}

		public class TreeNode
		{
			public int val;
			public TreeNode left;
			public TreeNode right;
			public TreeNode(int x) { val = x; }
		}
	}
}
