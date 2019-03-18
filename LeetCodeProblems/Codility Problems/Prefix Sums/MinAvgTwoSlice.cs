namespace LeetCodeProblems.Codility_Problems.Prefix_Sums
{
	public class MinAvgTwoSlice
	{
		public int solution(int[] A)
		{
			if (A.Length == 2)
				return 0;

			decimal minAvg = decimal.MaxValue;
			int minAvgIndex = -1;

			int[] sums = new int[A.Length + 1];

			sums[0] = 0;
			for (int i = 0; i < A.Length; i++)
				sums[i + 1] = sums[i] + A[i];

			for (int i = 1; i < sums.Length; i++)
			{
				for (int j = 0; j < 2; j++)
				{
					if (i + j + 1 < sums.Length)
					{
						int sliceSum = sums[i + j + 1] - sums[i - 1];
						decimal sliceAvg = (decimal)sliceSum / (i + j + 1 - i + 1);

						if (sliceAvg < minAvg)
						{
							minAvg = sliceAvg;
							minAvgIndex = i - 1;
						}
					}
				}
			}

			return minAvgIndex;
		}
	}
}
