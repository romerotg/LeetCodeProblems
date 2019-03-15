using System.Collections.Generic;
using System.Linq;

namespace LeetCodeProblems.Codility_Problems.Time_Complexity
{
	public class PermMissingElem
	{
		public int solution(int[] A)
		{
			if (A == null || A.Length == 0)
				return 1;

			int sum = 0;
			foreach (int num in A)
				sum += num;

			int expectedSum = (A.Length + 1) * (A.Length + 2) / 2;

			return expectedSum - sum;
		}
	}
}
