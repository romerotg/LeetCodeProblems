using LeetCodeProblems.Codility_Problems.Counting_Elements;
using System;

namespace LeetCodeProblems
{
	class Program
	{
		static void Main(string[] args)
		{
			MissingInteger question = new MissingInteger();
			int missing = question.solution(new int[] { 0, 1000000 });
			Console.ReadKey();
		}
	}
}
