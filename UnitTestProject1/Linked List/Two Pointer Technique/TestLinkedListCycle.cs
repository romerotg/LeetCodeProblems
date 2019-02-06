using LeetCodeProblems.Linked_List.Two_Pointer_Technique;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using static LeetCodeProblems.Linked_List.Two_Pointer_Technique.LinkedListCycle;

namespace UnitTestProject1.Linked_List.Two_Pointer_Technique
{
	[TestClass]
	public class TestLinkedListCycle
	{
		[DataRow(new int[] { 3, 2, 0, -4 }, 1, true)]
		[DataRow(new int[] { 1, 2 }, 0, true)]
		[DataRow(new int[] { 1 }, -1, false)]
		[DataRow(new int[] { }, -1, false)]
		[DataTestMethod]
		public void TestMethod1(int[] head, int pos, bool expected)
		{
			// Arrange
			LinkedListCycle question = new LinkedListCycle();
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
			bool actual = question.HasCycle(headNode);

			// Assert
			Assert.AreEqual(expected, actual);
		}
	}
}
