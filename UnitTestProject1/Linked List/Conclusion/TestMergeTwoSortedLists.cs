using LeetCodeProblems.Linked_List.Conclusion;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using static LeetCodeProblems.Linked_List.Conclusion.MergeTwoSortedLists;

namespace Tests.Linked_List.Conclusion
{
	[TestClass]
	public class TestMergeTwoSortedLists
	{
		[DataRow(new int[] { 1, 2, 4 }, new int[] { 1, 3, 4 }, new int[] { 1, 1, 2, 3, 4, 4 })]
		[DataRow(new int[] { 1, 2, 4 }, null, new int[] { 1, 2, 4 })]
		[DataRow(null, new int[] { 1, 3, 4 }, new int[] { 1, 3, 4 })]
		[DataRow(null, null, null)]
		[DataTestMethod]
		public void TestMethod1(int[] headL1, int[] headL2, int[] expected)
		{
			// Arrange
			MergeTwoSortedLists question = new MergeTwoSortedLists();
			ListNode l1 = null;
			if (headL1 != null && headL1.Length > 0)
			{
				l1 = new ListNode(headL1[0]);
				ListNode node = l1;

				for (int i = 1; i < headL1.Length; i++)
				{
					node.next = new ListNode(headL1[i]);
					node = node.next;
				}
			}
			ListNode l2 = null;
			if (headL2 != null && headL2.Length > 0)
			{
				l2 = new ListNode(headL2[0]);
				ListNode node = l2;

				for (int i = 1; i < headL2.Length; i++)
				{
					node.next = new ListNode(headL2[i]);
					node = node.next;
				}
			}

			// Act
			ListNode actual = question.MergeTwoLists(l1, l2);
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
