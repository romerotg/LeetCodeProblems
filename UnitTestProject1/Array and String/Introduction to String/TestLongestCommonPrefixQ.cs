using LeetCodeProblems.Array_and_String.Introduction_to_String;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestProject1.Array_and_String.Introduction_to_String
{
	[TestClass]
	public class TestLongestCommonPrefixQ
	{
		[DataRow(new string[] { "flower", "flow", "flight" }, "fl")]
		[DataRow(new string[] { "dog", "racecar", "car" }, "")]
		[DataRow(new string[] { "teste", "testivus", "t" }, "t")]
		[DataRow(new string[] { "teste", "testivus", "testanus" }, "test")]
		[DataRow(new string[] { }, "")]
		[DataTestMethod]
		public void TestMethod1(string[] strs, string expected)
		{
			// Arrange
			LongestCommonPrefixQ question = new LongestCommonPrefixQ();

			// Act
			string actual = question.LongestCommonPrefix(strs);

			// Assert
			Assert.AreEqual(expected, actual);
		}
	}
}
