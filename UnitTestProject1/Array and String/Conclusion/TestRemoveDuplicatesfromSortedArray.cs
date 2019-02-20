using LeetCodeProblems.Array_and_String.Conclusion;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests.Array_and_String.Conclusion
{
	[TestClass]
	public class TestRemoveDuplicatesfromSortedArray
	{
		[DataRow(new int[] { 1, 1, 2 }, 2)]
		[DataRow(new int[] { 0, 0, 1, 1, 1, 2, 2, 3, 3, 4 }, 5)]
		[DataTestMethod]
		public void TestMethod1(int[] nums, int expected)
		{
			// Arrange
			RemoveDuplicatesfromSortedArray question = new RemoveDuplicatesfromSortedArray();

			// Act
			int actual = question.RemoveDuplicates(nums);

			// Assert
			Assert.AreEqual(expected, actual);
		}
	}
}
