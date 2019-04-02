using LeetCodeProblems.TT;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests.TTs
{
	[TestClass]
	public class TestQ1
	{
		[DataRow("", "a", "INSERT a")]
		[DataRow("a", "ab", "INSERT b")]
		[DataRow("testivus", "testivxx", "IMPOSSIBLE")]
		[DataRow("testivus", "testivux", "REPLACE s x")]
		[DataRow("testivus", "testivsu", "SWAP u s")]
		[DataRow("testivus", "testivus", "EQUAL")]
		[DataRow("nice", "niece", "INSERT e")]
		[DataRow("nice", "nieece", "IMPOSSIBLE")]
		[DataRow("test", "tent", "REPLACE s n")]
		[DataRow("form", "from", "SWAP o r")]
		[DataRow("o", "odd", "IMPOSSIBLE")]
		[DataRow("teste", "test", "IMPOSSIBLE")]
		[DataTestMethod]
		public void TestMethod1(string S, string T, string expected)
		{
			// Arrange
			Q1 question = new Q1();

			// Act
			string actual = question.solution(S, T);

			// Assert
			Assert.AreEqual(expected, actual);
			// CollectionAssert.AreEqual
		}
	}
}
