using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.Binary_Search.TemplateI
{
	public class GuessNumberHigherorLower
	{
		public int GuessNumber(int n)
		{
			int left = 1;
			int right = n;

			while (left <= right)
			{
				int middle = left + (right - left) / 2;

				int myGuess = guess(middle);

				if (myGuess == 0)
					return middle;
				else if (myGuess == -1)
					right = middle - 1;
				else if (myGuess == 1)
					left = middle + 1;
			}

			return -1;
		}

		public int guess(int num)
		{
			return -1;
		}
	}
}
