using LeetCodeProblems.Array_and_String.Introduction_to_Array;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests.Array_and_String.Introduction_to_Array
{
	[TestClass]
	public class TestPlusOneQ
	{
		[DataRow(new int[] { 1, 2, 3 }, new int[] { 1, 2, 4 })]
		[DataRow(new int[] { 4, 3, 2, 2 }, new int[] { 4, 3, 2, 3 })]
		[DataRow(new int[] { 1, 0, 9 }, new int[] { 1, 1, 0 })]
		[DataRow(new int[] { 9, 9, 9, 9 }, new int[] { 1, 0, 0, 0, 0 })]
		[DataTestMethod]
		public void TestMethod1(int[] nums, int[] expected)
		{
			// Arrange
			PlusOneQ question = new PlusOneQ();

			// Act
			int[] actual = question.PlusOne(nums);

			// Assert
			CollectionAssert.AreEqual(expected, actual);
		}
	}
}
