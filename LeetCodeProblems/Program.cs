using LeetCodeProblems.Codility_Problems.Caterpillar_method;
using System;

namespace LeetCodeProblems
{
	class Program
	{
		static void Main(string[] args)
		{
			CountCircularPrimes question = new CountCircularPrimes();
			int ans = question.solution(1);
			Console.WriteLine($"ans: {ans}");
			ans = question.solution(10);
			Console.WriteLine($"ans: {ans}");
			ans = question.solution(100);
			Console.WriteLine($"ans: {ans}");
			ans = question.solution(1000);
			Console.WriteLine($"ans: {ans}");
			ans = question.solution(10000);
			Console.WriteLine($"ans: {ans}");
			ans = question.solution(100000);
			Console.WriteLine($"ans: {ans}");
			ans = question.solution(1000000);
			Console.WriteLine($"ans: {ans}");
			Console.ReadKey();
		}
	}
}
