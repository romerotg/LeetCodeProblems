namespace LeetCodeProblems.Recursion_I.Complexity_Analysis
{
	public class Pow
	{
		public double MyPow(double x, int n)
		{
			if (n == 0)
				return 1;
			if (n == 1)
				return x;
			if (n == -1)
				return 1 / x;

			double pow = MyPow(x, n / 2);
			return pow * pow * MyPow(x, n % 2);
		}
	}
}
