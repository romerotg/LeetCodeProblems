using LeetCodeProblems.Array_and_String.Two_Pointer_Technique;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests.Array_and_String.Two_Pointer_Technique
{
	[TestClass]
	public class TestTwoSumII
	{
		[DataRow(new int[] { 2, 7, 11, 15 }, 9, new int[] { 1, 2 })]
		[DataTestMethod]
		public void TestMethod1(int[] numbers, int target, int[] expected)
		{
			// Arrange
			TwoSumII question = new TwoSumII();

			// Act
			int[] actual = question.TwoSum(numbers, target);

			// Assert
			CollectionAssert.AreEqual(expected, actual);
		}

		[DataRow(new int[] { 2, 7, 11, 15 }, 9, new int[] { 1, 2 })]
		[DataTestMethod]
		public void TestMethod2(int[] numbers, int target, int[] expected)
		{
			// Arrange
			TwoSumII question = new TwoSumII();

			// Act
			int[] actual = question.TwoSum2(numbers, target);

			// Assert
			CollectionAssert.AreEqual(expected, actual);
		}
	}
}
