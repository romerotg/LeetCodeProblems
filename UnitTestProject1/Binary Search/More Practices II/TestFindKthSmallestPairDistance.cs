using LeetCodeProblems.Binary_Search.More_Practices_II;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests.Binary_Search.More_Practices_II
{
	[TestClass]
	public class TestFindKthSmallestPairDistance
	{
		[DataRow(new int[] { 1, 3, 1 }, 1, 0)]
		[DataRow(new int[] { 62, 100, 4 }, 2, 58)]
		[DataTestMethod]
		public void TestMethod1(int[] nums, int k, int expected)
		{
			// Arrange
			FindKthSmallestPairDistance question = new FindKthSmallestPairDistance();

			// Act
			int actual = question.SmallestDistancePair(nums, k);

			// Assert
			Assert.AreEqual(expected, actual);
		}
	}
}
