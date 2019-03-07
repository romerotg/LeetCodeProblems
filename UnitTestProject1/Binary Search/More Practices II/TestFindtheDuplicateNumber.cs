using LeetCodeProblems.Binary_Search.More_Practices_II;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests.Binary_Search.More_Practices_II
{
	[TestClass]
	public class TestFindtheDuplicateNumber
	{
		[DataRow(new int[] { 1, 2, 3, 2, 2 }, 2)]
		[DataRow(new int[] { 3, 1, 3, 4, 2 }, 3)]
		[DataTestMethod]
		public void TestMethod1(int[] nums, int expected)
		{
			// Arrange
			FindtheDuplicateNumber question = new FindtheDuplicateNumber();

			// Act
			int actual = question.FindDuplicate(nums);

			// Assert
			Assert.AreEqual(expected, actual);
		}
	}
}
