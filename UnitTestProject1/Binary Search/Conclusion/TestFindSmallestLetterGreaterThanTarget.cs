using LeetCodeProblems.Binary_Search.Conclusion;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests.Binary_Search.Conclusion
{
	[TestClass]
	public class TestFindSmallestLetterGreaterThanTarget
	{
		//[DataRow(new char[] { 'c', 'f', 'j' }, 'a', 'c')]
		[DataRow(new char[] { 'c', 'f', 'j' }, 'c', 'f')]
		[DataRow(new char[] { 'c', 'f', 'j' }, 'd', 'f')]
		//[DataRow(new char[] { 'c', 'f', 'j' }, 'g', 'j')]
		//[DataRow(new char[] { 'c', 'f', 'j' }, 'j', 'c')]
		//[DataRow(new char[] { 'c', 'f', 'j' }, 'k', 'c')]
		[DataTestMethod]
		public void TestMethod1(char[] letters, char target, char expected)
		{
			// Arrange
			FindSmallestLetterGreaterThanTarget question = new FindSmallestLetterGreaterThanTarget();

			// Act
			char actual = question.NextGreatestLetter(letters, target);

			// Assert
			Assert.AreEqual(expected, actual);
		}
	}
}
