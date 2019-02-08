namespace LeetCodeProblems.Linked_List.Classic_Prolems
{
	public class ReverseLinkedList
	{
		public class ListNode
		{
			public int val;
			public ListNode next;
			public ListNode(int x) { val = x; }
		}

		public ListNode ReverseList(ListNode head)
		{
			if (head == null)
				return null;

			ListNode node = head;

			while (node.next != null)
			{
				ListNode next = node.next;
				if (next != null)
				{
					node.next = next.next;
					next.next = head;
					head = next;
				}
			}

			return head;
		}
	}
}
