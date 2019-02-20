using LeetCodeProblems.Linked_List.Classic_Problems;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using static LeetCodeProblems.Linked_List.Classic_Problems.RemoveLinkedListElements;

namespace Tests.Linked_List.Classic_Prolems
{
	[TestClass]
	public class TestRemoveLinkedListElements
	{
		[DataRow(new int[] { 1, 2, 3, 4, 5, 6 }, 6, new int[] { 1, 2, 3, 4, 5 })]
		[DataRow(new int[] { 1, 2, 3, 4, 5, 6 }, 5, new int[] { 1, 2, 3, 4, 6 })]
		[DataRow(new int[] { 1, 2, 3, 4, 5, 6 }, 1, new int[] { 2, 3, 4, 5, 6 })]
		[DataRow(new int[] { 1, 2, 3, 4, 5 }, 7, new int[] { 1, 2, 3, 4, 5 })]
		[DataRow(new int[] { 1 }, 1, null)]
		[DataRow(new int[] { 1 }, 2, new int[] { 1 })]
		[DataRow(new int[] { 1, 1 }, 1, null)]
		[DataTestMethod]
		public void TestMethod1(int[] head, int val, int[] expected)
		{
			// Arrange
			RemoveLinkedListElements question = new RemoveLinkedListElements();
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
			ListNode actual = question.RemoveElements(headNode, val);
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
