using LeetCodeProblems.Array_and_String.Introduction_to_2D_Array;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests.Array_and_String.Introduction_to_2D_Array
{
	[TestClass]
	public class TestDiagonalTransverse
	{
		[TestMethod]
		public void TestMethod1()
		{
			// Arrange
			DiagonalTransverse question = new DiagonalTransverse();
			int[,] matrix = new int[,] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
			int[] expected = { 1, 2, 4, 7, 5, 3, 6, 8, 9 };

			// Act
			int[] actual = question.FindDiagonalOrder(matrix);

			// Assert
			CollectionAssert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void TestMethod2()
		{
			// Arrange
			DiagonalTransverse question = new DiagonalTransverse();
			int[,] matrix = new int[,] { { 6, 9, 7 } };
			int[] expected = { 6, 9, 7 };

			// Act
			int[] actual = question.FindDiagonalOrder(matrix);

			// Assert
			CollectionAssert.AreEqual(expected, actual);
		}
	}
}
