using LeetCodeProblems.Array_and_String.Introduction_to_Array;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests.Array_and_String.Introduction_to_Array
{
	[TestClass]
	public class TestLargestNumberAtLeastTwiceOfOthers
	{
		[DataRow(new int[] { 3, 6, 1, 0 }, 1)]
		[DataRow(new int[] { 1, 2, 3, 4 }, -1)]
		[DataRow(new int[] { 0, 2, 3, 0 }, -1)]
		[DataRow(new int[] { 1 }, 0)]
		[DataRow(new int[] { 0, 0, 3, 2 }, -1)]
		[DataTestMethod]
		public void TestMethod1(int[] nums, int expected)
		{
			// Arrange
			LargestNumberAtLeastTwiceOfOthers question = new LargestNumberAtLeastTwiceOfOthers();

			// Act
			int actual = question.DominantIndex(nums);

			// Assert
			Assert.AreEqual(expected, actual);
		}

		[DataRow(new int[] { 3, 6, 1, 0 }, 1)]
		[DataRow(new int[] { 1, 2, 3, 4 }, -1)]
		[DataRow(new int[] { 0, 2, 3, 0 }, -1)]
		[DataRow(new int[] { 1 }, 0)]
		[DataRow(new int[] { 0, 0, 3, 2 }, -1)]
		[DataTestMethod]
		public void TestMethod2(int[] nums, int expected)
		{
			// Arrange
			LargestNumberAtLeastTwiceOfOthers question = new LargestNumberAtLeastTwiceOfOthers();

			// Act
			int actual = question.DominantIndex2(nums);

			// Assert
			Assert.AreEqual(expected, actual);
		}
	}
}
