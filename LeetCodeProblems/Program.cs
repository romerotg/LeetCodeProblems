using LeetCodeProblems.Codility_Problems.Fibonacci_numbers;
using System;

namespace LeetCodeProblems
{
	class Program
	{
		static void Main(string[] args)
		{
			FibFrog question = new FibFrog();
			int ans = question.solution(new int[] { 0});
			Console.WriteLine($"ans: {ans}");
			Console.ReadKey();
		}
	}
}
