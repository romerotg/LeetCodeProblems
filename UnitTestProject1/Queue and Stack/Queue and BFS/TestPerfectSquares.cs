using LeetCodeProblems.Queue_and_Stack.Queue_and_BFS;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests.Queue_and_Stack.Queue_and_BFS
{
	[TestClass]
	public class TestPerfectSquares
	{
		[DataRow(12, 3)]
		[DataRow(13, 2)]
		[DataRow(7168, 4)]
		[DataTestMethod]
		public void TestMethod1(int n, int expected)
		{
			// Arrange
			PerfectSquares question = new PerfectSquares();

			// Act
			int actual = question.NumSquares(n);

			// Assert
			Assert.AreEqual(expected, actual);
		}
	}
}
