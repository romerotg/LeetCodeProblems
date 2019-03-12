namespace LeetCodeProblems.Recursion_I.Conclusion
{
	public class ListNode
	{
		public int val;
		public ListNode next;
		public ListNode(int x) { val = x; }
	}

	public class MergeTwoSortedLists
	{
		public ListNode MergeTwoLists(ListNode l1, ListNode l2)
		{
			if (l1 == null)
				return l2;
			if (l2 == null)
				return l1;

			ListNode node;
			if (l1.val <= l2.val)
			{
				node = new ListNode(l1.val);
				node.next = MergeTwoLists(l1.next, l2);
			}
			else
			{
				node = new ListNode(l2.val);
				node.next = MergeTwoLists(l1, l2.next);
			}

			return node;
		}
	}
}
