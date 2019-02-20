using LeetCodeProblems.Hash_Table.Practical_Application___Hash_Map;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests.Hash_Table.Practical_Application___Hash_Map
{
	[TestClass]
	public class TestContainsDuplicateII
	{
		[DataRow(new int[] { 1, 2, 3, 1 }, 3, true)]
		[DataRow(new int[] { 1, 0, 1, 1 }, 1, true)]
		[DataRow(new int[] { 1, 2, 3, 1, 2, 3 }, 2, false)]
		[DataTestMethod]
		public void TestMethod1(int[] nums, int k, bool expected)
		{
			// Arrange
			ContainsDuplicateII question = new ContainsDuplicateII();

			// Act
			bool actual = question.ContainsNearbyDuplicate(nums, k);

			// Assert
			Assert.AreEqual(expected, actual);
		}
	}
}
