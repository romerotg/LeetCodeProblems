using LeetCodeProblems.Recursion_I.Memoization;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests.Recursion_I.Memoization
{
	[TestClass]
	public class TestFibonacciNumber
	{
		[DataRow(2, 1)]
		[DataRow(3, 2)]
		[DataRow(4, 3)]
		[DataTestMethod]
		public void TestMethod1(int N, int expected)
		{
			// Arrange
			FibonacciNumber question = new FibonacciNumber();

			// Act
			int actual = question.FibRecursive(N);

			// Assert
			Assert.AreEqual(expected, actual);
		}

		[DataRow(2, 1)]
		[DataRow(3, 2)]
		[DataRow(4, 3)]
		[DataTestMethod]
		public void TestMethod2(int N, int expected)
		{
			// Arrange
			FibonacciNumber question = new FibonacciNumber();

			// Act
			int actual = question.FibIterative(N);

			// Assert
			Assert.AreEqual(expected, actual);
		}
	}
}
