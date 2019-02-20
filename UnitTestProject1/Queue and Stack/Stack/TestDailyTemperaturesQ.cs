using LeetCodeProblems.Queue_and_Stack.Stack;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests.Queue_and_Stack.Stack
{
	[TestClass]
	public class TestDailyTemperaturesQ
	{
		[DataRow(new int[] { 73, 74, 75, 71, 69, 72, 76, 73 }, new int[] { 1, 1, 4, 2, 1, 1, 0, 0 })]
		[DataTestMethod]
		public void TestMethod1(int[] T, int[] expected)
		{
			// Arrange
			DailyTemperaturesQ question = new DailyTemperaturesQ();

			// Act
			int[] actual = question.DailyTemperatures(T);

			// Assert
			CollectionAssert.AreEqual(expected, actual);
		}
	}
}
