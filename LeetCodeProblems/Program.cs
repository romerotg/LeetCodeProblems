using LeetCodeProblems.Codility_Problems.Fibonacci_numbers;
using System;
using System.Collections.Generic;

namespace LeetCodeProblems
{
	class Program
	{
		static void Main(string[] args)
		{
			LongestDominoesSequenceQ question = new LongestDominoesSequenceQ();
			int ans = question.solution(new List<Tuple<int, int>>() { Tuple.Create(4, 2), Tuple.Create(4, 3), Tuple.Create(3, 6), Tuple.Create(6, 6), Tuple.Create(1, 1), Tuple.Create(1, 1), Tuple.Create(0, 0) });
			Console.WriteLine($"ans: {ans}");
			Console.ReadKey();
		}
	}
}
