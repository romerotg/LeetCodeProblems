using LeetCodeProblems.Linked_List.Conclusion;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using static LeetCodeProblems.Linked_List.Conclusion.RotateList;

namespace Tests.Linked_List.Conclusion
{
	[TestClass]
	public class TestRotateList
	{
		[DataRow(new int[] { 1, 2, 3, 4, 5 }, 2, new int[] { 4, 5, 1, 2, 3 })]
		[DataRow(new int[] { 0, 1, 2 }, 4, new int[] { 2, 0, 1 })]
		[DataRow(new int[] { 0, 1, 2 }, 0, new int[] { 0, 1, 2 })]
		[DataRow(new int[] { 0, 1, 2 }, 3, new int[] { 0, 1, 2 })]
		[DataRow(new int[] { 0, 1, 2 }, 6, new int[] { 0, 1, 2 })]
		[DataRow(null, null, null)]
		[DataTestMethod]
		public void TestMethod1(int[] head, int k, int[] expected)
		{
			// Arrange
			RotateList question = new RotateList();
			ListNode headList = null;
			if (head != null && head.Length > 0)
			{
				headList = new ListNode(head[0]);
				ListNode node = headList;

				for (int i = 1; i < head.Length; i++)
				{
					node.next = new ListNode(head[i]);
					node = node.next;
				}
			}

			// Act
			ListNode actual = question.RotateRight(headList, k);
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
