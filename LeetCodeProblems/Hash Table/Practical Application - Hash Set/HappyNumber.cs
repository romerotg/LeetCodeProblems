using System.Collections.Generic;

namespace LeetCodeProblems.Hash_Table.Practical_Application___Hash_Set
{
	public class HappyNumber
	{
		public bool IsHappy(int n)
		{
			HashSet<int> testedNumbers = new HashSet<int>();

			while (true)
			{
				testedNumbers.Add(n);

				int p = 0;
				while (n > 0)
				{
					p = p + (n % 10) * (n % 10);
					n = n / 10;
				}

				if (p == 1)
					return true;
				else if (testedNumbers.Contains(p))
					return false;
				else
					n = p;
			}
		}
	}
}
