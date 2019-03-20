using System.Collections.Generic;

namespace LeetCodeProblems.Codility_Problems.Prime_and_composite_numbers
{
	public class Flags
	{
		public int solution(int[] A)
		{
			if (A == null || A.Length < 3)
				return 0;

			List<int> peaks = _FindPeaks(A);

			if (peaks.Count < 2)
				return peaks.Count;

			int result = 0;

			for (int i = 0; i < peaks.Count; i++)
			{
				int flags = i + 1;
				int lastFlagIndex = 0;
				int flagCount = 1;

				for (int j = 1; j < peaks.Count; j++)
				{
					if (peaks[j] - peaks[lastFlagIndex] >= flags)
					{
						flagCount++;
						lastFlagIndex = j;
					}
					if (flagCount == flags)
					{
						result = flags;
						break;
					}
				}
			}

			return result;
		}

		private List<int> _FindPeaks(int[] A)
		{
			List<int> peaks = new List<int>();

			for (int i = 1; i < A.Length - 1; i++)
			{
				if (A[i] > A[i - 1] && A[i] > A[i + 1])
					peaks.Add(i);
			}

			return peaks;
		}
	}
}
