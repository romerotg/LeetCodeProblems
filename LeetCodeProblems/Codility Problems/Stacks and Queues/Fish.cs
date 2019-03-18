using System.Collections.Generic;

namespace LeetCodeProblems.Codility_Problems.Stacks_and_Queues
{
	public class Fish
	{
		public int solution(int[] A, int[] B)
		{
			if (A.Length < 2)
				return A.Length;

			int livingFishes = A.Length;
			Stack<int> downstreamFishes = new Stack<int>();

			for (int i = 0; i < A.Length; i++)
			{
				if (B[i] == 1)
					downstreamFishes.Push(i);
				else
				{
					while (downstreamFishes.Count > 0)
					{
						livingFishes--;
						if (A[downstreamFishes.Peek()] < A[i])
							downstreamFishes.Pop();
						else
							break;
					}
				}
			}

			return livingFishes;
		}
	}
}
