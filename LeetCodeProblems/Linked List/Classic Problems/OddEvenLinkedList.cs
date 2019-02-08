namespace LeetCodeProblems.Linked_List.Classic_Problems
{
	public class OddEvenLinkedList
	{
		public class ListNode
		{
			public int val;
			public ListNode next;
			public ListNode(int x) { val = x; }
		}

		public ListNode OddEvenList(ListNode head)
		{
			if (head == null)
				return null;

			ListNode node = head;
			ListNode lastOdd = null;
			ListNode lastEven = null;
			int index = 1;

			while (node != null)
			{
				ListNode next = node.next;

				if (index % 2 == 0)
				{
					if (lastEven == null)
						lastEven = node;
					else
					{
						lastEven.next = node;
						lastEven = node;
					}
				}
				else
				{
					if (lastOdd == null)
						lastOdd = node;
					else
					{
						node.next = lastOdd.next;
						lastOdd.next = node;
						lastOdd = node;
					}
				}

				node = next;
				index++;
			}

			if (lastEven != null)
				lastEven.next = null;

			return head;
		}
	}
}
