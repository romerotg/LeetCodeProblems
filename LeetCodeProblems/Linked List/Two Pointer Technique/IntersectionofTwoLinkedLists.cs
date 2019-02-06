namespace LeetCodeProblems.Linked_List.Two_Pointer_Technique
{
	public class IntersectionofTwoLinkedLists
	{
		public class ListNode
		{
			public int val;
			public ListNode next;
			public ListNode(int x) { val = x; }
		}

		public ListNode GetIntersectionNode(ListNode headA, ListNode headB)
		{
			ListNode nodeA = headA;

			while (nodeA != null)
			{
				ListNode nodeB = headB;

				while (nodeB != null)
				{
					if (nodeA == nodeB)
						return nodeA;

					nodeB = nodeB.next;
				}

				nodeA = nodeA.next;
			}

			return null;
		}

		public ListNode GetIntersectionNode2(ListNode headA, ListNode headB)
		{
			if (headA == null || headB == null)
				return null;

			ListNode nodeA = headA;

			while (nodeA.next != null)
				nodeA = nodeA.next;

			nodeA.next = headA;

			ListNode result = DetectCycle(headB);

			nodeA.next = null;

			return result;
		}

		public ListNode DetectCycle(ListNode head)
		{
			ListNode node1 = head;
			ListNode node2 = head;

			bool hasCycle = false;

			while (node2 != null && node2.next != null)
			{
				node1 = node1.next;
				node2 = node2.next.next;

				if (node1.Equals(node2))
				{
					hasCycle = true;
					break;
				}
			}

			if (hasCycle)
			{
				node1 = head;
				while (!node1.Equals(node2))
				{
					node1 = node1.next;
					node2 = node2.next;
				}
				return node1;
			}

			return null;
		}
	}
}
