using LeetCodeProblems.Array_and_String.Two_Pointer_Technique;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests.Array_and_String.Two_Pointer_Technique
{
	[TestClass]
	public class TestMinimumSizeSubarraySum
	{
		[DataRow(7, new int[] { 2, 3, 1, 2, 4, 3 }, 2)]
		[DataRow(213, new int[] { 12, 28, 83, 4, 25, 26, 25, 2, 25, 25, 25, 12 }, 8)]
		[DataTestMethod]
		public void TestMethod1(int s, int[] nums, int expected)
		{
			// Arrange
			MinimumSizeSubarraySum question = new MinimumSizeSubarraySum();

			// Act
			int actual = question.MinSubArrayLen(s, nums);

			// Assert
			Assert.AreEqual(expected, actual);
		}
	}
}
