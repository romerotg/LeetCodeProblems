using LeetCodeProblems.Queue_and_Stack.Conclusion;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests.Queue_and_Stack.Conclusion
{
	[TestClass]
	public class TestFloodFillQ
	{
		[TestMethod]
		public void TestMethod1()
		{
			// Arrange
			FloodFillQ question = new FloodFillQ();
			int[,] image = new int[,]
				{
					{ 1, 1, 1 },
					{ 1, 1, 0 },
					{ 1, 0, 1 }
				};
			int sr = 1;
			int sc = 1;
			int newColor = 2;
			int[,] expected = new int[,]
				{
					{ 2, 2, 2 },
					{ 2, 2, 0 },
					{ 2, 0, 1 }
				};

			// Act
			int[,] actual = question.FloodFill(image, sr, sc, newColor);

			// Assert
			CollectionAssert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void TestMethod2()
		{
			// Arrange
			FloodFillQ question = new FloodFillQ();
			int[,] image = new int[,]
				{
					{ 0,0,0 },
					{ 0,1,1 }
				};
			int sr = 1;
			int sc = 1;
			int newColor = 1;
			int[,] expected = new int[,]
				{
					{ 0,0,0 },
					{ 0,1,1 }
				};

			// Act
			int[,] actual = question.FloodFill(image, sr, sc, newColor);

			// Assert
			CollectionAssert.AreEqual(expected, actual);
		}
	}
}
