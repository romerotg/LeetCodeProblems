﻿using LeetCodeProblems.Binary_Tree.Traverse_A_Tre;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;
using static LeetCodeProblems.Binary_Tree.Traverse_A_Tre.BinaryTreePostorderTraversal;

namespace Tests.Binary_Tree.Traverse_A_Tre
{
	[TestClass]
	public class TestBinaryTreePostorderTraversal
	{
		[TestMethod]
		public void TestMethod1()
		{
			// Arrange
			BinaryTreePostorderTraversal question = new BinaryTreePostorderTraversal();
			TreeNode root = new TreeNode(1);
			root.right = new TreeNode(2);
			root.right.left = new TreeNode(3);
			int[] expected = new int[] { 3, 2, 1 };

			// Act
			IList<int> actual = question.PostorderTraversal2(root);

			// Assert
			CollectionAssert.AreEqual(expected, actual?.ToArray());
		}

		[TestMethod]
		public void TestMethod2()
		{
			// Arrange
			BinaryTreePostorderTraversal question = new BinaryTreePostorderTraversal();
			TreeNode root = new TreeNode(1);
			root.right = new TreeNode(2);
			root.right.left = new TreeNode(3);
			int[] expected = new int[] { 3, 2, 1 };

			// Act
			IList<int> actual = question.PostorderTraversal2(root);

			// Assert
			CollectionAssert.AreEqual(expected, actual?.ToArray());
		}
	}
}
