using LeetCodeProblems.Array_and_String.Two_Pointer_Technique;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1.Array_and_String.Two_Pointer_Technique
{
	[TestClass]
	public class TestRemoveElementQ
	{
		[DataRow(new int[] { 3, 2, 2, 3 }, 3, 2)]
		[DataRow(new int[] { 0, 1, 2, 2, 3, 0, 4, 2 }, 2, 5)]
		[DataTestMethod]
		public void TestMethod1(int[] nums, int val, int expected)
		{
			// Arrange
			RemoveElementQ question = new RemoveElementQ();

			// Act
			int actual = question.RemoveElement(nums, val);

			// Assert
			Assert.AreEqual(expected, actual);
		}
	}
}
