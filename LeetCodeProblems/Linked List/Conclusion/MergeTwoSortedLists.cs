using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.Linked_List.Conclusion
{
	public class MergeTwoSortedLists
	{
		public ListNode MergeTwoLists(ListNode l1, ListNode l2)
		{
			if (l1 == null)
				return l2;
			if (l2 == null)
				return l1;

			ListNode currentNode = null;
			ListNode result = null;

			while (l1 != null || l2 != null)
			{
				if (currentNode == null)
				{
					if (l1.val <= l2.val)
					{
						result = currentNode = l1;
						l1 = l1.next;
					}
					else
					{
						result = currentNode = l2;
						l2 = l2.next;
					}
				}
				else
				{
					if (l1 == null)
					{
						currentNode.next = l2;
						break;
					}
					if (l2 == null)
					{
						currentNode.next = l1;
						break;
					}

					if (l1.val <= l2.val)
					{
						currentNode.next = l1;
						l1 = l1.next;
					}
					else
					{
						currentNode.next = l2;
						l2 = l2.next;
					}
					currentNode = currentNode.next;
				}
			}

			return result;
		}

		public class ListNode
		{
			public int val;
			public ListNode next;
			public ListNode(int x) { val = x; }
		}
	}
}
