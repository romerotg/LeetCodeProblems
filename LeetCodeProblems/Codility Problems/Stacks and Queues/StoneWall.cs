using System.Collections.Generic;

namespace LeetCodeProblems.Codility_Problems.Stacks_and_Queues
{
	public class StoneWall
	{
		public int solution(int[] H)
		{
			// [8, 8, 5, 7, 9, 8, 7, 4, 8]
			int blocks = 0;

			Queue<int> queue = new Queue<int>();
			foreach (int height in H)
				queue.Enqueue(height);

			blocks = _GetQueueBlocks(queue);

			return blocks;
		}

		private int _GetQueueBlocks(Queue<int> queue)
		{
			int blocks = 0;

			while (queue.Count > 0)
			{
				int height = queue.Dequeue();

				if (height > 0)
					blocks++;

				Queue<int> subQueue = new Queue<int>();

				while (queue.Count > 0 && queue.Peek() >= height)
					subQueue.Enqueue(queue.Dequeue() - height);

				blocks += _GetQueueBlocks(subQueue);
			}

			return blocks;
		}
	}
}
