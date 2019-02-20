using LeetCodeProblems.Linked_List.Classic_Problems;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using static LeetCodeProblems.Linked_List.Classic_Problems.OddEvenLinkedList;

namespace Tests.Linked_List.Classic_Prolems
{
	[TestClass]
	public class TestOddEvenLinkedList
	{
		[DataRow(new int[] { 1, 2, 3 }, new int[] { 1, 3, 2 })]
		[DataRow(new int[] { 1, 2, 3, 4, 5 }, new int[] { 1, 3, 5, 2, 4 })]
		[DataRow(new int[] { 2, 1, 3, 5, 6, 4, 7 }, new int[] { 2, 3, 6, 7, 1, 5, 4 })]
		[DataRow(null, null)]
		[DataTestMethod]
		public void TestMethod1(int[] head, int[] expected)
		{
			// Arrange
			OddEvenLinkedList question = new OddEvenLinkedList();
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
			ListNode actual = question.OddEvenList(headNode);
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
