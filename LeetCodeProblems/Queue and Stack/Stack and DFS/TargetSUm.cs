namespace LeetCodeProblems.Queue_and_Stack.Stack_and_DFS
{
	public class TargetSum
	{
		public int FindTargetSumWays(int[] nums, int S)
		{
			if (nums == null || nums.Length == 0)
				return 0;

			return _FindTargetSumWays(nums, S, 0, 0);
		}

		private int _FindTargetSumWays(int[] nums, int S, int index, int sum)
		{
			if (index == nums.Length)
				return sum == S ? 1 : 0;

			int minus = sum + nums[index];
			int plus = sum - nums[index];

			return _FindTargetSumWays(nums, S, index + 1, minus) + _FindTargetSumWays(nums, S, index + 1, plus);
		}
	}
}
