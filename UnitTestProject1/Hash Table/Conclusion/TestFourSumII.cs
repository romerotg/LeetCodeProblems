using LeetCodeProblems.Hash_Table.Conclusion;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests.Hash_Table.Conclusion
{
	[TestClass]
	public class TestFourSumII
	{
		[DataRow(new int[] { 1, 2 }, new int[] { -2, -1 }, new int[] { -1, 2 }, new int[] { 0, 2 }, 2)]
		[DataTestMethod]
		public void TestMethod1(int[] A, int[] B, int[] C, int[] D, int expected)
		{
			// Arrange
			FourSumII question = new FourSumII();

			// Act
			int actual = question.FourSumCount(A, B, C, D);

			// Assert
			Assert.AreEqual(expected, actual);
		}
	}
}
