using System;
using System.Collections.Generic;

namespace LeetCodeProblems.Codility_Problems.Fibonacci_numbers
{
	public class FibFrog
	{
		public int solution(int[] A)
		{
			if (A == null || A.Length == 0)
				return 1;

			int distance = A.Length + 1;

			List<int> fibonacciNumbers = _CalculateFibNumbers();
			HashSet<int> hash = new HashSet<int>(fibonacciNumbers);

			if (hash.Contains(distance))
				return 1;

			for (int i = 1; i < A.Length; i++)
			{
				if (A[i] == 0 || hash.Contains(i + 1))
					continue;

				A[i] = int.MaxValue;
				foreach (int fib in fibonacciNumbers)
				{
					int prevIndex = i - fib;
					if (i - fib < 0)
						break;
					else if (A[prevIndex] > 0 && A[prevIndex] != int.MaxValue)
						A[i] = Math.Min(A[i], A[prevIndex] + 1);
				}
			}

			int result = int.MaxValue;

			foreach (int fib in fibonacciNumbers)
			{
				int prevIndex = A.Length - fib;
				if (A.Length - fib < 0)
					break;
				else if (A[prevIndex] > 0 && A[prevIndex] != int.MaxValue)
					result = Math.Min(result, A[prevIndex] + 1);
			}

			return result == int.MaxValue ? -1 : result;
		}

		private List<int> _CalculateFibNumbers()
		{
			List<int> fibNumbers = new List<int>();
			int first = 0;
			int second = 1;

			for (int i = 2; i <= int.MaxValue; i++)
			{
				int next = first + second;
				first = second;
				second = next;
				if (next > 100000)
					break;
				fibNumbers.Add(next);
			}

			return fibNumbers;
		}
	}
}
