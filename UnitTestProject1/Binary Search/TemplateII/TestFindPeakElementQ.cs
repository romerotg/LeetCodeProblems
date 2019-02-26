using LeetCodeProblems.Binary_Search.TemplateII;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests.Binary_Search.TemplateII
{
	[TestClass]
	public class TestFindPeakElementQ
	{
		[DataRow(new int[] { 1, 2, 3, 1 }, 2)]
		[DataRow(new int[] { 1, 2, 1, 3, 5, 6, 4 }, 5)]
		[DataRow(new int[] { 1 }, 0)]
		[DataTestMethod]
		public void TestMethod1(int[] nums, int expected)
		{
			// Arrange
			FindPeakElementQ question = new FindPeakElementQ();

			// Act
			int actual = question.FindPeakElement(nums);

			// Assert
			Assert.AreEqual(expected, actual);
		}
	}
}
