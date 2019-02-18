using LeetCodeProblems.Binary_Tree.Conclusion;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using static LeetCodeProblems.Binary_Tree.Conclusion.SerializeandDeserializeBinaryTree;

namespace UnitTestProject1.Binary_Tree.Conclusion
{
	[TestClass]
	public class TestSerializeandDeserializeBinaryTree
	{
		[DataRow(new string[] { "1", "2", "3", null, null, "4", "5" }, "[1,2,3,null,null,4,5]")]
		[DataTestMethod]
		public void TestMethod1(string[] nodes, string expected)
		{
			// Arrange
			SerializeandDeserializeBinaryTree question = new SerializeandDeserializeBinaryTree();
			TreeNode root = null;
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
			string actual = question.serialize(root);

			// Assert
			Assert.AreEqual(expected, actual);
		}

		[DataRow(new string[] { "1", "2", "3", null, null, "4", "5" }, "[1,2,3,null,null,4,5]")]
		[DataTestMethod]
		public void TestMethod2(string[] expected, string serialized)
		{
			// Arrange
			SerializeandDeserializeBinaryTree question = new SerializeandDeserializeBinaryTree();
			TreeNode root = null;
			if (expected != null && expected.Length > 0)
			{
				root = new TreeNode(int.Parse(expected[0]));
				List<TreeNode> nodesPreviousLevel = new List<TreeNode>() { root };

				int nodesInLevel = 2;
				bool left = true;

				int index = 1;
				while (index < expected.Length)
				{
					List<TreeNode> nodesCurrentLevel = new List<TreeNode>();

					int prevIndex = 0;
					for (int i = 0; i < nodesInLevel && index < expected.Length; i++)
					{
						if (expected[index] != null)
						{
							TreeNode node = new TreeNode(int.Parse(expected[index]));

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
			TreeNode actual = question.deserialize(serialized);
		}

		[TestMethod]
		public void TestMethod3()
		{
			// Arrange
			SerializeandDeserializeBinaryTree question = new SerializeandDeserializeBinaryTree();
			TreeNode root = new TreeNode(1);
			root.left = new TreeNode(2);
			root.left.left = new TreeNode(3);
			root.left.left.left = new TreeNode(4);
			root.left.left.left.left = new TreeNode(5);
			string expected = "[1,2,null,3,null,4,null,5]";

			// Act
			string actual = question.serialize(root);

			Assert.AreEqual(expected, actual);
		}


		[TestMethod]
		public void TestMethod4()
		{
			// Arrange
			SerializeandDeserializeBinaryTree question = new SerializeandDeserializeBinaryTree();
			string serialized = "[1,2,null,3,null,4,null,5]";

			// Act
			TreeNode actual = question.deserialize(serialized);
		}
	}
}
