using LeetCodeProblems.Hash_Table.Practical_Application___Hash_Map;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1.Hash_Table.Practical_Application___Hash_Map
{
	[TestClass]
	public class TestFirstUniqueCharacterinaString
	{
		[DataRow("leetcode", 0)]
		[DataRow("loveleetcode", 2)]
		[DataRow("aabbccddee", -1)]
		[DataRow("z", 0)]
		[DataTestMethod]
		public void TestMethod1(string s, int expected)
		{
			// Arrange
			FirstUniqueCharacterinaString question = new FirstUniqueCharacterinaString();

			// Act
			int actual = question.FirstUniqChar(s);

			// Assert
			Assert.AreEqual(expected, actual);
		}
	}
}
