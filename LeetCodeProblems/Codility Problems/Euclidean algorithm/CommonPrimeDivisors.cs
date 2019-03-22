using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCodeProblems.Codility_Problems.Euclidean_algorithm
{
	public class CommonPrimeDivisors
	{
		public int solution(int[] A, int[] B)
		{
			int result = 0;
			int max = Math.Max(A.Max(), B.Max());
			List<int> primes = _GetPrimeNumbers(max);

			for (int i = 0; i < A.Length; i++)
			{
				result++;
				if (A[i] > 1 || B[i] > 1)
				{
					foreach (int prime in primes)
					{
						if ((A[i] % prime == 0 && B[i] % prime != 0) ||
							(A[i] % prime != 0 && B[i] % prime == 0))
						{
							result--;
							break;
						}
					}
				}
			}

			return result;
		}

		private List<int> _GetPrimeNumbers(int a)
		{
			bool[] sieve = new bool[a + 1];
			for (int j = 2; j < sieve.Length; j++)
				sieve[j] = true;

			int i = 2;
			while (i * i <= a)
			{
				if (sieve[i])
				{
					int k = i * i;
					while (k <= a)
					{
						sieve[k] = false;
						k += i;
					}
				}
				i++;
			}

			List<int> primes = new List<int>();
			for (int j = 2; j < sieve.Length; j++)
			{
				if (sieve[j])
					primes.Add(j);
			}
			return primes;
		}
	}
}
