using LeetCodeProblems.Codility_Problems.Prefix_Sums;
using System;

namespace LeetCodeProblems
{
	class Program
	{
		static void Main(string[] args)
		{
			GenomicRangeQuery question = new GenomicRangeQuery();
			int[] ans = question.solution("CAGCCTA", new int[] {2, 5, 0}, new int[] { 4, 5, 6 });
			Console.ReadKey();
		}
	}
}
