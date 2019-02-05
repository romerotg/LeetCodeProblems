using LeetCodeProblems.Array_and_String.Introduction_to_2D_Array;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestProject1.Array_and_String.Introduction_to_2D_Array
{
	[TestClass]
	public class TestSpiralMatrix
	{
		[TestMethod]
		public void TestMethod1()
		{
			// Arrange
			SpiralMatrix question = new SpiralMatrix();
			int[,] matrix = new int[,] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
			IList<int> expected = new int[] { 1, 2, 3, 6, 9, 8, 7, 4, 5 };

			// Act
			IList<int> actual = question.SpiralOrder(matrix);

			// Assert
			CollectionAssert.AreEqual((int[])expected, (int[])actual);
		}

		[TestMethod]
		public void TestMethod2()
		{
			// Arrange
			SpiralMatrix question = new SpiralMatrix();
			int[,] matrix = new int[,] { { 1, 2, 3, 4 }, { 5, 6, 7, 8 }, { 9, 10, 11, 12 } };
			IList<int> expected = new int[] { 1, 2, 3, 4, 8, 12, 11, 10, 9, 5, 6, 7 };

			// Act
			IList<int> actual = question.SpiralOrder(matrix);

			// Assert
			CollectionAssert.AreEqual((int[])expected, (int[])actual);
		}
	}
}
