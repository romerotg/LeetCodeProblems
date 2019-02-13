using LeetCodeProblems.Binary_Tree.Traverse_A_Tree;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;
using static LeetCodeProblems.Binary_Tree.Traverse_A_Tree.BinaryTreeLevelTraversal;

namespace UnitTestProject1.Binary_Tree.Traverse_A_Tre
{
	[TestClass]
	public class TestBinaryTreeLevelTraversal
	{
		[TestMethod]
		public void TestMethod1()
		{
			// Arrange
			BinaryTreeLevelTraversal question = new BinaryTreeLevelTraversal();
			TreeNode root = new TreeNode(3);
			root.left = new TreeNode(9);
			root.right = new TreeNode(20);
			root.right.left = new TreeNode(15);
			root.right.right = new TreeNode(7);
			int[][] expected = new int[][] { new int[] { 3 }, new int[] { 9, 20 }, new int[] { 15, 7 } };

			// Act
			IList<IList<int>> actual = question.LevelOrder(root);

			// Assert
			Assert.IsNotNull(actual);
			Assert.AreEqual(expected.Length, actual.Count);
			for (int i = 0; i < expected.Length; i++)
				CollectionAssert.AreEqual(expected[i], actual[i].ToArray());
		}
	}
}
