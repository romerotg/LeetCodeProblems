using LeetCodeProblems.Hash_Table.Practical_Application___Hash_Set;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1.Hash_Table.Practical_Application___Hash_Set
{
	[TestClass]
	public class TestSingleNumberQ
	{
		[DataRow(new int[] { 2, 2, 1 }, 1)]
		[DataRow(new int[] { 4, 1, 2, 1, 2 }, 4)]
		[DataTestMethod]
		public void TestMethod1(int[] nums, int expected)
		{
			// Arrange
			SingleNumberQ question = new SingleNumberQ();

			// Act
			int actual = question.SingleNumber(nums);

			// Assert
			Assert.AreEqual(expected, actual);
		}

		[DataRow(new int[] { 2, 2, 1 }, 1)]
		[DataRow(new int[] { 4, 1, 2, 1, 2 }, 4)]
		[DataTestMethod]
		public void TestMethod2(int[] nums, int expected)
		{
			// Arrange
			SingleNumberQ question = new SingleNumberQ();

			// Act
			int actual = question.SingleNumber2(nums);

			// Assert
			Assert.AreEqual(expected, actual);
		}
	}
}
