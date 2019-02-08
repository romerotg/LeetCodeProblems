using LeetCodeProblems.Linked_List.Classic_Prolems;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using static LeetCodeProblems.Linked_List.Classic_Prolems.ReverseLinkedList;

namespace UnitTestProject1.Linked_List.Classic_Prolems
{
	[TestClass]
	public class TestReverseLinkedList
	{
		[DataRow(new int[] { 1, 2, 3, 4, 5 }, new int[] { 5, 4, 3, 2, 1 })]
		[DataRow(new int[] { 1 }, new int[] { 1 })]
		[DataRow(new int[] { 1, 2 }, new int[] { 2, 1 })]
		[DataRow(null, null)]
		[DataTestMethod]
		public void TestMethod1(int[] head, int[] expected)
		{
			// Arrange
			ReverseLinkedList question = new ReverseLinkedList();
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
			ListNode actual = question.ReverseList(headNode);
			List<int> actualList = null;
			if (actual != null)
			{
				actualList = new List<int>();
				while (actual != null)
				{
					actualList.Add(actual.val);
					actual = actual.next;
				}
			}

			// Assert
			CollectionAssert.AreEqual(expected, actualList?.ToArray());
		}
	}
}
