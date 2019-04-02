using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.TT
{
	public class Q2
	{
		public string solution(int AX, int AY, int BX, int BY)
		{
			if (AX == BX)
			{
				if (AY > BY)
					return string.Format("{0},{1}", BX - 1, BY);
				else
					return string.Format("{0},{1}", BX + 1, BY);
			}

			if (AY == BY)
			{
				if (AX > BX)
					return string.Format("{0},{1}", BX, BY + 1);
				else
					return string.Format("{0},{1}", BX, BY - 1);
			}



			return null;
		}
	}
}
