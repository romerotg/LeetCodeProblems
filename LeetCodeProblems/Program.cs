using LeetCodeProblems.Codility_Problems.Caterpillar_method;
using LeetCodeProblems.Codility_Problems.Dynamic_programming;
using LeetCodeProblems.Codility_Problems.Sorting;
using System;

namespace LeetCodeProblems
{
	class Program
	{
		static void Main(string[] args)
		{
			CountCarryOperations question = new CountCarryOperations();
			int ans = question.solution(20, 82);
			Console.WriteLine($"ans: {ans}");
			Console.ReadKey();
		}
	}
}
