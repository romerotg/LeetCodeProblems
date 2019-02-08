using System.Collections.Generic;

namespace LeetCodeProblems.Linked_List.Classic_Problems
{
	public class PalindromeLinkedList
	{
		public class ListNode
		{
			public int val;
			public ListNode next;
			public ListNode(int x) { val = x; }
		}

		public bool IsPalindrome(ListNode head)
		{
			List<int> list = new List<int>();
			ListNode node = head;
			while (node != null)
			{
				list.Add(node.val);
				node = node.next;
			}

			int i = 0;
			int j = list.Count - 1;

			while (i < j)
			{
				if (list[i] != list[j])
					return false;

				i++;
				j--;
			}

			return true;
		}

		public bool IsPalindrome2(ListNode head)
		{
			ListNode compare = head;
			return _IsPalindrome(head, ref compare);
		}
		private bool _IsPalindrome(ListNode head, ref ListNode compare)
		{
			if (head == null)
				return true;
			else if (!_IsPalindrome(head.next, ref compare))
				return false;

			if (head.val != compare.val)
				return false;

			compare = compare.next;
			return true;
		}
	}
}
