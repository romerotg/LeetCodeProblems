namespace LeetCodeProblems.Linked_List.Two_Pointer_Technique
{
	public class LinkedListCycleII
	{
		public class ListNode
		{
			public int val;
			public ListNode next;

			public ListNode(int x)
			{
				val = x;
				next = null;
			}
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

		public ListNode DetectCycle2(ListNode head)
		{
			if (head == null || head.next == null) { return null; }

			var slow = head;
			var fast = head;

			do
			{
				fast = fast.next.next;
				slow = slow.next;
			} while (fast != null && fast.next != null && fast != slow);

			if (fast == null || fast.next == null)
			{
				// no cycle 
				return null;
			}

			slow = head;
			while (slow != fast)
			{
				slow = slow.next;
				fast = fast.next;
			}

			return slow;
		}
	}
}
