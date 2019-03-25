using System;

namespace LeetCodeProblems.Codility_Problems.Caterpillar_method
{
	public class CountTriangles
	{
		public int solution(int[] A)
		{
			if (A == null || A.Length < 3)
				return 0;

			Array.Sort(A);
			int result = 0;

			for (int x = 0; x < A.Length; x++)
			{
				int z = x + 2;

				for (int y = x + 1; y < A.Length; y++)
				{
					while (z < A.Length &&
						A[x] + A[y] > A[z] &&
						A[x] + A[z] > A[y] &&
						A[y] + A[z] > A[x])
					{
						z += 1;
					}
					result += z - y - 1;
				}
			}

			return result;
		}
	}
}
