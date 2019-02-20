using LeetCodeProblems.Linked_List.Classic_Problems;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using static LeetCodeProblems.Linked_List.Classic_Problems.PalindromeLinkedList;

namespace Tests.Linked_List.Classic_Prolems
{
	[TestClass]
	public class TestPalindromeLinkedList
	{
		[DataRow(new int[] { 1, 2, 3 }, false)]
		[DataRow(new int[] { 1, 2 }, false)]
		[DataRow(new int[] { 1, 2, 2, 1 }, true)]
		[DataRow(new int[] { 1, 2, 2, 1, 2 }, false)]
		[DataRow(new int[] { 1, 2, 2, 1, 2, 2, 1 }, true)]
		[DataRow(new int[] { 1, 1 }, true)]
		[DataRow(null, true)]
		[DataTestMethod]
		public void TestMethod1(int[] head, bool expected)
		{
			// Arrange
			PalindromeLinkedList question = new PalindromeLinkedList();
			ListNode headNode = null;
			if (head != null && head.Length > 0)
			{
				headNode = new ListNode(head[0]);
				ListNode node = headNode;

				for (int i = 1; i < head.Length; i++)
				{
					node.next = new ListNode(head[i]);
					node = node.next;
				}
			}

			// Act
			bool actual = question.IsPalindrome(headNode);

			// Assert
			Assert.AreEqual(expected, actual);
		}
	}
}
