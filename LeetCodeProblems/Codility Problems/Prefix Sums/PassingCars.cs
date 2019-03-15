namespace LeetCodeProblems.Codility_Problems.Prefix_Sums
{
	public class PassingCars
	{
		public int solution(int[] A)
		{
			if (A == null || A.Length < 2)
				return 0;

			int[] eastCars = new int[A.Length + 1];
			int count = 0;

			for (int i = 1; i < eastCars.Length; i++)
			{
				if (A[i - 1] == 0)
					eastCars[i] = eastCars[i - 1] + 1;
				else
				{
					eastCars[i] = eastCars[i - 1];
					count += eastCars[i];

					if (count > 1000000000)
						return -1;
				}
			}

			return count;
		}
	}
}
