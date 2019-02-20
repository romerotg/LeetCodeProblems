using LeetCodeProblems.Queue_and_Stack.Stack_and_DFS;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests.Queue_and_Stack.Stack_and_DFS
{
	[TestClass]
	public class TestNumberofIslands
	{
		[TestMethod]
		public void TestMethod1()
		{
			// Arrange
			char[,] grid = new char[,]
			{
				{ '1', '1', '1', '1', '0' },
				{ '1', '1', '0', '1', '0' },
				{ '1', '1', '0', '0', '0' },
				{ '0', '0', '0', '0', '0' },
			};
			int expected = 1;
			NumberofIslands question = new NumberofIslands();

			// Act
			int actual = question.NumIslands(grid);

			// Assert
			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void TestMethod2()
		{
			// Arrange
			char[,] grid = new char[,]
			{
				{ '1', '1', '0', '0', '0' },
				{ '1', '1', '0', '0', '0' },
				{ '0', '0', '1', '0', '0' },
				{ '0', '0', '0', '1', '1' },
			};
			int expected = 3;
			NumberofIslands question = new NumberofIslands();

			// Act
			int actual = question.NumIslands(grid);

			// Assert
			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void TestMethod3()
		{
			// Arrange
			char[,] grid = new char[,]
			{
				{'1', '1', '1'},
				{'0', '1', '0'},
				{'0', '1', '0'}
			};
			int expected = 1;
			NumberofIslands question = new NumberofIslands();

			// Act
			int actual = question.NumIslands(grid);

			// Assert
			Assert.AreEqual(expected, actual);
		}
	}
}
