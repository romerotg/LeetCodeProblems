namespace LeetCodeProblems.Binary_Search.More_Practices
{
	public class FindMinimuminRotatedSortedArrayII
	{
		public int FindMin(int[] nums)
		{
			if (nums == null || nums.Length == 0)
				return -1;

			int left = 0;
			int right = nums.Length - 1;

			while (left < right)
			{
				int middle = left + (right - left) / 2;

				// right ordered
				if (nums[middle] < nums[right])
					right = middle;
				// diminui 1 até dar pra ver se tá ordenado ou não
				else if (nums[middle] == nums[right])
					right--;
				// left ordered
				else
					left = middle + 1;
			}

			return nums[left];
		}
	}
}
