using LeetCodeProblems.Array_and_String.Introduction_to_Array;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests.Array_and_String.Introduction_to_Array
{
	[TestClass]
	public class TestFindPivotIndex
	{
		[DataRow(new int[] { 1, 7, 3, 6, 5, 6 }, 3)]
		[DataRow(new int[] { 1, 2, 3 }, -1)]
		[DataRow(new int[] { -1, -1, 0, 1, 1, 0 }, 5)]
		[DataTestMethod]
		public void TestMethod1(int[] nums, int expected)
		{
			// Arrange
			FindPivotIndex question = new FindPivotIndex();

			// Act
			int actual = question.PivotIndex(nums);

			// Assert
			Assert.AreEqual(expected, actual);
		}
	}
}
