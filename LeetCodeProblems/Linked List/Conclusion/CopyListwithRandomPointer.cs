using System.Collections.Generic;

namespace LeetCodeProblems.Linked_List.Conclusion
{
	public class CopyListwithRandomPointer
	{
		public class RandomListNode
		{
			public int label;
			public RandomListNode next, random;
			public RandomListNode(int x) { this.label = x; }
		};

		public RandomListNode CopyRandomList(RandomListNode head)
		{
			if (head == null)
				return null;

			Dictionary<RandomListNode, RandomListNode> hashmap = new Dictionary<RandomListNode, RandomListNode>();
			RandomListNode newHead = null;
			RandomListNode current = null;

			RandomListNode node = head;

			while (node != null)
			{
				RandomListNode newNode = new RandomListNode(node.label);
				hashmap.Add(node, newNode);

				if (newHead == null)
					current = newHead = newNode;
				else
				{
					current.next = newNode;
					current = newNode;
				}

				node = node.next;
			}

			node = head;
			while (node != null)
			{
				if (node.random != null)
				{
					current = hashmap[node];
					current.random = hashmap[node.random];
				}
				node = node.next;
			}

			return newHead;
		}
	}
}
