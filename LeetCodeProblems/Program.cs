using LeetCodeProblems.Codility_Problems.Stacks_and_Queues;
using System;

namespace LeetCodeProblems
{
	class Program
	{
		static void Main(string[] args)
		{
			StoneWall question = new StoneWall();
			int ans = question.solution(new int[] { 8, 8, 5, 7, 9, 8, 7, 4, 8 });
			Console.ReadKey();
		}
	}
}
