using System.Collections.Generic;

namespace LeetCodeProblems.Binary_Tree.Traverse_A_Tree
{
	public class BinaryTreeLevelTraversal
	{
		public class TreeNode
		{
			public int val;
			public TreeNode left;
			public TreeNode right;
			public TreeNode(int x) { val = x; }
		}

		public IList<IList<int>> LevelOrder(TreeNode root)
		{
			List<IList<int>> result = new List<IList<int>>();

			if (root != null)
			{
				Queue<TreeNode> queue = new Queue<TreeNode>();
				queue.Enqueue(root);

				while (queue.Count > 0)
				{
					List<int> level = new List<int>();
					int currentQueueCount = queue.Count;

					for (int i = 0; i < currentQueueCount; i++)
					{
						TreeNode node = queue.Dequeue();
						level.Add(node.val);

						if (node.left != null)
							queue.Enqueue(node.left);

						if (node.right != null)
							queue.Enqueue(node.right);
					}

					result.Add(level);
				}
			}

			return result;
		}
	}
}
