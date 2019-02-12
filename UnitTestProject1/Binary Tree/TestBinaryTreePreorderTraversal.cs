using LeetCodeProblems.Binary_Tree;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;
using static LeetCodeProblems.Binary_Tree.BinaryTreePreorderTraversal;

namespace UnitTestProject1.Binary_Tree
{
	[TestClass]
	public class TestBinaryTreePreorderTraversal
	{
		[DataTestMethod]
		public void TestMethod1()
		{
			// Arrange
			BinaryTreePreorderTraversal question = new BinaryTreePreorderTraversal();
			TreeNode root = new TreeNode(1);
			root.right = new TreeNode(2);
			root.right.left = new TreeNode(3);
			int[] expected = new int[] { 1, 2, 3 };

			// Act
			IList<int> actual = question.PreorderTraversal(root);

			// Assert
			CollectionAssert.AreEqual(expected, actual?.ToArray());
		}

		[DataTestMethod]
		public void TestMethod2()
		{
			// Arrange
			BinaryTreePreorderTraversal question = new BinaryTreePreorderTraversal();
			TreeNode root = new TreeNode(1);
			root.right = new TreeNode(2);
			root.right.left = new TreeNode(3);
			int[] expected = new int[] { 1, 2, 3 };

			// Act
			IList<int> actual = question.PreorderTraversal2(root);

			// Assert
			CollectionAssert.AreEqual(expected, actual?.ToArray());
		}
	}
}
