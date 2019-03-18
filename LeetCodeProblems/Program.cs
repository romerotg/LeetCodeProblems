using LeetCodeProblems.Codility_Problems.Stacks_and_Queues;
using System;

namespace LeetCodeProblems
{
	class Program
	{
		static void Main(string[] args)
		{
			Fish question = new Fish();
			int ans = question.solution(new int[] { 4, 3, 2, 1, 5 }, new int[] { 0, 1, 0, 0, 0 });
			Console.ReadKey();
		}
	}
}
