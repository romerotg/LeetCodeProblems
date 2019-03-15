namespace LeetCodeProblems.Codility_Problems.Prefix_Sums
{
	public class GenomicRangeQuery
	{
		public int[] solution(string S, int[] P, int[] Q)
		{
			int[] result = new int[P.Length];
			int[,] dnaCount = new int[S.Length, 4];

			for (int i = 0; i < S.Length; i++)
			{
				switch (S[i])
				{
					case 'A':
						dnaCount[i, 0] = 1;
						break;
					case 'C':
						dnaCount[i, 1] = 1;
						break;
					case 'G':
						dnaCount[i, 2] = 1;
						break;
					case 'T':
						dnaCount[i, 3] = 1;
						break;
				}

				if (i > 0)
				{
					for (int j = 0; j < 4; j++)
						dnaCount[i, j] += dnaCount[i - 1, j];
				}
			}

			for (int i = 0; i < result.Length; i++)
			{
				int x = P[i];
				int y = Q[i];

				for (int j = 0; j < 4; j++)
				{
					int sub = x > 0 ? dnaCount[x - 1, j] : 0;
					if (dnaCount[y, j] - sub > 0)
					{
						result[i] = j + 1;
						break;
					}
				}
			}

			return result;
		}
	}
}
