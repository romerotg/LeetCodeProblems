using LeetCodeProblems.Binary_Tree.Solve_Problems_Recursively;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using static LeetCodeProblems.Binary_Tree.Solve_Problems_Recursively.PathSum;

namespace UnitTestProject1.Binary_Tree.Solve_Problems_Recursively
{
	[TestClass]
	public class TestPathSum
	{
		[TestMethod]
		public void TestMethod1()
		{
			// Arrange
			PathSum question = new PathSum();
			TreeNode root = new TreeNode(5);
			root.left = new TreeNode(4);
			root.left.left = new TreeNode(11);
			root.left.left.left = new TreeNode(7);
			root.left.left.right = new TreeNode(2);
			root.right = new TreeNode(8);
			root.right.left = new TreeNode(13);
			root.right.right = new TreeNode(4);
			root.right.right.right = new TreeNode(1);
			bool expected = true;

			// Act
			bool actual = question.HasPathSum(root, 22);

			// Assert
			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void TestMethod2()
		{
			// Arrange
			PathSum question = new PathSum();
			TreeNode root = new TreeNode(-2);
			root.right = new TreeNode(-3);
			bool expected = true;

			// Act
			bool actual = question.HasPathSum(root, -5);

			// Assert
			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void TestMethod3()
		{
			// Arrange
			PathSum question = new PathSum();
			TreeNode root = new TreeNode(1);
			root.left = new TreeNode(-2);
			root.right = new TreeNode(-3);
			root.right.left = new TreeNode(1);
			root.right.left.left = new TreeNode(3);
			root.right.left.left.left = new TreeNode(-2);
			root.right.left.right = new TreeNode(-1);
			bool expected = true;

			// Act
			bool actual = question.HasPathSum(root, -1);

			// Assert
			Assert.AreEqual(expected, actual);
		}
	}
}
