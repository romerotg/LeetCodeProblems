using LeetCodeProblems.Linked_List.Conclusion;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using static LeetCodeProblems.Linked_List.Conclusion.AddTwoNumbersQ;

namespace Tests.Linked_List.Conclusion
{
	[TestClass]
	public class TestAddTwoNumbersQ
	{
		[DataRow(new int[] { 2, 4, 3 }, new int[] { 5, 6, 4 }, new int[] { 7, 0, 8 })]
		[DataRow(new int[] { 0 }, new int[] { 1, 1, 1 }, new int[] { 1, 1, 1 })]
		[DataRow(new int[] { 1, 1, 1 }, new int[] { 0 }, new int[] { 1, 1, 1 })]
		[DataRow(null, new int[] { 1, 1, 1 }, new int[] { 1, 1, 1 })]
		[DataRow(new int[] { 1, 1, 1 }, null, new int[] { 1, 1, 1 })]
		[DataRow(new int[] { 1 }, new int[] { 9, 9, 9 }, new int[] { 0, 0, 0, 1 })]
		[DataRow(new int[] { 9, 9, 9 }, new int[] { 1 }, new int[] { 0, 0, 0, 1 })]
		[DataRow(null, null, null)]
		[DataTestMethod]
		public void TestMethod1(int[] headL1, int[] headL2, int[] expected)
		{
			// Arrange
			AddTwoNumbersQ question = new AddTwoNumbersQ();
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
			ListNode actual = question.AddTwoNumbers(l1, l2);
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
