using System.Collections.Generic;

namespace LeetCodeProblems.Recursion_I.Recurrence_Relation
{
	public class PascalTriangle
	{
		public IList<IList<int>> Generate(int numRows)
		{
			int[][] result = new int[numRows][];

			if (numRows <= 0)
				return result;

			_Generate(result, numRows);
			return result;
		}

		private int[] _Generate(int[][] triangle, int numRows)
		{
			int[] row = new int[numRows];
			row[0] = 1;
			row[numRows - 1] = 1;
			triangle[numRows - 1] = row;

			if (numRows == 1)
				return row;

			int[] parentRow = _Generate(triangle, numRows - 1);
			for (int i = 1; i < numRows - 1; i++)
				row[i] = parentRow[i] + parentRow[i - 1];

			return row;
		}
	}
}
