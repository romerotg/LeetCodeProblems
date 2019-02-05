using System.Collections.Generic;

namespace LeetCodeProblems.Hash_Table.Conclusion
{
	public class FourSumII
	{
		public int FourSumCount(int[] A, int[] B, int[] C, int[] D)
		{
			if (A == null || B == null || C == null || D == null)
				return 0;
			if (A.Length == 0 || B.Length == 0 || C.Length == 0 || D.Length == 0)
				return 0;

			Dictionary<int, int> sumsAB = new Dictionary<int, int>();
			Dictionary<int, int> sumsCD = new Dictionary<int, int>();

			for (int i = 0; i < A.Length; i++)
			{
				for (int j = 0; j < B.Length; j++)
				{
					int sumAB = A[i] + B[j];
					if (sumsAB.ContainsKey(sumAB))
						sumsAB[sumAB]++;
					else
						sumsAB.Add(sumAB, 1);

					int sumCD = C[i] + D[j];
					if (sumsCD.ContainsKey(sumCD))
						sumsCD[sumCD]++;
					else
						sumsCD.Add(sumCD, 1);
				}
			}

			int result = 0;
			int target = 0;

			foreach (var sumAB in sumsAB)
			{
				int expected = target - sumAB.Key;

				if (sumsCD.TryGetValue(expected, out var sumCD))
					result += sumAB.Value * sumCD;
			}

			return result;
		}
	}
}
