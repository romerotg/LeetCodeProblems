using LeetCodeProblems.Binary_Tree.Solve_Problems_Recursively;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using static LeetCodeProblems.Binary_Tree.Solve_Problems_Recursively.SymmetricTree;

namespace Tests.Binary_Tree.Solve_Problems_Recursively
{
	[TestClass]
	public class TestSymmetricTree
	{
		[TestMethod]
		public void TestMethod1()
		{
			// Arrange
			SymmetricTree question = new SymmetricTree();
			TreeNode root = new TreeNode(1);
			root.left = new TreeNode(2);
			root.right = new TreeNode(2);
			root.left.left = new TreeNode(3);
			root.left.right = new TreeNode(4);
			root.right.left = new TreeNode(4);
			root.right.right = new TreeNode(3);
			bool expected = true;

			// Act
			bool actual = question.IsSymmetric(root);

			// Assert
			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void TestMethod2()
		{
			// Arrange
			SymmetricTree question = new SymmetricTree();
			TreeNode root = new TreeNode(1);
			root.left = new TreeNode(2);
			root.right = new TreeNode(2);
			root.left.right = new TreeNode(3);
			root.right.right = new TreeNode(3);
			bool expected = false;

			// Act
			bool actual = question.IsSymmetric(root);

			// Assert
			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void TestMethod3()
		{
			// Arrange
			SymmetricTree question = new SymmetricTree();
			TreeNode root = new TreeNode(1);
			root.left = new TreeNode(2);
			root.right = new TreeNode(3);
			root.left.left = new TreeNode(3);
			root.right.left = new TreeNode(2);
			bool expected = false;

			// Act
			bool actual = question.IsSymmetric(root);

			// Assert
			Assert.AreEqual(expected, actual);
		}
	}
}
