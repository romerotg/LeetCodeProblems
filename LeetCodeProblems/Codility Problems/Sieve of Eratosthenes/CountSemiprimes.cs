using System.Collections.Generic;

namespace LeetCodeProblems.Codility_Problems.Sieve_of_Eratosthenes
{
	public class CountSemiprimes
	{
		public int[] solution(int N, int[] P, int[] Q)
		{
			int[] result = new int[P.Length];

			if (N < 2)
				return result;

			bool[] primes = _GetPrimeNumbers(N);

			Dictionary<int, bool> semiPrimes = new Dictionary<int, bool>();

			for (int i = 4; i <= N; i++)
				semiPrimes[i] = _IsSemiPrime(i, primes);

			for (int i = 0; i < result.Length; i++)
			{
				for (int j = P[i]; j <= Q[i]; j++)
				{
					bool val;
					if (semiPrimes.TryGetValue(j, out val) && val)
						result[i]++;
				}
			}

			return result;
		}

		private bool[] _GetPrimeNumbers(int N)
		{
			bool[] primes = new bool[N + 1];

			for (int j = 2; j < primes.Length; j++)
				primes[j] = true;

			int i = 2;
			while (i * i <= N)
			{
				if (primes[i])
				{
					int k = i * i;
					while (k <= N)
					{
						primes[k] = false;
						k += i;
					}
				}
				i++;
			}

			return primes;
		}

		private bool _IsSemiPrime(int n, bool[] primes)
		{
			for (int i = 2; i < primes.Length && i * i <= n; i++)
			{
				if (primes[i] && n % i == 0 && primes[n / i])
					return true;
			}

			return false;
		}
	}
}
