namespace LeetCodeProblems.Binary_Search.More_Practices
{
	public class TwoSumII
	{
		public int[] TwoSum(int[] numbers, int target)
		{
			if (numbers == null || numbers.Length == 0)
				return null;

			for (int i = 0; i < numbers.Length; i++)
			{
				int left = i + 1;
				int right = numbers.Length - 1;
				int dif = target - numbers[i];

				while (left <= right)
				{
					int middle = left + (right - left) / 2;

					if (numbers[middle] == dif)
						return new int[] { i + 1, middle + 1 };
					else if (numbers[middle] > dif)
						right = middle - 1;
					else
						left = middle + 1;
				}
			}

			return null;
		}
	}
}
