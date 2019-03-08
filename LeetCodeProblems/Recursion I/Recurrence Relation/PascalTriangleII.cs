using System.Collections.Generic;

namespace LeetCodeProblems.Recursion_I.Recurrence_Relation
{
	public class PascalTriangleII
	{
		public IList<int> GetRow(int rowIndex)
		{
			int[] result = new int[rowIndex + 1];

			if (rowIndex < 0)
				return result;

			result[0] = 1;
			result[rowIndex] = 1;

			if (rowIndex == 0)
				return result;

			int[] parentRow = (int[])GetRow(rowIndex - 1);
			for (int i = 1; i < rowIndex; i++)
				result[i] = parentRow[i] + parentRow[i - 1];

			return result;
		}
	}
}
