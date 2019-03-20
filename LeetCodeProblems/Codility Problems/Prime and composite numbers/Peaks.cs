using System.Collections.Generic;

namespace LeetCodeProblems.Codility_Problems.Prime_and_composite_numbers
{
	public class Peaks
	{
		public int solution(int[] A)
		{
			if (A == null || A.Length < 3)
				return 0;

			HashSet<int> peaks = _FindPeaks(A);
			if (peaks.Count == 0)
				return 0;

			List<int> divisors = _FindDivisors(A.Length);

			int result = 0;
			for (int i = divisors.Count - 1; i >= 0; i--)
			{
				int divisor = divisors[i];
				int blockSize = A.Length / divisor;
				int peakCount = 0;

				for (int j = 0; j < divisor; j++)
				{
					peakCount = 0;

					int index = j * blockSize;

					for (int k = 0; k < blockSize; k++)
					{
						if (peaks.Contains(index))
							peakCount++;

						index++;
					}

					if (peakCount == 0)
						break;
				}

				if (peakCount > 0)
					return divisor;
			}

			return result;
		}

		private HashSet<int> _FindPeaks(int[] A)
		{
			HashSet<int> peaks = new HashSet<int>();

			for (int i = 1; i < A.Length - 1; i++)
			{
				if (A[i] > A[i - 1] && A[i] > A[i + 1])
					peaks.Add(i);
			}

			return peaks;
		}

		private List<int> _FindDivisors(int N)
		{
			List<int> divisors = new List<int>();

			int i = 1;
			while (i * i <= N)
			{
				if (N % i == 0)
					divisors.Add(i);
				i++;
			}

			for (int j = divisors.Count - 1; j >= 0; j--)
				divisors.Add(N / divisors[j]);

			return divisors;
		}
	}
}
