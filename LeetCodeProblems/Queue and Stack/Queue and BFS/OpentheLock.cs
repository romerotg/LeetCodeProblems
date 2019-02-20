using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.Queue_and_Stack.Queue_and_BFS
{
	public class OpentheLock
	{
		public int OpenLock(string[] deadends, string target)
		{
			HashSet<string> deadendsHash = new HashSet<string>(deadends);

			if (deadendsHash.Contains("0000"))
				return -1;

			Queue<string> queue = new Queue<string>();
			queue.Enqueue("0000");
			deadendsHash.Add("0000");
			int turns = 0;

			while (queue.Count > 0)
			{
				int size = queue.Count;

				for (int i = 0; i < size; i++)
				{
					string current = queue.Dequeue();

					if (current == target)
						return turns;

					StringBuilder sb = new StringBuilder();
					string next = null;

					for (int j = 0; j < current.Length; j++)
					{
						char c = current[j];
						sb.Clear();
						sb.Append(current);
						sb[j] = c == '9' ? '0' : (char)(c + 1);
						next = sb.ToString();
						if (!deadendsHash.Contains(next))
						{
							deadendsHash.Add(next);
							queue.Enqueue(next);
						}
						sb.Clear();
						sb.Append(current);
						sb[j] = c == '0' ? '9' : (char)(c - 1);
						next = sb.ToString();
						if (!deadendsHash.Contains(next))
						{
							deadendsHash.Add(next);
							queue.Enqueue(next);
						}
					}
				}

				turns++;
			}

			return -1;
		}
	}
}
