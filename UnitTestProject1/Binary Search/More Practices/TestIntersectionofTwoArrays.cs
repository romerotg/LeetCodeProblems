using LeetCodeProblems.Binary_Search.More_Practices;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Tests.Binary_Search.More_Practices
{
	[TestClass]
	public class TestIntersectionofTwoArrays
	{
		[DataRow(new int[] { 1, 2, 2, 1 }, new int[] { 2, 2 }, new int[] { 2 })]
		[DataRow(new int[] { 4, 9, 5 }, new int[] { 9, 4, 9, 8, 4 }, new int[] { 4, 9 })]
		[DataRow(null, new int[] { 1 }, null)]
		[DataRow(new int[] { 1 }, null, null)]
		[DataTestMethod]
		public void TestMethod1(int[] nums1, int[] nums2, int[] expected)
		{
			// Arrange
			IntersectionofTwoArrays question = new IntersectionofTwoArrays();

			// Act
			int[] actual = question.Intersection(nums1, nums2);
			if (actual != null)
				Array.Sort(actual);

			// Assert
			CollectionAssert.AreEqual(expected, actual);
		}
	}
}
