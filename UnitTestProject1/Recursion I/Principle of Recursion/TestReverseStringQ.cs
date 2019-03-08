using LeetCodeProblems.Recursion_I.Principle_of_Recursion;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests.Recursion_I.Principle_of_Recursion
{
	[TestClass]
	public class TestReverseStringQ
	{
		[DataRow(new char[] { 'h', 'e', 'l', 'l', 'o' }, new char[] { 'o', 'l', 'l', 'e', 'h' })]
		[DataRow(new char[] { 'H', 'a', 'n', 'n', 'a', 'h' }, new char[] { 'h', 'a', 'n', 'n', 'a', 'H' })]
		[DataTestMethod]
		public void TestMethod1(char[] s, char[] expected)
		{
			// Arrange
			ReverseStringQ question = new ReverseStringQ();

			// Act
			question.ReverseString(s);

			// Assert
			CollectionAssert.AreEqual(expected, s);
		}
	}
}
