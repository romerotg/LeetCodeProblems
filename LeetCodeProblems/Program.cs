using LeetCodeProblems.Linked_List.Singly_Linked_List;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems
{
	class Program
	{
		static void Main(string[] args)
		{
			MyLinkedList linkedList = new MyLinkedList();
			linkedList.AddAtHead(7);
			linkedList.AddAtTail(7);
			linkedList.AddAtHead(9);
			linkedList.AddAtTail(8);
			linkedList.AddAtHead(6);
			linkedList.AddAtHead(0);
			int val1 = linkedList.Get(5);
			linkedList.AddAtHead(0);
			int val2 = linkedList.Get(2);
			int val3 = linkedList.Get(5);
			linkedList.AddAtTail(4);
			Console.ReadKey();
		}
	}
}
