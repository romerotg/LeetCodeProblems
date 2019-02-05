using LeetCodeProblems.Hash_Table.Practical_Application___Hash_Map;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1.Hash_Table.Practical_Application___Hash_Map
{
	[TestClass]
	public class TestTwoSumQ
	{
		[DataRow(new int[] { 2, 7, 11, 15 }, 9, new int[] { 0, 1 })]
		[DataTestMethod]
		public void TestMethod1(int[] nums, int target, int[] expected)
		{
			// Arrange
			TwoSumQ question = new TwoSumQ();

			// Act
			int[] actual = question.TwoSum(nums, target);

			// Assert
			CollectionAssert.AreEqual(expected, actual);
		}
	}
}
