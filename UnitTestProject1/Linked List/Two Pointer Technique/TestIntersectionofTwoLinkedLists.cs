using LeetCodeProblems.Linked_List.Two_Pointer_Technique;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using static LeetCodeProblems.Linked_List.Two_Pointer_Technique.IntersectionofTwoLinkedLists;

namespace UnitTestProject1.Linked_List.Two_Pointer_Technique
{
	[TestClass]
	public class TestIntersectionofTwoLinkedLists
	{
		[DataRow(8, new int[] { 4, 1, 8, 4, 5 }, new int[] { 5, 0, 1, 8, 4, 5 }, 2, 3, 8)]
		[DataRow(2, new int[] { 0, 9, 1, 2, 4 }, new int[] { 3, 2, 4 }, 3, 1, 2)]
		[DataRow(0, new int[] { 2, 6, 4 }, new int[] { 1, 5 }, 3, 2, -1)]
		[DataRow(0, new int[] { }, new int[] { }, 0, 0, -1)]
		[DataTestMethod]
		public void TestMethod1(int intersectVal, int[] listA, int[] listB, int skipA, int skipB, int expected)
		{
			// Arrange
			IntersectionofTwoLinkedLists question = new IntersectionofTwoLinkedLists();

			ListNode headA = null;
			ListNode headB = null;

			if (intersectVal == 0)
			{
				if (listA != null && listA.Length > 0)
				{
					headA = new ListNode(listA[0]);
					ListNode node = headA;

					for (int i = 1; i < listA.Length; i++)
					{
						node.next = new ListNode(listA[i]);
						node = node.next;
					}
				}

				if (listB != null && listB.Length > 0)
				{
					headB = new ListNode(listB[0]);
					ListNode node = headB;

					for (int i = 1; i < listB.Length; i++)
					{
						node.next = new ListNode(listB[i]);
						node = node.next;
					}
				}
			}
			else
			{
				ListNode intersectionHead = null;

				if (listA != null && listA.Length > 0)
				{
					headA = new ListNode(listA[0]);
					ListNode node = headA;

					for (int i = 1; i < listA.Length; i++)
					{
						node.next = new ListNode(listA[i]);
						node = node.next;

						if (i == skipA)
							intersectionHead = node;
					}
				}

				if (listB != null && listB.Length > 0)
				{
					headB = new ListNode(listB[0]);
					ListNode node = headB;

					for (int i = 1; i < skipB && i < listB.Length; i++)
					{
						node.next = new ListNode(listB[i]);
						node = node.next;
					}

					node.next = intersectionHead;
				}
			}

			// Act
			ListNode actual = question.GetIntersectionNode(headA, headB);

			// Assert
			Assert.AreEqual(expected, actual == null ? -1 : actual.val);
		}

		[DataRow(8, new int[] { 4, 1, 8, 4, 5 }, new int[] { 5, 0, 1, 8, 4, 5 }, 2, 3, 8)]
		[DataRow(2, new int[] { 0, 9, 1, 2, 4 }, new int[] { 3, 2, 4 }, 3, 1, 2)]
		[DataRow(0, new int[] { 2, 6, 4 }, new int[] { 1, 5 }, 3, 2, -1)]
		[DataRow(0, new int[] {  }, new int[] {  }, 0, 0, -1)]
		[DataTestMethod]
		public void TestMethod2(int intersectVal, int[] listA, int[] listB, int skipA, int skipB, int expected)
		{
			// Arrange
			IntersectionofTwoLinkedLists question = new IntersectionofTwoLinkedLists();

			ListNode headA = null;
			ListNode headB = null;

			if (intersectVal == 0)
			{
				if (listA != null && listA.Length > 0)
				{
					headA = new ListNode(listA[0]);
					ListNode node = headA;

					for (int i = 1; i < listA.Length; i++)
					{
						node.next = new ListNode(listA[i]);
						node = node.next;
					}
				}

				if (listB != null && listB.Length > 0)
				{
					headB = new ListNode(listB[0]);
					ListNode node = headB;

					for (int i = 1; i < listB.Length; i++)
					{
						node.next = new ListNode(listB[i]);
						node = node.next;
					}
				}
			}
			else
			{
				ListNode intersectionHead = null;

				if (listA != null && listA.Length > 0)
				{
					headA = new ListNode(listA[0]);
					ListNode node = headA;

					for (int i = 1; i < listA.Length; i++)
					{
						node.next = new ListNode(listA[i]);
						node = node.next;

						if (i == skipA)
							intersectionHead = node;
					}
				}

				if (listB != null && listB.Length > 0)
				{
					headB = new ListNode(listB[0]);
					ListNode node = headB;

					for (int i = 1; i < skipB && i < listB.Length; i++)
					{
						node.next = new ListNode(listB[i]);
						node = node.next;
					}

					node.next = intersectionHead;
				}
			}

			// Act
			ListNode actual = question.GetIntersectionNode2(headA, headB);

			// Assert
			Assert.AreEqual(expected, actual == null ? -1 : actual.val);
		}
	}
}
