using LeetCodeProblems.Array_and_String.Introduction_to_String;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests.Array_and_String.Introduction_to_String
{
	[TestClass]
	public class TestImplementStrStr
	{
		[DataRow("hello", "ll", 2)]
		[DataRow("aaaaa", "bba", -1)]
		[DataRow("mississippi", "issip", 4)]
		[DataRow("aaa", "aaaa", -1)]
		[DataRow("bba", "aaa", -1)]
		[DataRow("mississippi", "sippia", -1)]
		[DataTestMethod]
		public void TestMethod1(string haystack, string needle, int expected)
		{
			// Arrange
			ImplementStrStr question = new ImplementStrStr();

			// Act
			int actual = question.StrStr(haystack, needle);

			// Assert
			Assert.AreEqual(expected, actual);
		}

		[DataRow("hello", "ll", 2)]
		[DataRow("aaaaa", "bba", -1)]
		[DataRow("mississippi", "issip", 4)]
		[DataRow("aaa", "aaaa", -1)]
		[DataRow("bba", "aaa", -1)]
		[DataTestMethod]
		public void TestMethod2(string haystack, string needle, int expected)
		{
			// Arrange
			ImplementStrStr question = new ImplementStrStr();

			// Act
			int actual = question.StrStr2(haystack, needle);

			// Assert
			Assert.AreEqual(expected, actual);
		}
	}
}
