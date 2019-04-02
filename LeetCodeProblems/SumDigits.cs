using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems
{
	public class SumDigits
	{
		public int CalculateSumOfDigits(int N)
		{
			int sum = 0;

			for (int i = 1; i <= N; i++)
				sum += _SumDigits(i);

			return sum;
		}

		private int _SumDigits(int x)
		{
			int sum = 0;

			while (x > 0)
			{
				sum += x % 10;
				x = x / 10;
			}

			return sum;
		}
	}
}
