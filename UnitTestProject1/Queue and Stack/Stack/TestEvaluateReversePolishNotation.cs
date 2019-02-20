using LeetCodeProblems.Queue_and_Stack.Stack;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests.Queue_and_Stack.Stack
{
	[TestClass]
	public class TestEvaluateReversePolishNotation
	{
		[DataRow(new string[] { "2", "1", "+", "3", "*" }, 9)]
		[DataRow(new string[] { "4", "13", "5", "/", "+" }, 6)]
		[DataRow(new string[] { "10", "6", "9", "3", "+", "-11", "*", "/", "*", "17", "+", "5", "+" }, 22)]
		[DataTestMethod]
		public void TestMethod1(string[] tokens, int expected)
		{
			// Arrange
			EvaluateReversePolishNotation question = new EvaluateReversePolishNotation();

			// Act
			int actual = question.EvalRPN(tokens);

			// Assert
			Assert.AreEqual(expected, actual);
		}
	}
}
