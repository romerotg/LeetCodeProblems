namespace LeetCodeProblems.Binary_Search.TemplateIII
{
	public class SeachforaRange
	{
		public int[] SearchRange(int[] nums, int target)
		{
			int[] result = new int[2] { -1, -1 };

			if (nums == null || nums.Length == 0)
				return result;

			int left = 0;
			int right = nums.Length - 1;

			while (left <= right)
			{
				int middle = left + (right - left) / 2;

				if (nums[middle] == target)
					result[0] = middle;

				if (nums[middle] >= target)
					right = middle - 1;
				else
					left = middle + 1;
			}

			if (result[0] == -1)
				return result;

			left = 0;
			right = nums.Length - 1;

			while (left <= right)
			{
				int middle = left + (right - left) / 2;

				if (nums[middle] == target)
					result[1] = middle;

				if (nums[middle] <= target)
					left = middle + 1;
				else
					right = middle - 1;
			}

			return result;
		}
	}
}
