using LeetCodeProblems.Recursion_I.Conclusion;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests.Recursion_I.Conclusion
{
	[TestClass]
	public class TestKthSymbolinGrammar
	{
		[DataRow(1, 1, 0)]
		[DataRow(2, 1, 0)]
		[DataRow(2, 2, 1)]
		[DataRow(4, 5, 1)]
		[DataTestMethod]
		public void TestMethod1(int N, int K, int expected)
		{
			// Arrange
			KthSymbolinGrammar question = new KthSymbolinGrammar();

			// Act
			int actual = question.KthGrammar(N, K);

			// Assert
			Assert.AreEqual(expected, actual);
		}
	}
}
