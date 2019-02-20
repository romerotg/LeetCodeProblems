using LeetCodeProblems.Hash_Table.Conclusion;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests.Hash_Table.Conclusion
{
	[TestClass]
	public class TestLongestSubstringWithoutRepeatingCharacters
	{
		[DataRow("abcabcbb", 3)]
		[DataRow("bbbbb", 1)]
		[DataRow("pwwkew", 3)]
		[DataTestMethod]
		public void TestMethod1(string s, int expected)
		{
			// Arrange
			LongestSubstringWithoutRepeatingCharacters question = new LongestSubstringWithoutRepeatingCharacters();

			// Act
			int actual = question.LengthOfLongestSubstring(s);

			// Assert
			Assert.AreEqual(expected, actual);
		}
	}
}
