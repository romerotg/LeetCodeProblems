using System;
using System.Collections.Generic;

namespace LeetCodeProblems
{
	public class LongestDominoesSequenceQ
	{
		public int solution(List<Tuple<int, int>> dominoes)
		{
			if (dominoes == null)
				return 0;
			if (dominoes.Count < 2)
				return dominoes.Count;

			List<List<Tuple<int, int>>> sequences = new List<List<Tuple<int, int>>>() { dominoes };

			while (sequences.Count > 0)
			{
				foreach (var sequence in sequences)
				{
					if (_IsSequenceValid(sequence))
						return sequence.Count;
				}

				sequences = _GetBiggestSubsequences(sequences);
			}

			return 1;
		}

		private List<List<Tuple<int, int>>> _GetBiggestSubsequences(List<List<Tuple<int, int>>> sequences)
		{
			List<List<Tuple<int, int>>> subsequences = new List<List<Tuple<int, int>>>();

			if (sequences[0].Count == 1)
				return subsequences;

			foreach (var sequence in sequences)
			{
				for (int i = 0; i < sequence.Count; i++)
				{
					List<Tuple<int, int>> subsequence = new List<Tuple<int, int>>(sequence);
					subsequence.RemoveAt(i);
					subsequences.Add(subsequence);
				}
			}

			return subsequences;
		}

		private bool _IsSequenceValid(List<Tuple<int, int>> sequence)
		{
			if (sequence == null || sequence.Count == 0)
				return false;
			if (sequence.Count == 1)
				return true;

			Dictionary<int, int> countDif = new Dictionary<int, int>();
			Dictionary<int, int> countEq = new Dictionary<int, int>();

			foreach (var tuple in sequence)
			{
				if (tuple.Item1 == tuple.Item2)
				{
					if (countEq.ContainsKey(tuple.Item1))
						countEq[tuple.Item1]++;
					else
						countEq.Add(tuple.Item1, 1);
				}
				else
				{
					if (countDif.ContainsKey(tuple.Item1))
						countDif[tuple.Item1]++;
					else
						countDif.Add(tuple.Item1, 1);

					if (countDif.ContainsKey(tuple.Item2))
						countDif[tuple.Item2]++;
					else
						countDif.Add(tuple.Item2, 1);
				}
			}

			bool result = true;

			if (countDif.Count > 0)
			{
				int oddCount = 0;
				foreach (var pair in countDif)
				{
					if (pair.Value % 2 == 1)
						oddCount++;
				}

				result = (oddCount == 0 || oddCount == 2);

				if (result)
				{
					foreach (var pair in countEq)
					{
						if (!countDif.ContainsKey(pair.Key))
						{
							result = false;
							break;
						}
					}
				}
			}
			else
				result = countEq.Count == 1;

			return result;
		}
	}
}
