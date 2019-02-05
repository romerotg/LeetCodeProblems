namespace LeetCodeProblems.Array_and_String.Two_Pointer_Technique
{
	public class MaxConsecutiveOnes
	{
		public int FindMaxConsecutiveOnes(int[] nums)
		{
			int result = 0;

			if (nums != null && nums.Length > 0)
			{
				int consecutive = 0;
				for (int i = 0; i < nums.Length; i++)
				{
					if (nums[i] == 1)
						consecutive++;
					else
					{
						if (consecutive > result)
							result = consecutive;
						consecutive = 0;
					}
				}
				if (consecutive > result)
					result = consecutive;
			}

			return result;
		}
	}
}
