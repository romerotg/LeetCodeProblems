namespace LeetCodeProblems.Codility_Problems.Time_Complexity
{
	public class FrogJmp
	{
		public int solution(int X, int Y, int D)
		{
			int target = Y - X;

			if (target <= 0)
				return 0;

			int fullSteps = target / D;
			bool partStep = target % D != 0;

			return fullSteps + (partStep ? 1 : 0);
		}
	}
}
