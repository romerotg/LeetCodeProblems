using System.Linq;

namespace LeetCodeProblems.Codility_Problems.Binary_search_algorithm
{
	public class MinMaxDivision
	{
		public int solution(int K, int M, int[] A)
		{
			int left = A.Max();
			int right = A.Sum();

			if (K == 1)
				return right;
			if (K >= A.Length)
				return left;

			while (left <= right)
			{
				int middle = left + (right - left) / 2;

				if (_IsBlockSizeValid(A, K, middle))
					right = middle - 1;
				else
					left = middle + 1;
			}

			return left;
		}

		private bool _IsBlockSizeValid(int[] A, int K, int blockSize)
		{
			int blockSum = 0;
			int blockCount = 0;

			foreach (int a in A)
			{
				if (blockSum + a > blockSize)
				{
					blockSum = a;
					blockCount++;
				}
				else
					blockSum += a;

				if (blockCount >= K)
					return false;
			}

			return true;
		}
	}
}
