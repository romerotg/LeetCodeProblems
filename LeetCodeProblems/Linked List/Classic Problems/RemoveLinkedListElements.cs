namespace LeetCodeProblems.Linked_List.Classic_Problems
{
	public class RemoveLinkedListElements
	{
		public class ListNode
		{
			public int val;
			public ListNode next;
			public ListNode(int x) { val = x; }
		}

		public ListNode RemoveElements(ListNode head, int val)
		{
			if (head == null)
				return null;

			ListNode node = head;
			ListNode previousNode = null;

			while (node != null)
			{
				if (node.val == val)
				{
					if (previousNode == null)
						head = node.next;
					else
						previousNode.next = node.next;

				}
				else
					previousNode = node;

				node = node.next;
			}

			return head;
		}
	}
}
