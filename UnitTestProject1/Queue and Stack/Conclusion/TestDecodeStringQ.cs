using LeetCodeProblems.Queue_and_Stack.Conclusion;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests.Queue_and_Stack.Conclusion
{
	[TestClass]
	public class TestDecodeStringQ
	{
		[DataRow("ab", "ab")]
		[DataRow("3[a]2[bc]", "aaabcbc")]
		[DataRow("3[a2[c]]", "accaccacc")]
		[DataRow("2[abc]3[cd]ef", "abcabccdcdcdef")]
		[DataRow("sd2[f2[e]g]i", "sdfeegfeegi")]
		[DataRow("2[abc]xyc3[z]", "abcabcxyczzz")]
		[DataTestMethod]
		public void TestMethod1(string s, string expected)
		{
			// Arrange
			DecodeStringQ question = new DecodeStringQ();

			// Act
			string actual = question.DecodeString(s);

			// Assert
			Assert.AreEqual(expected, actual);
		}
	}
}
