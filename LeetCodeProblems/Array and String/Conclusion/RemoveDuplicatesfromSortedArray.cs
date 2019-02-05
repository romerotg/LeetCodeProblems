namespace LeetCodeProblems.Array_and_String.Conclusion
{
	public class RemoveDuplicatesfromSortedArray
	{
		public int RemoveDuplicates(int[] nums)
		{
			int result = 0;

			if (nums != null && nums.Length > 0)
			{
				result = 1;
				for (int i = 1; i < nums.Length; i++)
				{
					if (nums[i] != nums[result - 1])
						nums[result++] = nums[i];
				}
			}

			return result;
		}
	}
}
