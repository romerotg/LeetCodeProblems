using System;

namespace LeetCodeProblems
{
	public class DominoToptal
	{
		public int solution(string S)
		{
			if (S == null || S.Length == 0)
				return 0;

			string[] tiles = S.Split(',');

			int max = 0;
			int current = 0;
			string lastRight = null;

			foreach (var tile in tiles)
			{
				string[] pair = tile.Split('-');

				string left = pair[0];
				string right = pair[1];

				if (current == 0 || left == lastRight)
					current++;
				else
				{
					max = Math.Max(current, max);
					current = 1;
				}

				lastRight = right;
			}

			return Math.Max(current, max);
		}
	}
}
