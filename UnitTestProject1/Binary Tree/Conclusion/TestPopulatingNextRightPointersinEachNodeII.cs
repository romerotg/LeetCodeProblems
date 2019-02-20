using LeetCodeProblems.Binary_Tree.Conclusion;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using static LeetCodeProblems.Binary_Tree.Conclusion.PopulatingNextRightPointersinEachNodeII;

namespace Tests.Binary_Tree.Conclusion
{
	[TestClass]
	public class TestPopulatingNextRightPointersinEachNodeII
	{
		[TestMethod]
		public void TestMethod1()
		{
			// Arrange
			PopulatingNextRightPointersinEachNodeII question = new PopulatingNextRightPointersinEachNodeII();
			TreeLinkNode root = new TreeLinkNode(1);
			root.left = new TreeLinkNode(2);
			root.left.left = new TreeLinkNode(3);
			root.left.left.left = new TreeLinkNode(4);
			root.right = new TreeLinkNode(5);

			// Act
			question.Connect(root);
		}
	}
}
