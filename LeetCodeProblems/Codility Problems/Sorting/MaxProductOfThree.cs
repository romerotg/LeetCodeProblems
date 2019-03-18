using System;

namespace LeetCodeProblems.Codility_Problems.Sorting
{
	public class MaxProductOfThree
	{
		public int solution(int[] A)
		{
			if (A.Length == 3)
				return A[0] * A[1] * A[2];

			Array.Sort(A);

			int lastThree = A[A.Length - 1] * A[A.Length - 2] * A[A.Length - 3];
			int firstTwoLastOne = A[0] * A[1] * A[A.Length - 1];

			return Math.Max(firstTwoLastOne, firstTwoLastOne);
		}
	}
}
