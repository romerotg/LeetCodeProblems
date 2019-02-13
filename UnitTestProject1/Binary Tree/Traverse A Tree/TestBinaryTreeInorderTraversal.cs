using LeetCodeProblems.Binary_Tree.Traverse_A_Tre;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;
using static LeetCodeProblems.Binary_Tree.Traverse_A_Tre.BinaryTreeInorderTraversal;

namespace UnitTestProject1.Binary_Tree.Traverse_A_Tre
{
	[TestClass]
	public class TestBinaryTreeInorderTraversal
	{
		[TestMethod]
		public void TestMethod1()
		{
			// Arrange
			BinaryTreeInorderTraversal question = new BinaryTreeInorderTraversal();
			TreeNode root = new TreeNode(1);
			root.right = new TreeNode(2);
			root.right.left = new TreeNode(3);
			int[] expected = new int[] { 1, 3, 2 };

			// Act
			IList<int> actual = question.InorderTraversal(root);

			// Assert
			CollectionAssert.AreEqual(expected, actual?.ToArray());
		}

		[TestMethod]
		public void TestMethod2()
		{
			// Arrange
			BinaryTreeInorderTraversal question = new BinaryTreeInorderTraversal();
			TreeNode root = new TreeNode(1);
			root.right = new TreeNode(2);
			root.right.left = new TreeNode(3);
			int[] expected = new int[] {1,3,2 };

			// Act
			IList<int> actual = question.InorderTraversal2(root);

			// Assert
			CollectionAssert.AreEqual(expected, actual?.ToArray());
		}
	}
}
