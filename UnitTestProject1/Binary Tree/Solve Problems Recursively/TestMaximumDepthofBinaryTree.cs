using LeetCodeProblems.Binary_Tree.Solve_Problems_Recursively;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using static LeetCodeProblems.Binary_Tree.Solve_Problems_Recursively.MaximumDepthofBinaryTree;

namespace Tests.Binary_Tree.Solve_Problems_Recursively
{
	[TestClass]
	public class TestMaximumDepthofBinaryTree
	{
		[TestMethod]
		public void TestMethod1()
		{
			// Arrange
			MaximumDepthofBinaryTree question = new MaximumDepthofBinaryTree();
			TreeNode root = new TreeNode(3);
			root.left = new TreeNode(9);
			root.right = new TreeNode(20);
			root.right.left = new TreeNode(15);
			root.right.right = new TreeNode(7);
			int expected = 3;

			// Act
			int actual = question.MaxDepth(root);

			// Assert
			Assert.AreEqual(expected, actual);
		}

		[DataTestMethod]
		public void TestMethod2()
		{
			// Arrange
			MaximumDepthofBinaryTree question = new MaximumDepthofBinaryTree();
			int expected = 0;

			// Act
			int actual = question.MaxDepth(null);

			// Assert
			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void TestMethod3()
		{
			// Arrange
			MaximumDepthofBinaryTree question = new MaximumDepthofBinaryTree();
			TreeNode root = new TreeNode(3);
			int expected = 1;

			// Act
			int actual = question.MaxDepth(root);

			// Assert
			Assert.AreEqual(expected, actual);
		}
	}
}
