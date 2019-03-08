using LeetCodeProblems.Recursion_I.Recurrence_Relation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests.Recursion_I.Recurrence_Relation
{
	[TestClass]
	public class TestPascalTriangleII
	{
		//[DataRow(0, new int[] { 1 })]
		//[DataRow(1, new int[] { 1, 1 })]
		//[DataRow(2, new int[] { 1, 2, 1 })]
		//[DataRow(3, new int[] { 1, 3, 3, 1 })]
		//[DataRow(4, new int[] { 1, 4, 6, 4, 1 })]
		[DataRow(30, new int[] { 1, 30, 435, 4060, 27405, 142506, 593775, 2035800, 5852925, 14307150, 30045015, 54627300, 86493225, 119759850, 145422675, 155117520, 145422675, 119759850, 86493225, 54627300, 30045015, 14307150, 5852925, 2035800, 593775, 142506, 27405, 4060, 435, 30, 1 })]
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
