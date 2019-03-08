using LeetCodeProblems.Recursion_I.Principle_of_Recursion;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Tests.Recursion_I.Principle_of_Recursion
{
	[TestClass]
	public class TestSwapNodesinPairs
	{
		[DataRow(null, null)]
		[DataRow(new int[] { 1 }, new int[] { 1 })]
		[DataRow(new int[] { 1, 2 }, new int[] { 2, 1 })]
		[DataRow(new int[] { 1, 2, 3 }, new int[] { 2, 1, 3 })]
		[DataRow(new int[] { 1, 2, 3, 4 }, new int[] { 2, 1, 4, 3 })]
		[DataTestMethod]
		public void TestMethod1(int[] head, int[] expected)
		{
			// Arrange
			SwapNodesinPairs question = new SwapNodesinPairs();
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
			ListNode actual = question.SwapPairs(headNode);
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
