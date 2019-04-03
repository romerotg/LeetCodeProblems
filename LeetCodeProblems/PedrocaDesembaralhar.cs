using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace LeetCodeProblems
{
	public class PedrocaDesembaralhar
	{
		public string Unscramble(string s, List<Tuple<char, char>> rules)
		{
			if (s.Length < 2)
				return s;

			HashSet<Tuple<char, char>> rulesHash = new HashSet<Tuple<char, char>>(rules);

			for (int i = 0; i < s.Length; i++)
			{
				StringBuilder possibilities = new StringBuilder(s);
				possibilities.Remove(i, 1);

				StringBuilder current = new StringBuilder();
				current.Append(s[i]);

				string result = _Unscramble(current, possibilities, rulesHash);
				if (result != null)
					return result;
			}

			return null;
		}

		private string _Unscramble(StringBuilder current, StringBuilder possibilities, HashSet<Tuple<char, char>> rulesHash)
		{
			if (!_IsValidWithinRules(current, rulesHash))
				return null;
			if (possibilities.Length == 0)
				return current.ToString();

			string result = null;

			for (int i = 0; i < possibilities.Length; i++)
			{
				StringBuilder curr = new StringBuilder(current.ToString());
				curr.Append(possibilities[i]);
				StringBuilder poss = new StringBuilder(possibilities.ToString());
				poss.Remove(i, 1);
				result = result ?? _Unscramble(curr, poss, rulesHash);
			}

			return result;
		}

		private bool _IsValidWithinRules(StringBuilder current, HashSet<Tuple<char, char>> rulesHash)
		{
			if (current.Length == 1)
				return true;

			for (int i = 0; i < current.Length - 1; i++)
			{
				if (!rulesHash.Contains(Tuple.Create<char, char>(current[i], current[i + 1])))
					return false;
			}

			return true;
		}

		/*
		 * 
		A precedence rule is given as "P>E", which means that letter "P" is followed directly by the letter "E". Write a function, given an array of precedence rules, that finds the word represented by the given rules.
 
 Note: Each represented word contains a set of unique characters, i.e. the word does not contain duplicate letters.
 
 Examples:
 findWord(["P>E","E>R","R>U"]) // PERU
 findWord(["I>N","A>I","P>A","S>P"]) // SPAIN
 
 ===========
 Test cases:
 
 findWord(["U>N", "G>A", "R>Y", "H>U", "N>G", "A>R"]) // HUNGARY
 findWord(["I>F", "W>I", "S>W", "F>T"]) // SWIFT
 findWord(["R>T", "A>L", "P>O", "O>R", "G>A", "T>U", "U>G"]) // PORTUGAL
 findWord(["W>I", "R>L", "T>Z", "Z>E", "S>W", "E>R", "L>A", "A>N", "N>D", "I>T"]) // SWITZERLAND*/

		public string FindWord(string[] rules)
		{
			string result;
			foreach (string rule in rules)
			{
				string[] temp = rules.Where(t => t != rule).ToArray();
				result = _Calc(temp, rule[2], rule[0].ToString());
				if (result != null)
					return result;
			}

			return "";
		}
		private string _Calc(string[] rules, char head, string currS)
		{
			if (rules.Length == 0)
				return currS + head;

			string result = null;

			foreach (string rule in rules)
			{
				if (head == rule[0])
				{
					string word = String.Concat(currS, rule[0]);
					string[] remainingRules = rules.Where(t => t != rule).ToArray();
					//Console.WriteLine("testando {0} com regra {1}", currS + rule[0], rule[2]);
					result = result ?? _Calc(remainingRules, rule[2], word);
				}
			}

			return result;
		}
	}
}
