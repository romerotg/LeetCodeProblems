using LeetCodeProblems.Array_and_String.Two_Pointer_Technique;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1.Array_and_String.Two_Pointer_Technique
{
	[TestClass]
	public class TestMaxConsecutiveOnes
	{
		[DataRow(new int[] { 1, 1, 0, 1, 1, 1 }, 3)]
		[DataRow(null, 0)]
		[DataRow(new int[] { }, 0)]
		[DataRow(new int[] { 0, 2, 3, 4, 5, 6 }, 0)]
		[DataRow(new int[] { 0, 1, 0, 1, 1, 0, 1 }, 2)]
		[DataTestMethod]
		public void TestMethod1(int[] nums, int expected)
		{
			// Arrange
			MaxConsecutiveOnes question = new MaxConsecutiveOnes();

			// Act
			int actual = question.FindMaxConsecutiveOnes(nums);

			// Assert
			Assert.AreEqual(expected, actual);
		}
	}
}
