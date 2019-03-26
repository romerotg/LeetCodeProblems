using LeetCodeProblems.Codility_Problems.Caterpillar_method;
using System;

namespace LeetCodeProblems
{
	class Program
	{
		static void Main(string[] args)
		{
			MinAbsSumOfTwo question = new MinAbsSumOfTwo();
			int ans = question.solution(new int[] { 1000000000 });
			Console.WriteLine($"ans: {ans}");
			Console.ReadKey();
		}
	}
}
