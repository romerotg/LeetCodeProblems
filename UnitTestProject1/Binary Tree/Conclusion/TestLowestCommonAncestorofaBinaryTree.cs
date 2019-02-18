using LeetCodeProblems.Binary_Tree.Conclusion;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using static LeetCodeProblems.Binary_Tree.Conclusion.LowestCommonAncestorofaBinaryTree;

namespace UnitTestProject1.Binary_Tree.Conclusion
{
	[TestClass]
	public class TestLowestCommonAncestorofaBinaryTree
	{
		[DataRow(new string[] { "3", "5", "1", "6", "2", "0", "8", null, null, "7", "4" }, 5, 1, 3)]
		[DataRow(new string[] { "3", "5", "1", "6", "2", "0", "8", null, null, "7", "4" }, 5, 4, 5)]
		[DataTestMethod]
		public void TestMethod1(string[] nodes, int pVal, int qVal, int expected)
		{
			// Arrange
			LowestCommonAncestorofaBinaryTree question = new LowestCommonAncestorofaBinaryTree();
			TreeNode root = null;
			TreeNode p = null;
			TreeNode q = null;
			if (nodes != null && nodes.Length > 0)
			{
				root = new TreeNode(int.Parse(nodes[0]));
				List<TreeNode> nodesPreviousLevel = new List<TreeNode>() { root };

				int nodesInLevel = 2;
				bool left = true;

				int index = 1;
				while (index < nodes.Length)
				{
					List<TreeNode> nodesCurrentLevel = new List<TreeNode>();

					int prevIndex = 0;
					for (int i = 0; i < nodesInLevel && index < nodes.Length; i++)
					{
						if (nodes[index] != null)
						{
							TreeNode node = new TreeNode(int.Parse(nodes[index]));
							if (node.val == pVal)
								p = node;
							else if (node.val == qVal)
								q = node;

							nodesCurrentLevel.Add(node);
							if (left)
								nodesPreviousLevel[prevIndex].left = node;
							else
								nodesPreviousLevel[prevIndex].right = node;
						}

						left = !left;
						if (left)
							prevIndex++;

						index++;
					}

					nodesInLevel = nodesCurrentLevel.Count * 2;
					nodesPreviousLevel = nodesCurrentLevel;
				}
			}

			// Act
			TreeNode actual = question.LowestCommonAncestor(root, p, q);

			// Assert
			Assert.AreEqual(expected, actual?.val);
		}
	}
}
