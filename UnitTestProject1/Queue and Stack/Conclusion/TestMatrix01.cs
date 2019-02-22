using LeetCodeProblems.Queue_and_Stack.Conclusion;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests.Queue_and_Stack.Conclusion
{
	[TestClass]
	public class TestMatrix01
	{
		[TestMethod]
		public void TestMethod1()
		{
			// Arrange
			Matrix01 question = new Matrix01();
			int[,] matrix = new int[,]
				{
					{ 0,0,0 },
					{ 0,1,0 },
					{ 0,0,0 }
				};
			int[,] expected = new int[,]
				{
					{ 0,0,0 },
					{ 0,1,0 },
					{ 0,0,0 }
				};

			// Act
			int[,] actual = question.UpdateMatrix(matrix);

			// Assert
			CollectionAssert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void TestMethod2()
		{
			// Arrange
			Matrix01 question = new Matrix01();
			int[,] matrix = new int[,]
				{
					{ 0,0,0 },
					{ 0,1,0 },
					{ 1,1,1 }
				};
			int[,] expected = new int[,]
				{
					{ 0,0,0 },
					{ 0,1,0 },
					{ 1,2,1 }
				};

			// Act
			int[,] actual = question.UpdateMatrix(matrix);

			// Assert
			CollectionAssert.AreEqual(expected, actual);
		}
	}
}
