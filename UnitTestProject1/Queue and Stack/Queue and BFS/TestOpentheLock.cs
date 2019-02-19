using LeetCodeProblems.Queue_and_Stack.Queue_and_BFS;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1.Queue_and_Stack.Queue_and_BFS
{
	[TestClass]
	public class TestOpentheLock
	{
		[DataRow(new string[] { "0201", "0101", "0102", "1212", "2002" }, "0202", 6)]
		[DataRow(new string[] { "8888" }, "0009", 1)]
		[DataRow(new string[] { "8887", "8889", "8878", "8898", "8788", "8988", "7888", "9888" }, "8888", -1)]
		[DataRow(new string[] { "0000" }, "8888", -1)]
		[DataTestMethod]
		public void TestMethod1(string[] deadends, string target, int expected)
		{
			// Arrange
			OpentheLock question = new OpentheLock();

			// Act
			int actual = question.OpenLock(deadends, target);

			// Assert
			Assert.AreEqual(expected, actual);
		}
	}
}
