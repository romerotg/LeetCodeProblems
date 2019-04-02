using LeetCodeProblems.TT;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests.TT
{
	[TestClass]
	public class TestQ3
	{
		[DataRow("banana", 3)]
		[DataRow("aaabbbaac", 2)]
		[DataRow("z", 0)]
		[DataRow("abcd", 0)]
		[DataRow("dcba", 3)]
		[DataRow("adcb", 2)]
		[DataRow("aaaa", 0)]
		[DataTestMethod]
		public void TestMethod1(string s, int expected)
		{
			// Arrange
			Q3 question = new Q3();

			// Act
			int actual = question.solution(s);

			// Assert
			Assert.AreEqual(expected, actual);
		}
	}
}
