namespace LeetCodeProblems.Recursion_I.Principle_of_Recursion
{
	public class ListNode
	{
		public int val;
		public ListNode next;
		public ListNode(int x) { val = x; }
	}

	public class SwapNodesinPairs
	{
		public ListNode SwapPairs(ListNode head)
		{
			if (head == null || head.next == null)
				return head;

			ListNode next = head.next;
			head.next = SwapPairs(next.next);
			next.next = head;

			return next;
		}
	}
}
