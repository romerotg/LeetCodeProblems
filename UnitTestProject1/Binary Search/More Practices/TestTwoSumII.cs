using LeetCodeProblems.Binary_Search.More_Practices;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Tests.Binary_Search.More_Practices
{
	[TestClass]
	public class TestTwoSumII
	{
		[DataRow(new int[] { 2, 7, 11, 15 }, 9, new int[] { 1, 2 })]
		[DataTestMethod]
		public void TestMethod1(int[] numbers, int target, int[] expected)
		{
			// Arrange
			TwoSumII question = new TwoSumII();

			// Act
			int[] actual = question.TwoSum(numbers, target);
			if (actual != null)
				Array.Sort(actual);

			// Assert
			CollectionAssert.AreEqual(expected, actual);
		}
	}
}
