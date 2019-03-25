using LeetCodeProblems.Codility_Problems.Caterpillar_method;
using System;

namespace LeetCodeProblems
{
	class Program
	{
		static void Main(string[] args)
		{
			DominoToptal question = new DominoToptal();
			int ans = question.solution("1-1,3-5,5-2,2-3,2-4");
			Console.WriteLine($"ans: {ans}");
			ans = question.solution("1-1");
			Console.WriteLine($"ans: {ans}");
			ans = question.solution("1-2,1-2");
			Console.WriteLine($"ans: {ans}");
			ans = question.solution("3-2,2-1,1-4,4-4,5-4,4-2,2-1");
			Console.WriteLine($"ans: {ans}");
			ans = question.solution("5-5,5-5,4-4,5-5,5-5,5-5,5-5,5-5,5-5,5-5");
			Console.WriteLine($"ans: {ans}");
			Console.ReadKey();
		}
	}
}
