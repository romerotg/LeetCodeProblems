using LeetCodeProblems.Array_and_String.Conclusion;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests.Array_and_String.Conclusion
{
	[TestClass]
	public class TestMoveZeroesQ
	{
		[DataRow(new int[] { 0, 1, 0, 3, 12 }, new int[] { 1, 3, 12, 0, 0 })]
		[DataRow(null, null)]
		[DataRow(new int[] { 0 }, new int[] { 0 })]
		[DataRow(new int[] { 1, 2, 3, 4, 5 }, new int[] { 1, 2, 3, 4, 5 })]
		[DataRow(new int[] { 0, 1 }, new int[] { 1, 0 })]
		[DataTestMethod]
		public void TestMethod1(int[] nums, int[] expected)
		{
			// Arrange
			MoveZeroesQ question = new MoveZeroesQ();

			// Act
			question.MoveZeroes(nums);

			// Assert
			CollectionAssert.AreEqual(expected, nums);
		}
	}
}
