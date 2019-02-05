using LeetCodeProblems.Array_and_String.Two_Pointer_Technique;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1.Array_and_String.Two_Pointer_Technique
{
	[TestClass]
	public class TestArrayPartitionI
	{
		[DataRow(new int[] { 1, 4, 3, 2 }, 4)]
		[DataRow(new int[] { 7, 4, 4, 2 }, 6)]
		[DataRow(new int[] { 7, 5, 4, 2 }, 7)]
		[DataTestMethod]
		public void TestMethod1(int[] nums, int expected)
		{
			// Arrange
			ArrayPartitionI question = new ArrayPartitionI();

			// Act
			int actual = question.ArrayPairSum(nums);

			// Assert
			Assert.AreEqual(expected, actual);
		}
	}
}
