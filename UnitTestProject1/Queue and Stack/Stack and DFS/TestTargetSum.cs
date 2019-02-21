using LeetCodeProblems.Queue_and_Stack.Stack_and_DFS;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests.Queue_and_Stack.Stack_and_DFS
{
	[TestClass]
	public class TestTargetSum
	{
		[DataRow(new int[] { 1, 1, 1, 1, 1 }, 3, 5)]
		[DataTestMethod]
		public void TestMethod1(int[] nums, int S, int expected)
		{
			// Arrange
			TargetSum question = new TargetSum();

			// Act
			int actual = question.FindTargetSumWays(nums, S);

			// Assert
			Assert.AreEqual(expected, actual);
		}
	}
}
