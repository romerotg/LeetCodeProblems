using LeetCodeProblems.Binary_Search.Background;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests.Binary_Search.Background
{
	[TestClass]
	public class TestBinarySearch
	{
		[DataRow(new int[] { -1, 0, 3, 5, 9, 12 }, 9, 4)]
		[DataRow(new int[] { -1, 0, 3, 5, 9, 12 }, 2, -1)]
		[DataRow(new int[] { 0, 1, 2, 3, 4, 5, 6 }, 5, 5)]
		[DataTestMethod]
		public void TestMethod1(int[] nums, int target, int expected)
		{
			// Arrange
			BinarySearch question = new BinarySearch();

			// Act
			int actual = question.Search(nums, target);

			// Assert
			Assert.AreEqual(expected, actual);
		}
	}
}
