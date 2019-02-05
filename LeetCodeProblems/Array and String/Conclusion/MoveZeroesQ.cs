namespace LeetCodeProblems.Array_and_String.Conclusion
{
	public class MoveZeroesQ
	{
		public void MoveZeroes(int[] nums)
		{
			if (nums != null)
			{
				int k = 0;

				for (int i = 0; i < nums.Length; i++)
				{
					if (nums[i] != 0)
						nums[k++] = nums[i];
				}

				while (k < nums.Length)
					nums[k++] = 0;
			}
		}
	}
}
