using LeetCodeProblems.Hash_Table.Practical_Application___Hash_Map;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTestProject1.Hash_Table.Practical_Application___Hash_Map
{
	[TestClass]
	public class TestIntersectionofTwoArraysII
	{
		[DataRow(new int[] { 1, 2, 2, 1 }, new int[] { 2, 2 }, new int[] { 2, 2 })]
		[DataRow(new int[] { 4, 9, 5 }, new int[] { 9, 4, 9, 8, 4 }, new int[] { 4, 9 })]
		[DataTestMethod]
		public void TestMethod1(int[] nums1, int[] nums2, int[] expected)
		{
			// Arrange
			IntersectionofTwoArraysII question = new IntersectionofTwoArraysII();

			// Act
			int[] actual = question.Intersect(nums1, nums2);

			// Assert
			if (expected != null)
				Array.Sort(expected);
			if (actual != null)
				Array.Sort(actual);
			CollectionAssert.AreEqual(expected,actual);
		}
	}
}
