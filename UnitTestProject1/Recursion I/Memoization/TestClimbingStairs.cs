using LeetCodeProblems.Recursion_I.Memoization;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests.Recursion_I.Memoization
{
	[TestClass]
	public class TestClimbingStairs
	{
		[DataRow(1, 1)]
		[DataRow(2, 2)]
		[DataRow(3, 3)]
		[DataRow(4, 5)]
		[DataTestMethod]
		public void TestMethod1(int N, int expected)
		{
			// Arrange
			ClimbingStairs question = new ClimbingStairs();

			// Act
			int actual = question.ClimbStairsRecursive(N);

			// Assert
			Assert.AreEqual(expected, actual);
		}

		[DataRow(1, 1)]
		[DataRow(2, 2)]
		[DataRow(3, 3)]
		[DataRow(4, 5)]
		[DataTestMethod]
		public void TestMethod2(int N, int expected)
		{
			// Arrange
			ClimbingStairs question = new ClimbingStairs();

			// Act
			int actual = question.ClimbStairsIterative(N);

			// Assert
			Assert.AreEqual(expected, actual);
		}
	}
}
