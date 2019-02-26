using LeetCodeProblems.Binary_Search.TemplateII;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests.Binary_Search.TemplateII
{
	[TestClass]
	public class TestFindMinimuminRotatedSortedArray
	{
		[DataRow(new int[] { 3, 4, 5, 1, 2 }, 1)]
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
			FindMinimuminRotatedSortedArray question = new FindMinimuminRotatedSortedArray();

			// Act
			int actual = question.FindMin(nums);

			// Assert
			Assert.AreEqual(expected, actual);
		}
	}
}
