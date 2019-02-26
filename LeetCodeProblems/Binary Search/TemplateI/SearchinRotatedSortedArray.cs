namespace LeetCodeProblems.Binary_Search.TemplateI
{
	public class SearchinRotatedSortedArray
	{
		public int Search(int[] nums, int target)
		{
			if (nums == null || nums.Length == 0)
				return -1;

			int left = 0;
			int right = nums.Length - 1;

			while (left <= right)
			{
				int middle = left + (right - left) / 2;

				if (nums[middle] == target)
					return middle;

				// right ordered
				if (nums[middle] < nums[right])
				{
					if (nums[middle] < target && nums[right] >= target)
						left = middle + 1;
					else
						right = middle - 1;

				}
				// left part ordered
				else
				{
					if (nums[middle] > target && nums[left] <= target)
						right = middle - 1;
					else
						left = middle + 1;
				}
			}

			return -1;
		}
	}
}
