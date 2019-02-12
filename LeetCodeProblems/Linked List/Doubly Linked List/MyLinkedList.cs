using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.Linked_List.Doubly_Linked_List
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
			if (index < 0 || index >= _Count)
				return -1;

			Node node = _Head;
			int currentIndex = 0;
			while (node != null)
			{
				if (currentIndex++ == index)
					return node.Val;

				node = node.Next;
			}

			return -1;
		}

		/** Add a node of value val before the first element of the linked list. After the insertion, the new node will be the first node of the linked list. */
		public void AddAtHead(int val)
		{
			Node node = new Node(val);
			if (_Head == null)
				_Head = _Tail = node;
			else
			{
				node.Next = _Head;
				_Head.Prev = node;
				_Head = node;
			}
			_Count++;
		}

		/** Append a node of value val to the last element of the linked list. */
		public void AddAtTail(int val)
		{
			Node node = new Node(val);
			if (_Tail == null)
				_Tail = _Head = node;
			else
			{
				node.Prev = _Tail;
				_Tail.Next = node;
				_Tail = node;
			}
			_Count++;
		}

		/** Add a node of value val before the index-th node in the linked list. If index equals to the length of linked list, the node will be appended to the end of linked list. If index is greater than the length, the node will not be inserted. */
		public void AddAtIndex(int index, int val)
		{
			if (index == 0)
				AddAtHead(val);
			else if (index == _Count)
				AddAtTail(val);
			else if (index > 0 && index < _Count)
			{
				Node newNode = new Node(val);
				Node node = _Head;
				int currentIndex = 0;
				while (node != null)
				{
					if (currentIndex++ == index)
					{
						newNode.Next = node;
						newNode.Prev = node.Prev;
						newNode.Prev.Next = newNode;
						newNode.Next.Prev = newNode;
						_Count++;
						break;
					}
					node = node.Next;
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
					if (_Count == 1)
						_Head = _Tail = null;
					else
					{
						_Head = _Head.Next;
						if (_Head != null)
							_Head.Prev = null;
					}
					_Count--;
				}
			}
			else if (index == _Count - 1)
			{
				_Tail = _Tail.Prev;
				_Tail.Next = null;
				_Count--;
			}
			else if (index > 0 && index < _Count)
			{
				Node node = _Head;
				int currentIndex = 0;
				while (node != null)
				{
					if (currentIndex++ == index)
					{
						node.Prev.Next = node.Next;
						node.Next.Prev = node.Prev;
						_Count--;
						break;
					}
					node = node.Next;
				}
			}
		}

		private class Node
		{
			public Node Prev, Next;
			public int Val;

			public Node(int val)
			{
				Val = val;
			}
		}
	}
}
