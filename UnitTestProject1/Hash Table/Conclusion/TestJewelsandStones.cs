using LeetCodeProblems.Hash_Table.Conclusion;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1.Hash_Table.Conclusion
{
	[TestClass]
	public class TestJewelsandStones
	{
		[DataRow("aA", "aAAbbbb", 3)]
		[DataRow("z", "ZZ", 0)]
		[DataTestMethod]
		public void TestMethod1(string J, string S, int expected)
		{
			// Arrange
			JewelsandStones question = new JewelsandStones();

			// Act
			int actual = question.NumJewelsInStones(J, S);

			// Assert
			Assert.AreEqual(expected, actual);
		}
	}
}
