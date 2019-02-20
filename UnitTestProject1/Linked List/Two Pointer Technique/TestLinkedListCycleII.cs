using LeetCodeProblems.Linked_List.Two_Pointer_Technique;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using static LeetCodeProblems.Linked_List.Two_Pointer_Technique.LinkedListCycleII;

namespace Tests.Linked_List.Two_Pointer_Technique
{
	[TestClass]
	public class TestLinkedListCycleII
	{
		[DataRow(new int[] { 3, 2, 0, -4 }, 1, 2)]
		[DataRow(new int[] { 1, 2 }, 0, 1)]
		[DataRow(new int[] { 1 }, -1, -1)]
		[DataRow(new int[] { }, -1, -1)]
		[DataRow(new int[] { -1, -7, 7, -4, 19, 6, -9, -5, -2, -5 }, 9, -5)]
		[DataRow(new int[] { -21, 10, 17, 8, 4, 26, 5, 35, 33, -7, -16, 27, -12, 6, 29, -12, 5, 9, 20, 14, 14, 2, 13, -24, 21, 23, -21, 5 }, 24, 21)]
		[DataTestMethod]
		public void TestMethod1(int[] head, int pos, int expected)
		{
			// Arrange
			LinkedListCycleII question = new LinkedListCycleII();
			ListNode headNode = null;
			if (head != null && head.Length > 0)
			{
				headNode = new ListNode(head[0]);
				ListNode node = headNode;
				ListNode cycle = null;
				if (pos == 0)
					cycle = headNode;

				for (int i = 1; i < head.Length; i++)
				{
					node.next = new ListNode(head[i]);
					node = node.next;
					if (pos == i)
						cycle = node;
				}

				node.next = cycle;
			}

			// Act
			ListNode actual = question.DetectCycle(headNode);

			// Assert
			Assert.AreEqual(expected, actual == null ? -1 : actual.val);
		}
	}
}
