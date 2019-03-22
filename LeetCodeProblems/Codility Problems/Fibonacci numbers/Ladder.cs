using System;
using System.Linq;

namespace LeetCodeProblems.Codility_Problems.Fibonacci_numbers
{
	public class Ladder
	{
		public int[] solution(int[] A, int[] B)
		{
			int[] result = new int[A.Length];
			int max = A.Max();
			int[] fibNumbers = _FibonacciNumber(max, 30);

			for (int i = 0; i < A.Length; i++)
			{
				int p = (int)Math.Pow(2, B[i]);
				result[i] = fibNumbers[A[i]] % p;
			}

			return result;
		}

		private int[] _FibonacciNumber(int step, int p)
		{
			int[] fibNumbers = new int[step + 1];
			int pow = (int)Math.Pow(2, p);
			fibNumbers[0] = 1;
			fibNumbers[1] = 1 % pow;

			for (int i = 2; i < fibNumbers.Length; i++)
				fibNumbers[i] = (fibNumbers[i - 1] + fibNumbers[i - 2]) % pow;

			return fibNumbers;
		}
	}
}
