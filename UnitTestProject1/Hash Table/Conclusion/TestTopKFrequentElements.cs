using LeetCodeProblems.Hash_Table.Conclusion;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Tests.Hash_Table.Conclusion
{
	[TestClass]
	public class TestTopKFrequentElements
	{
		[DataRow(new int[] { 1, 1, 1, 2, 2, 3 }, 2, new int[] { 1, 2 })]
		[DataRow(new int[] { 1 }, 1, new int[] { 1 })]
		[DataTestMethod]
		public void TestMethod1(int[] nums, int k, int[] expected)
		{
			// Arrange
			TopKFrequentElements question = new TopKFrequentElements();

			// Act
			IList<int> actual = question.TopKFrequent(nums, k);

			// Assert
			CollectionAssert.AreEqual(new List<int>(expected), new List<int>(actual));
		}
	}
}
