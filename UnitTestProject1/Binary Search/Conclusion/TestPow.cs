using LeetCodeProblems.Binary_Search.Conclusion;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests.Binary_Search.Conclusion
{
	[TestClass]
	public class TestPow
	{
		[DataRow(2.00000, 10, 1024.00000)]
		[DataRow(2.10000, 3, 9.26100)]
		[DataRow(2.00000, -2, 0.25000)]
		[DataTestMethod]
		public void TestMethod1(double x, int n, double expected)
		{
			// Arrange
			Pow question = new Pow();

			// Act
			double actual = question.MyPow(x, n);

			// Assert
			Assert.AreEqual(expected, actual);
		}
	}
}
