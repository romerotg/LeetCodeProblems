using LeetCodeProblems.Binary_Tree.Conclusion;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using static LeetCodeProblems.Binary_Tree.Conclusion.PopulatingNextRightPointersinEachNode;

namespace Tests.Binary_Tree.Conclusion
{
	[TestClass]
	public class TestPopulatingNextRightPointersinEachNode
	{
		[TestMethod]
		public void TestMethod1()
		{
			// Arrange
			PopulatingNextRightPointersinEachNode question = new PopulatingNextRightPointersinEachNode();
			TreeLinkNode root = new TreeLinkNode(1);
			root.left = new TreeLinkNode(2);
			root.left.left = new TreeLinkNode(4);
			root.left.right = new TreeLinkNode(5);
			root.right = new TreeLinkNode(3);
			root.right.left = new TreeLinkNode(6);
			root.right.right = new TreeLinkNode(7);

			// Act
			question.Connect(root);
		}

		[TestMethod]
		public void TestMethod2()
		{
			// Arrange
			PopulatingNextRightPointersinEachNode question = new PopulatingNextRightPointersinEachNode();
			TreeLinkNode root = new TreeLinkNode(-1);
			root.left = new TreeLinkNode(0);
			root.left.left = new TreeLinkNode(2);
			root.left.left.left = new TreeLinkNode(6);
			root.left.left.right = new TreeLinkNode(7);
			root.left.right = new TreeLinkNode(3);
			root.left.right.left = new TreeLinkNode(8);
			root.left.right.right = new TreeLinkNode(9);
			root.right = new TreeLinkNode(1);
			root.right.left = new TreeLinkNode(4);
			root.right.left.left = new TreeLinkNode(10);
			root.right.left.right = new TreeLinkNode(11);
			root.right.right = new TreeLinkNode(5);
			root.right.right.left = new TreeLinkNode(12);
			root.right.right.right = new TreeLinkNode(13);

			// Act
			question.Connect(root);
		}
	}
}
