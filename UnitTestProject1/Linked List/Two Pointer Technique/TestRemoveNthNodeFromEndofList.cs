using LeetCodeProblems.Linked_List.Two_Pointer_Technique;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using static LeetCodeProblems.Linked_List.Two_Pointer_Technique.RemoveNthNodeFromEndofList;

namespace Tests.Linked_List.Two_Pointer_Technique
{
	[TestClass]
	public class TestRemoveNthNodeFromEndofList
	{
		[DataRow(new int[] { 1, 2, 3, 4, 5 }, 2, new int[] { 1, 2, 3, 5 })]
		[DataRow(new int[] { 1 }, 1, null)]
		[DataRow(new int[] { 1, 2 }, 2, new int[] { 2 })]
		[DataRow(new int[] { 1, 2 }, 1, new int[] { 1 })]
		[DataTestMethod]
		public void TestMethod1(int[] head, int n, int[] expected)
		{
			// Arrange
			RemoveNthNodeFromEndofList question = new RemoveNthNodeFromEndofList();
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
			ListNode actual = question.RemoveNthFromEnd(headNode, n);
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
