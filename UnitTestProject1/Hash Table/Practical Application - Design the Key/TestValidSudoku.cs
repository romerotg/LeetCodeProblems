using LeetCodeProblems.Hash_Table.Practical_Application___Design_the_Key;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1.Hash_Table.Practical_Application___Design_the_Key
{
	[TestClass]
	public class TestValidSudoku
	{
		[TestMethod]
		public void TestMethod1()
		{
			// Arrange
			ValidSudoku question = new ValidSudoku();
			char[,] board = new char[,]
			{
				{ '5', '3', '.', '.', '7', '.', '.', '.', '.' },
				{ '6', '.', '.', '1', '9', '5', '.', '.', '.' },
				{ '.', '9', '8', '.', '.', '.', '.', '6', '.' },
				{ '8', '.', '.', '.', '6', '.', '.', '.', '3' },
				{ '4', '.', '.', '8', '.', '3', '.', '.', '1' },
				{ '7', '.', '.', '.', '2', '.', '.', '.', '6' },
				{ '.', '6', '.', '.', '.', '.', '2', '8', '.' },
				{ '.', '.', '.', '4', '1', '9', '.', '.', '5' },
				{ '.', '.', '.', '.', '8', '.', '.', '7', '9' }
			};
			bool expected = true;

			// Act
			bool actual = question.IsValidSudoku(board);

			// Assert
			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void TestMethod2()
		{
			// Arrange
			ValidSudoku question = new ValidSudoku();
			char[,] board = new char[,]
			{
			  { '8', '3', '.', '.', '7', '.', '.', '.', '.' },
			  { '6', '.', '.', '1', '9', '5', '.', '.', '.' },
			  { '.', '9', '8', '.', '.', '.', '.', '6', '.' },
			  { '8', '.', '.', '.', '6', '.', '.', '.', '3' },
			  { '4', '.', '.', '8', '.', '3', '.', '.', '1' },
			  { '7', '.', '.', '.', '2', '.', '.', '.', '6' },
			  { '.', '6', '.', '.', '.', '.', '2', '8', '.' },
			  { '.', '.', '.', '4', '1', '9', '.', '.', '5' },
			  { '.', '.', '.', '.', '8', '.', '.', '7', '9' }
			};
			bool expected = false;

			// Act
			bool actual = question.IsValidSudoku(board);

			// Assert
			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void TestMethod3()
		{
			// Arrange
			ValidSudoku question = new ValidSudoku();
			char[,] board = new char[,]
			{
				{ '.', '.', '.', '.', '5', '.', '.', '1', '.' },
				{ '.', '4', '.', '3', '.', '.', '.', '.', '.' },
				{ '.', '.', '.', '.', '.', '3', '.', '.', '1' },
				{ '8', '.', '.', '.', '.', '.', '.', '2', '.' },
				{ '.', '.', '2', '.', '7', '.', '.', '.', '.' },
				{ '.', '1', '5', '.', '.', '.', '.', '.', '.' },
				{ '.', '.', '.', '.', '.', '2', '.', '.', '.' },
				{ '.', '2', '.', '9', '.', '.', '.', '.', '.' },
				{ '.', '.', '4', '.', '.', '.', '.', '.', '.' }
			};
			bool expected = false;

			// Act
			bool actual = question.IsValidSudoku(board);

			// Assert
			Assert.AreEqual(expected, actual);
		}
	}
}
