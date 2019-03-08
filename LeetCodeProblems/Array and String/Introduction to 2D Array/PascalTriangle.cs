using System.Collections.Generic;

namespace LeetCodeProblems.Array_and_String.Introduction_to_2D_Array
{
	public class PascalTriangle
	{
		public IList<IList<int>> Generate(int numRows)
		{
			int[][] result = new int[numRows][];

			for (int i = 0; i < numRows; i++)
			{
				int rowLength = i + 1;
				result[i] = new int[rowLength];

				result[i][0] = 1;
				result[i][rowLength - 1] = 1;

				if (rowLength > 2)
				{
					for (int j = 1; j < rowLength - 1; j++)
					{
						result[i][j] = result[i - 1][j] + result[i - 1][j - 1];
					}
				}
			}

			return result;
		}
	}
}
