using System;

namespace LeetCodeProblems.Codility_Problems.Prefix_Sums
{
	public class GenomicRangeQuery
	{
		public int[] solution(string S, int[] P, int[] Q)
		{
			int[] dna = new int[S.Length];

			for (int i = 0; i < S.Length; i++)
			{
				switch (S[i])
				{
					case 'A':
						dna[i] = 1;
						break;
					case 'C':
						dna[i] = 2;
						break;
					case 'G':
						dna[i] = 3;
						break;
					case 'T':
						dna[i] = 4;
						break;
				}
			}

			int[] result = new int[P.Length];

			for (int i = 0; i < result.Length; i++)
			{
				int min = int.MaxValue; ;

				for (int j = P[i]; j <= Q[i]; j++)
					min = Math.Min(min, dna[j]);

				result[i] = min;
			}

			return result;
		}
	}
}
