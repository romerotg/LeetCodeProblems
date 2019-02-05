using LeetCodeProblems.Array_and_String.Conclusion;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1.Array_and_String.Conclusion
{
	[TestClass]
	public class TestRotateArray
	{
		[DataRow(new int[] { 1, 2, 3, 4, 5, 6, 7 }, 3, new int[] { 5, 6, 7, 1, 2, 3, 4 })]
		[DataRow(new int[] { -1, -100, 3, 99 }, 2, new int[] { 3, 99, -1, -100 })]
		[DataRow(new int[] { 1, 2, 3 }, 4, new int[] { 3, 1, 2 })]
		[DataTestMethod]
		public void TestMethod1(int[] nums, int k, int[] expected)
		{
			// Arrange
			RotateArray question = new RotateArray();

			// Act
			question.Rotate(nums, k);

			// Assert
			CollectionAssert.AreEqual(expected, nums);
		}

		[DataRow(new int[] { 1, 2, 3, 4, 5, 6, 7 }, 3, new int[] { 5, 6, 7, 1, 2, 3, 4 })]
		[DataRow(new int[] { -1, -100, 3, 99 }, 2, new int[] { 3, 99, -1, -100 })]
		[DataRow(new int[] { 1, 2, 3 }, 4, new int[] { 3, 1, 2 })]
		[DataTestMethod]
		public void TestMethod2(int[] nums, int k, int[] expected)
		{
			// Arrange
			RotateArray question = new RotateArray();

			// Act
			question.Rotate2(nums, k);

			// Assert
			CollectionAssert.AreEqual(expected, nums);
		}
	}
}
