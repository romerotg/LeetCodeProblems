using LeetCodeProblems.Array_and_String.Conclusion;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests.Array_and_String.Conclusion
{
	[TestClass]
	public class TestPascalTriangleII
	{
		[DataRow(0, new int[] { 1 })]
		[DataRow(1, new int[] { 1, 1 })]
		[DataRow(2, new int[] { 1, 2, 1 })]
		[DataRow(3, new int[] { 1, 3, 3, 1 })]
		[DataRow(4, new int[] { 1, 4, 6, 4, 1 })]
		[DataTestMethod]
		public void TestMethod1(int rowIndex, int[] expected)
		{
			// Arrange
			PascalTriangleII question = new PascalTriangleII();

			// Act
			int[] actual = question.GetRow(rowIndex) as int[];

			// Assert
			CollectionAssert.AreEqual(expected, actual);
		}
	}
}
