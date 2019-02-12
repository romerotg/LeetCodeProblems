namespace LeetCodeProblems.Linked_List.Conclusion
{
	public class AddTwoNumbersQ
	{
		public class ListNode
		{
			public int val;
			public ListNode next;
			public ListNode(int x) { val = x; }
		}

		public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
		{
			if (l1 == null)
				return l2;
			if (l2 == null)
				return l1;

			ListNode result = null;
			ListNode node = null;
			bool carry = false;

			while (l1 != null || l2 != null)
			{
				int sum = 0;

				if (l1 != null)
				{
					sum += l1.val;
					l1 = l1.next;
				}

				if (l2 != null)
				{
					sum += l2.val;
					l2 = l2.next;
				}

				if (carry)
					sum += 1;

				carry = sum >= 10;

				ListNode newNode = new ListNode(sum % 10);
				if (node == null)
					result = node = newNode;
				else
				{
					node.next = newNode;
					node = newNode;
				}
			}

			if (carry)
				node.next = new ListNode(1);

			return result;
		}
	}
}
