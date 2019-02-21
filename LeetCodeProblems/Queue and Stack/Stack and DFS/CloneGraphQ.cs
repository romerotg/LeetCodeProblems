using System.Collections.Generic;

namespace LeetCodeProblems.Queue_and_Stack.Stack_and_DFS
{
	public class CloneGraphQ
	{
		public class UndirectedGraphNode
		{
			public int label;
			public IList<UndirectedGraphNode> neighbors;
			public UndirectedGraphNode(int x) { label = x; neighbors = new List<UndirectedGraphNode>(); }
		}

		public UndirectedGraphNode CloneGraph(UndirectedGraphNode node)
		{
			if (node == null)
				return null;

			Dictionary<UndirectedGraphNode, UndirectedGraphNode> hashmap = new Dictionary<UndirectedGraphNode, UndirectedGraphNode>();
			return _CloneGraph(node, hashmap);
		}

		private UndirectedGraphNode _CloneGraph(UndirectedGraphNode node, Dictionary<UndirectedGraphNode, UndirectedGraphNode> hashmap)
		{
			if (node == null)
				return null;

			if (!hashmap.TryGetValue(node, out var clone))
			{
				clone = new UndirectedGraphNode(node.label);
				hashmap.Add(node, clone);

				if (node.neighbors != null)
				{
					clone.neighbors = new List<UndirectedGraphNode>();

					foreach (UndirectedGraphNode childNode in node.neighbors)
						clone.neighbors.Add(_CloneGraph(childNode, hashmap));
				}
			}

			return clone;
		}
	}
}
