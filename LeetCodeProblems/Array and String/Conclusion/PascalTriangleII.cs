using System.Collections.Generic;

namespace LeetCodeProblems.Array_and_String.Conclusion
{
	public class PascalTriangleII
	{
		public IList<int> GetRow(int rowIndex)
		{
			int numRows = rowIndex + 1;
			int[] result = new int[numRows];

			result[0] = result[result.Length - 1] = 1;

			if (result.Length > 2)
			{
				for (int i = 0; i < numRows; i++)
				{
					int rowLength = i + 1;
					result[0] = result[rowLength - 1] = 1;

					if (rowLength > 2)
					{
						for (int j = rowLength - 2; j > 0; j--)
							result[j] = result[j] + result[j - 1];
					}
				}
			}

			return result;
		}
	}
}
