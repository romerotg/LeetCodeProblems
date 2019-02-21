using LeetCodeProblems.Queue_and_Stack.Stack_and_DFS;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;
using static LeetCodeProblems.Queue_and_Stack.Stack_and_DFS.BinaryTreeInorderTraversal;

namespace Tests.Queue_and_Stack.Stack_and_DFS
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
			TreeNode root = new TreeNode(3);
			root.left = new TreeNode(1);
			root.left.right = new TreeNode(2);
			int[] expected = new int[] { 1, 2, 3 };

			// Act
			IList<int> actual = question.InorderTraversal(root);

			// Assert
			CollectionAssert.AreEqual(expected, actual?.ToArray());
		}

		[TestMethod]
		public void TestMethod3()
		{
			// Arrange
			BinaryTreeInorderTraversal question = new BinaryTreeInorderTraversal();
			TreeNode root = new TreeNode(1);
			root.right = new TreeNode(2);
			root.right.left = new TreeNode(3);
			int[] expected = new int[] { 1, 3, 2 };

			// Act
			IList<int> actual = question.InorderTraversal2(root);

			// Assert
			CollectionAssert.AreEqual(expected, actual?.ToArray());
		}

		[TestMethod]
		public void TestMethod4()
		{
			// Arrange
			BinaryTreeInorderTraversal question = new BinaryTreeInorderTraversal();
			TreeNode root = new TreeNode(3);
			root.left = new TreeNode(1);
			root.left.right = new TreeNode(2);
			int[] expected = new int[] { 1, 2, 3 };

			// Act
			IList<int> actual = question.InorderTraversal2(root);

			// Assert
			CollectionAssert.AreEqual(expected, actual?.ToArray());
		}
	}
}
