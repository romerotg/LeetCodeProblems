using LeetCodeProblems.Codility_Problems.Prime_and_composite_numbers;
using LeetCodeProblems.Codility_Problems.Sieve_of_Eratosthenes;
using LeetCodeProblems.Codility_Problems.Stacks_and_Queues;
using System;

namespace LeetCodeProblems
{
	class Program
	{
		static void Main(string[] args)
		{
			CountSemiprimes question = new CountSemiprimes();
			int[] ans = question.solution(26, new int[] { 1, 4, 16 }, new int[] { 26, 10, 20 });
			Console.WriteLine($"ans: {ans}");
			Console.ReadKey();
		}
	}
}
