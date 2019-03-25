using System;

namespace LeetCodeProblems
{
	public class CountCircularPrimes
	{
		public int solution(int N)
		{
			bool[] sieve = _SieveOfEratosthenes(1000000);
			int result = 0;

			for (int i = 1; i <= N; i++)
			{
				if (sieve[i])
				{
					result++;
					int num = i;
					while ((num = _Rotate(num)) != i)
					{
						if (!sieve[num])
						{
							result--;
							break;
						}
					}
				}
			}

			return result;
		}

		private bool[] _SieveOfEratosthenes(int N)
		{
			bool[] sieve = new bool[N + 1];
			for (int i = 2; i < sieve.Length; i++)
				sieve[i] = true;

			int j = 2;
			while (j * j < N)
			{
				if (sieve[j])
				{
					int k = j * j;
					while (k <= N)
					{
						sieve[k] = false;
						k += j;
					}
				}
				j++;
			}

			return sieve;
		}

		private int _Rotate(int n)
		{
			// Pega unidade e coloca mais pra esquerda
			int unit = n % 10;
			unit *= (int)Math.Pow(10, _GetDigitsCount(n) - 1);

			// Coloca todo o resto 1 casa pra direita
			n = n / 10;

			// Retorna a soma
			return unit + n;
		}

		private int _GetDigitsCount(int n)
		{
			int digits = 1;

			while ((n = n / 10) > 0)
				digits++;

			return digits;
		}
	}
}
