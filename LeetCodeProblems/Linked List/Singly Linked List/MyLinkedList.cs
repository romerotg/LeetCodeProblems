namespace LeetCodeProblems.Linked_List.Singly_Linked_List
{
	public class MyLinkedList
	{
		/** Initialize your data structure here. */
		public MyLinkedList()
		{
			_Head = null;
			_Tail = null;
			_Count = 0;
		}

		private Node _Head;
		private Node _Tail;
		private int _Count;

		/** Get the value of the index-th node in the linked list. If the index is invalid, return -1. */
		public int Get(int index)
		{
			if (index == _Count - 1)
				return _Tail.Val;
			else if (index < _Count)
			{
				if (_Head != null)
				{
					int i = 0;
					Node node = _Head;

					while (node != null)
					{
						if (i == index)
							return node.Val;

						node = node.Next;
						i++;
					}
				}
			}

			return -1;
		}

		/** Add a node of value val before the first element of the linked list. After the insertion, the new node will be the first node of the linked list. */
		public void AddAtHead(int val)
		{
			Node node = new Node(val);
			node.Next = _Head;
			_Head = node;
			if (_Tail == null)
				_Tail = node;
			_Count++;
		}

		/** Append a node of value val to the last element of the linked list. */
		public void AddAtTail(int val)
		{
			if (_Tail == null)
				AddAtHead(val);
			else
			{
				_Tail.Next = new Node(val);
				_Tail = _Tail.Next;
				_Count++;
			}

		}

		/** Add a node of value val before the index-th node in the linked list. If index equals to the length of linked list, the node will be appended to the end of linked list. If index is greater than the length, the node will not be inserted. */
		public void AddAtIndex(int index, int val)
		{
			if (index == 0)
				AddAtHead(val);
			else if (index == _Count)
			{
				Node newNode = new Node(val);
				_Tail.Next = newNode;
				_Tail = newNode;
				_Count++;
			}
			else
			{

				if (_Head != null)
				{
					int i = 0;
					Node node = _Head;

					while (node.Next != null)
					{
						i++;

						if (i == index)
						{
							Node newNode = new Node(val);
							newNode.Next = node.Next;
							node.Next = newNode;
							_Count++;
							break;
						}

						node = node.Next;
					}
				}
			}
		}

		/** Delete the index-th node in the linked list, if the index is valid. */
		public void DeleteAtIndex(int index)
		{
			if (index == 0)
			{
				if (_Head != null)
				{
					_Head = _Head.Next;
					_Count--;
				}
			}
			else
			{
				if (_Head != null)
				{
					int i = 0;
					Node node = _Head;

					while (node.Next != null)
					{
						i++;

						if (i == index)
						{
							node.Next = node.Next.Next;
							_Count--;
							if (i == _Count)
								_Tail = node;
							break;
						}

						node = node.Next;
					}
				}
			}
		}

		private class Node
		{
			public int Val { get; set; }
			public Node Next { get; set; }

			public Node(int val)
			{
				Val = val;
			}
		}
	}
}
