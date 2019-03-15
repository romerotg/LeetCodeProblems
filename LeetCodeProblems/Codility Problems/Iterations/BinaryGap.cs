using System;

namespace LeetCodeProblems.Codility_Problems.Iterations
{
	public class BinaryGap
	{
		public int solution(int N)
		{
			string binary = Convert.ToString(N, 2);

			int maxGap = 0;
			int currentGap = 0;
			bool gap = false;
			char lastChar = '-';

			foreach (char c in binary)
			{
				if (c == '1')
				{
					if (gap)
					{
						gap = false;
						maxGap = Math.Max(maxGap, currentGap);
						currentGap = 0;
					}
				}
				else
				{
					gap = true;
					currentGap++;
				}

				lastChar = c;
			}

			return maxGap;
		}
	}
}
