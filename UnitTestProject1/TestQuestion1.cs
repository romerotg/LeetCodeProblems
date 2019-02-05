using System;
using LeetCodeProblems;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
	[TestClass]
	public class TestQuestion1
	{
		[DataRow(new int[] { 2, 7, 11, 15 }, 9, new int[] { 0, 1 })]
		[DataRow(new int[] { 5, 8, 3, 9 }, 17, new int[] { 1, 3 })]
		[DataTestMethod]
		public void TestMethod1(int[] nums, int target, int[] expected)
		{
			// Arrange
			Question1 question = new Question1();

			// Act
			int[] actual = question.TwoSum(nums, target);

			// Assert
			//Assert.AreEqual(expected, actual);
			CollectionAssert.AreEqual(expected, actual);
		}

		[DataRow(new int[] { 2, 7, 11, 15 }, 9, new int[] { 0, 1 })]
		[DataRow(new int[] { 5, 8, 3, 9 }, 17, new int[] { 1, 3 })]
		[DataTestMethod]
		public void TestMethod2(int[] nums, int target, int[] expected)
		{
			// Arrange
			Question1 question = new Question1();

			// Act
			int[] actual = question.TwoSum2(nums, target);

			// Assert
			CollectionAssert.AreEqual(expected, actual);
		}
	}
}
