namespace LeetCodeProblems.Array_and_String.Two_Pointer_Technique
{
	public class RemoveElementQ
	{
		public int RemoveElement(int[] nums, int val)
		{
			int result = 0;

			if (nums != null && nums.Length > 0)
			{
				for (int i = 0; i < nums.Length; i++)
				{
					if (nums[i] != val)
						nums[result++] = nums[i];
				}
			}

			return result;
		}
	}
}
