using LeetCodeProblems.Binary_Search.More_Practices;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests.Binary_Search.More_Practices
{
	[TestClass]
	public class TestFindMinimuminRotatedSortedArrayII
	{
		[DataRow(new int[] { 3, 3, 1, 3 }, 1)]
		[DataRow(new int[] { 1, 3, 5 }, 1)]
		[DataRow(new int[] { 2, 2, 2, 0, 1 }, 0)]
		[DataRow(new int[] { 2, 2, 2, 2, 2 }, 2)]
		[DataRow(new int[] { 4, 5, 1, 2, 3 }, 1)]
		[DataRow(new int[] { 0, 1, 2, 4, 5, 6, 7 }, 0)]
		[DataRow(new int[] { 1, 2, 4, 5, 6, 7, 0 }, 0)]
		[DataRow(new int[] { 2, 4, 5, 6, 7, 0, 1 }, 0)]
		[DataRow(new int[] { 4, 5, 6, 7, 0, 1, 2 }, 0)]
		[DataRow(new int[] { 5, 6, 7, 0, 1, 2, 4 }, 0)]
		[DataRow(new int[] { 6, 7, 0, 1, 2, 4, 5 }, 0)]
		[DataRow(new int[] { 7, 0, 1, 2, 4, 5, 6 }, 0)]
		[DataTestMethod]
		public void TestMethod1(int[] nums, int expected)
		{
			// Arrange
			FindMinimuminRotatedSortedArrayII question = new FindMinimuminRotatedSortedArrayII();

			// Act
			int actual = question.FindMin(nums);

			// Assert
			Assert.AreEqual(expected, actual);
		}
	}
}
