using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.Binary_Tree.Conclusion
{
	public class SerializeandDeserializeBinaryTree
	{
		public class TreeNode
		{
			public int val;
			public TreeNode left;
			public TreeNode right;
			public TreeNode(int x) { val = x; }
		}

		// Encodes a tree to a single string.
		public string serialize(TreeNode root)
		{
			if (root == null)
				return null;

			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("[");

			Queue<TreeNode> queue = new Queue<TreeNode>();
			queue.Enqueue(root);

			while (queue.Count > 0)
			{
				int levelCount = queue.Count;
				for (int i = 0; i < levelCount; i++)
				{
					TreeNode node = queue.Dequeue();

					if (node != null)
						stringBuilder.Append(node.val);
					else
						stringBuilder.Append("null");

					stringBuilder.Append(",");

					if (node != null)
					{
						queue.Enqueue(node.left);
						queue.Enqueue(node.right);
					}
				}
			}

			stringBuilder.Remove(stringBuilder.Length - 1, 1);
			stringBuilder.Append("]");

			return stringBuilder.ToString(); ;
		}

		// Decodes your encoded data to tree.
		public TreeNode deserialize(string data)
		{
			if (data == null || data.Length <= 2)
				return null;

			// Remove first and last chars '[' and ']'
			data = data.Remove(0, 1);
			data = data.Remove(data.Length - 1, 1);

			string[] values = data.Split(',');

			if (!int.TryParse(values[0], out int rootValue))
				return null;
			TreeNode root = new TreeNode(rootValue);
			List<TreeNode> previousNodeLevel = new List<TreeNode>() { root };
			int index = 1;
			int levelLength = 2;
			bool left = true;

			while (index < values.Length)
			{
				List<TreeNode> currentNodeLevel = new List<TreeNode>();
				int prevIndex = 0;

				for (int i = 0; i < levelLength && index < values.Length; i++)
				{
					if (int.TryParse(values[index], out int value))
					{
						TreeNode node = new TreeNode(value);
						currentNodeLevel.Add(node);

						if (left)
							previousNodeLevel[prevIndex].left = node;
						else
							previousNodeLevel[prevIndex].right = node;
					}

					left = !left;
					if (left)
						prevIndex++;

					index++;
				}

				levelLength = currentNodeLevel.Count * 2;
				previousNodeLevel = currentNodeLevel;
			}

			return root;
		}
	}
}
