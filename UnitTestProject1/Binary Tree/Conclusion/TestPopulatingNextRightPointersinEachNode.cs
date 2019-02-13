using LeetCodeProblems.Binary_Tree.Conclusion;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using static LeetCodeProblems.Binary_Tree.Conclusion.PopulatingNextRightPointersinEachNode;

namespace UnitTestProject1.Binary_Tree.Conclusion
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
	}
}
