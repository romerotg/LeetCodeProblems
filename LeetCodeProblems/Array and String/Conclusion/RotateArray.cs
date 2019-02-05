namespace LeetCodeProblems.Array_and_String.Conclusion
{
	public class RotateArray
	{
		public void Rotate(int[] nums, int k)
		{
			if (nums != null && nums.Length > 0 && k % nums.Length != 0)
			{
				for (int i = 0; i < k % nums.Length; i++)
				{
					int previous = nums[0];

					for (int j = 1; j < nums.Length; j++)
					{
						int current = nums[j];
						nums[j] = previous;
						previous = current;
					}

					nums[0] = previous;
				}
			}
		}

		public void Rotate2(int[] nums, int k)
		{
			if (nums != null && nums.Length > 0 && k % nums.Length != 0)
			{
				int[] result = new int[nums.Length];

				for (int i = 0; i < result.Length; i++)
					result[(i + k) % nums.Length] = nums[i];

				for (int i = 0; i < nums.Length; i++)
					nums[i] = result[i];
			}
		}
	}
}
