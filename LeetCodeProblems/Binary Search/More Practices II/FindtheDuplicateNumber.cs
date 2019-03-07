namespace LeetCodeProblems.Binary_Search.More_Practices_II
{
	public class FindtheDuplicateNumber
	{
		public int FindDuplicate(int[] nums)
		{
			if (nums == null || nums.Length == 0)
				return -1;

			int left = 0;
			int right = nums.Length - 1;

			while (left < right)
			{
				int middle = left + (right - left) / 2;

				int count = 0;
				foreach (int num in nums)
				{
					if (num <= middle)
						count++;
				}
				if (count > middle)
					right = middle;
				else
					left = middle + 1;
			}

			return left;
		}
	}
}
