using System;
using System.Collections.Generic;

namespace LeetCodeProblems
{
	class Program
	{
		static void Main(string[] args)
		{
			SumDigits question = new SumDigits();
			Console.WriteLine(question.CalculateSumOfDigits(1));
			Console.WriteLine(question.CalculateSumOfDigits(11));
			Console.WriteLine(question.CalculateSumOfDigits(12));
			Console.ReadKey();
		}
	}
}
