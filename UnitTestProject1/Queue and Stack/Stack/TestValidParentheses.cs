using LeetCodeProblems.Queue_and_Stack.Stack;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests.Queue_and_Stack.Stack
{
	[TestClass]
	public class TestValidParentheses
	{
		[DataRow("()", true)]
		[DataRow("()[]{}", true)]
		[DataRow("(]", false)]
		[DataRow("([)]", false)]
		[DataRow("{[]}", true)]
		[DataTestMethod]
		public void TestMethod1(string s, bool expected)
		{
			// Arrange
			ValidParentheses question = new ValidParentheses();

			// Act
			bool actual = question.IsValid(s);

			// Assert
			Assert.AreEqual(expected, actual);
		}
	}
}
