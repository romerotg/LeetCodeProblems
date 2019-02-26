using LeetCodeProblems.Binary_Search.TemplateI;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests.Binary_Search.TemplateI
{
	[TestClass]
	public class TestSearchinRotatedSortedArray
	{
		[DataRow(new int[] { 4, 5, 6, 7, 0, 1, 2 }, 0, 4)]
		[DataRow(new int[] { 4, 5, 6, 7, 0, 1, 2 }, 3, -1)]
		[DataRow(new int[] { 5, 1, 3 }, 5, 0)]
		[DataRow(new int[] { 4, 5, 6, 7, 8, 1, 2, 3 }, 8, 4)]
		[DataRow(new int[] { 3, 4, 5, 6, 7, 8, 1, 2 }, 7, 4)]
		[DataTestMethod]
		public void TestMethod1(int[] nums, int target, int expected)
		{
			// Arrange
			SearchinRotatedSortedArray question = new SearchinRotatedSortedArray();

			// Act
			int actual = question.Search(nums, target);

			// Result
			Assert.AreEqual(expected, actual);
		}
	}
}
