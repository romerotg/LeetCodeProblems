using LeetCodeProblems.Array_and_String.Conclusion;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1.Array_and_String.Conclusion
{
	[TestClass]
	public class TestReverseWordsinaString
	{
		[DataRow("the sky is blue", "blue is sky the")]
		[DataTestMethod]
		public void TestMethod1(string s, string expected)
		{
			// Arrange
			ReverseWordsinaString question = new ReverseWordsinaString();

			// Act
			string actual = question.ReverseWords(s);

			// Assert
			Assert.AreEqual(expected, actual);
		}

		[DataRow("the sky is blue", "blue is sky the")]
		[DataTestMethod]
		public void TestMethod2(string s, string expected)
		{
			// Arrange
			ReverseWordsinaString question = new ReverseWordsinaString();

			// Act
			string actual = question.ReverseWords2(s);

			// Assert
			Assert.AreEqual(expected, actual);
		}
	}
}
