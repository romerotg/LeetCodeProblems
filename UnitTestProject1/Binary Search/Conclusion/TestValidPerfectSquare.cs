using LeetCodeProblems.Binary_Search.Conclusion;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests.Binary_Search.Conclusion
{
	[TestClass]
	public class TestValidPerfectSquare
	{
		[DataRow(16, true)]
		[DataRow(14, false)]
		[DataRow(2147483647, false)]
		[DataRow(1, true)]
		[DataTestMethod]
		public void TestMethod1(int num, bool expected)
		{
			// Arrange
			ValidPerfectSquare question = new ValidPerfectSquare();

			// Act
			bool actual = question.IsPerfectSquare(num);

			// Assert
			Assert.AreEqual(expected, actual);
		}
	}
}
