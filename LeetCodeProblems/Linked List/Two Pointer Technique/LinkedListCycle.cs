namespace LeetCodeProblems.Linked_List.Two_Pointer_Technique
{
	public class LinkedListCycle
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

		public bool HasCycle(ListNode head)
		{
			ListNode node1 = head;
			ListNode node2 = head?.next?.next;

			while (node1 != null && node2 != null)
			{
				if (node1.val == node2.val)
					return true;

				node1 = node1.next;
				node2 = node2.next?.next;
			}

			return false;
		}
	}
}
