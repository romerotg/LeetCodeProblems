using System;

namespace LeetCodeProblems
{
	class Program
	{
		static void Main(string[] args)
		{
			PedrocaDesembaralhar question = new PedrocaDesembaralhar();
			Console.WriteLine(question.FindWord(new string[] { "U>N", "G>A", "R>Y", "H>U", "N>G", "A>R" })); // HUNGARY
			Console.WriteLine(question.FindWord(new string[] { "I>F", "W>I", "S>W", "F>T" })); // SWIFT
			Console.WriteLine(question.FindWord(new string[] { "R>T", "A>L", "P>O", "O>R", "G>A", "T>U", "U>G" })); // PORTUGAL
			Console.WriteLine(question.FindWord(new string[] { "W>I", "R>L", "T>Z", "Z>E", "S>W", "E>R", "L>A", "A>N", "N>D", "I>T" })); // SWITZERLAND
			Console.ReadKey();
		}
	}
}
