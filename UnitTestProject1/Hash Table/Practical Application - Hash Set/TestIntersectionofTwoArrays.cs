using LeetCodeProblems.Hash_Table.Practical_Application___Hash_Set;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests.Hash_Table.Practical_Application___Hash_Set
{
	[TestClass]
	public class TestIntersectionofTwoArrays
	{
		[DataRow(new int[] { 1, 2, 2, 1 }, new int[] { 2, 2 }, new int[] { 2 })]
		[DataRow(new int[] { 4, 9, 5 }, new int[] { 9, 4, 9, 8, 4 }, new int[] { 9 ,4 })]
		[DataTestMethod]
		public void TestMethod1(int[] nums1, int[] nums2, int[] expected)
		{
			// Arrange
			IntersectionofTwoArrays question = new IntersectionofTwoArrays();

			// Act
			int[] actual = question.Intersection(nums1, nums2);

			// Assert
			CollectionAssert.AreEqual(expected, actual);
		}
	}
}
