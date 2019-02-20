using LeetCodeProblems.Hash_Table.Practical_Application___Hash_Map;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests.Hash_Table.Practical_Application___Hash_Map
{
	[TestClass]
	public class TestIsomorphicStrings
	{
		[DataRow("egg", "add", true)]
		[DataRow("foo", "bar", false)]
		[DataRow("paper", "title", true)]
		[DataRow("ab", "aa", false)]
		[DataTestMethod]
		public void TestMethod1(string s, string t, bool expected)
		{
			// Arrange
			IsomorphicStrings question = new IsomorphicStrings();

			// Act
			bool actual = question.IsIsomorphic(s, t);

			// Assert
			Assert.AreEqual(expected, actual);
		}
	}
}
