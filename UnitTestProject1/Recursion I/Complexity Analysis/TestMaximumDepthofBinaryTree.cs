using LeetCodeProblems.Recursion_I.Complexity_Analysis;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests.Recursion_I.Complexity_Analysis
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
	}
}
