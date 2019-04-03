using System;
using System.Collections.Generic;
using System.Text;

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

			for (int i = 0; i < rules.Length; i++)
			{
				List<string> remainingRules = new List<string>(rules);
				remainingRules.RemoveAt(i);
				result = _FindWord(remainingRules, rules[i][0].ToString(), rules[i][2]);
				if (result != null)
					return result;
			}

			return string.Empty;
		}

		private string _FindWord(List<string> rules, string currentWord, char next)
		{
			if (rules.Count == 0)
				return currentWord + next;

			string result = null;

			for (int i = 0; i < rules.Count; i++)
			{
				if (next == rules[i][0])
				{
					string nextWord = currentWord + rules[i][0];
					List<string> remainingRules = new List<string>(rules);
					remainingRules.RemoveAt(i);
					result = result ?? _FindWord(remainingRules, nextWord, rules[i][2]);
				}
			}

			return result;
		}
	}
}
