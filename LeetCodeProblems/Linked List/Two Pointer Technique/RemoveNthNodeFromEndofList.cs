namespace LeetCodeProblems.Linked_List.Two_Pointer_Technique
{
	public class RemoveNthNodeFromEndofList
	{
		public class ListNode
		{
			public int val;
			public ListNode next;
			public ListNode(int x) { val = x; }
		}

		public ListNode RemoveNthFromEnd(ListNode head, int n)
		{
			if (head == null)
				return null;

			ListNode node = head;
			ListNode beforeRemoved = null;
			int index = 0;

			while (node != null)
			{
				if (index - n == 0)
					beforeRemoved = head;
				else if (index - n > 0)
					beforeRemoved = beforeRemoved.next;

				node = node.next;
				index++;
			}

			if (beforeRemoved != null)
				beforeRemoved.next = beforeRemoved.next.next;
			else
				head = head.next;

			return head;
		}
	}
}
