using LeetCodeProblems.Recursion_I.Conclusion;
using System;
using System.Collections.Generic;

namespace LeetCodeProblems
{
	class Program
	{
		static void Main(string[] args)
		{
			UniqueBinarySearchTreesII question = new UniqueBinarySearchTreesII();
			IList<TreeNode> trees = question.GenerateTrees(3);
			Console.ReadKey();
		}
	}
}
