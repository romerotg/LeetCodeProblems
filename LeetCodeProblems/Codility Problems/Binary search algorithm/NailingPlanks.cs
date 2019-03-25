using System.Collections.Generic;

namespace LeetCodeProblems.Codility_Problems.Binary_search_algorithm
{
	public class NailingPlanks
	{
		public int solution(int[] A, int[] B, int[] C)
		{
			int left = 0;
			int right = C.Length - 1;

			int lastValid = -1;
			while (left <= right)
			{
				int middle = left + (right - left) / 2;

				if (_AllNailed(A, B, C, middle + 1))
				{
					right = middle - 1;
					lastValid = middle + 1;
				}
				else
					left = middle + 1;
			}

			return lastValid;
		}

		private bool _AllNailed(int[] A, int[] B, int[] C, int J)
		{
			HashSet<int> nailed = new HashSet<int>();

			for (int i = 0; i < J; i++)
			{
				for (int j = 0; j < A.Length; j++)
				{
					if (A[j] <= C[i] && C[i] <= B[j])
					{
						nailed.Add(j);
						if (nailed.Count == A.Length)
							return true;
					}
				}
			}

			return false;
		}
	}
}
