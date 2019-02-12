namespace LeetCodeProblems.Linked_List.Conclusion
{
	public class FlattenaMultilevelDoublyLinkedList
	{
		// Definition for a Node.
		public class Node
		{
			public int val;
			public Node prev;
			public Node next;
			public Node child;

			public Node() { }
			public Node(int _val) { val = _val; }
			public Node(int _val, Node _prev, Node _next, Node _child)
			{
				val = _val;
				prev = _prev;
				next = _next;
				child = _child;
			}
		}

		public Node Flatten(Node head)
		{
			if (head == null)
				return null;

			return _Flatten(head, out Node tail);
		}

		private Node _Flatten(Node head, out Node tail)
		{
			tail = null;

			Node node = head;

			while (node != null)
			{
				Node next = node.next;
				tail = node;

				if (node.child != null)
				{
					node.next = _Flatten(node.child, out Node childTail);
					node.child.prev = node;
					childTail.next = next;
					if (next != null)
						next.prev = childTail;
					node.child = null;
					tail = childTail;
				}

				node = next;
			}

			return head;
		}
	}
}
