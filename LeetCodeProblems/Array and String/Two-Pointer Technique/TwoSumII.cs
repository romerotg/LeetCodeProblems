namespace LeetCodeProblems.Array_and_String.Two_Pointer_Technique
{
	public class TwoSumII
	{
		public int[] TwoSum(int[] numbers, int target)
		{
			for (int i = 0; i < numbers.Length; i++)
			{
				for (int j = i + 1; j < numbers.Length; j++)
				{
					if (numbers[i] + numbers[j] == target)
						return new int[] { i + 1, j + 1 };
				}
			}

			return null;
		}

		public int[] TwoSum2(int[] numbers, int target)
		{
			int i = 0;
			int j = numbers.Length - 1;

			while (i < j)
			{
				int sum = numbers[i] + numbers[j];
				if (sum == target)
					return new int[] { i + 1, j + 1 };
				else if (sum > target)
					j--;
				else
					i++;
			}

			return null;
		}
	}
}
