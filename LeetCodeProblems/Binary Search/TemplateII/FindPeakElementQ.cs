namespace LeetCodeProblems.Binary_Search.TemplateII
{
	public class FindPeakElementQ
	{
		public int FindPeakElement(int[] nums)
		{
			if (nums == null || nums.Length == 0)
				return -1;

			int left = 0;
			int right = nums.Length - 1;

			while (left < right)
			{
				int middle = left + (right - left) / 2;

				if (nums[middle] < nums[middle + 1])
					left = middle + 1;
				else
					right = middle;
			}

			return left;
		}
	}
}
