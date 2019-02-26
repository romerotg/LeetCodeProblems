using LeetCodeProblems.Binary_Search.TemplateIII;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests.Binary_Search.TemplateIII
{
	[TestClass]
	public class TestSeachforaRange
	{
		[DataRow(new int[] { 5, 7, 7, 8, 8, 10 }, 8, new int[] { 3, 4 })]
		[DataRow(new int[] { 5, 7, 7, 8, 8, 10 }, 6, new int[] { -1, -1 })]
		[DataTestMethod]
		public void TestMethod1(int[] nums, int target, int[] expected)
		{
			// Arrange
			SeachforaRange question = new SeachforaRange();

			// Act
			int[] actual = question.SearchRange(nums, target);

			// Assert
			CollectionAssert.AreEqual(expected, actual);
		}
	}
}
