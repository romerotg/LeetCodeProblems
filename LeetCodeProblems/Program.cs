using LeetCodeProblems.Codility_Problems.Binary_search_algorithm;
using LeetCodeProblems.Codility_Problems.Caterpillar_method;
using System;

namespace LeetCodeProblems
{
	class Program
	{
		static void Main(string[] args)
		{
			CountTriangles question = new CountTriangles();
			int ans = question.solution(new int[] { 10, 2, 5, 1, 8, 12 });
			Console.WriteLine($"ans: {ans}");
			Console.ReadKey();
		}
	}
}
