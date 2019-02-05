using LeetCodeProblems.Hash_Table.Practical_Application___Hash_Set;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1.Hash_Table.Practical_Application___Hash_Set
{
	[TestClass]
	public class TestContainsDuplicateQ
	{
		[DataRow(new int[] { 0, 1, 0, 3, 12 }, true)]
		[DataRow(new int[] { 1, 2, 3, 1 }, true)]
		[DataRow(new int[] { 1, 2, 3, 4 }, false)]
		[DataRow(new int[] { 1, 1, 1, 3, 3, 4, 3, 2, 4, 2 }, true)]
		[DataTestMethod]
		public void TestMethod1(int[] nums, bool expected)
		{
			// Arrange
			ContainsDuplicateQ question = new ContainsDuplicateQ();

			// Act
			bool actual = question.ContainsDuplicate(nums);

			// Assert
			Assert.AreEqual(expected, actual);
		}
	}
}
