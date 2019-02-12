using System.Collections.Generic;

namespace LeetCodeProblems.Linked_List.Conclusion
{
	public class RotateList
	{
		public class ListNode
		{
			public int val;
			public ListNode next;
			public ListNode(int x) { val = x; }
		}

		public ListNode RotateRight(ListNode head, int k)
		{
			if (head == null || k == 0)
				return head;

			ListNode result = null;
			List<ListNode> nodes = new List<ListNode>();

			ListNode node = head;
			while (node != null)
			{
				nodes.Add(node);
				node = node.next;
			}

			int rotations = k % nodes.Count;
			if (rotations == 0)
				result = head;
			else
			{
				result = nodes[nodes.Count - rotations];
				nodes[nodes.Count - rotations - 1].next = null;
				nodes[nodes.Count - 1].next = nodes[0];
			}

			return result;
		}
	}
}
