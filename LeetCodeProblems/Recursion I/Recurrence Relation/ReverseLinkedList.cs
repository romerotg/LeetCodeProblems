namespace LeetCodeProblems.Recursion_I.Recurrence_Relation
{
	public class ListNode
	{
		public int val;
		public ListNode next;
		public ListNode(int x) { val = x; }
	}

	public class ReverseLinkedList
	{
		public ListNode ReverseList(ListNode head)
		{
			return _ReverseList(head, head);
		}

		private ListNode _ReverseList(ListNode originalHead, ListNode currentHead)
		{
			if (originalHead == null || originalHead.next == null)
				return currentHead;

			ListNode next = originalHead.next;
			originalHead.next = next.next;
			next.next = currentHead;

			return _ReverseList(originalHead, next);
		}
	}
}
