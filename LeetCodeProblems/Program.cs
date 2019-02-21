using LeetCodeProblems.Queue_and_Stack.Stack_and_DFS;
using System;
using System.Collections.Generic;
using static LeetCodeProblems.Queue_and_Stack.Stack_and_DFS.CloneGraphQ;

namespace LeetCodeProblems
{
	class Program
	{
		static void Main(string[] args)
		{
			UndirectedGraphNode node = new UndirectedGraphNode(0);
			node.neighbors = new List<UndirectedGraphNode>() { node, node };
			CloneGraphQ question = new CloneGraphQ();
			UndirectedGraphNode clone = question.CloneGraph(node);
			Console.ReadKey();
		}
	}
}
