using LeetCodeProblems.Hash_Table.Practical_Application___Hash_Set;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1.Hash_Table.Practical_Application___Hash_Set
{
	[TestClass]
	public class TestHappyNumber
	{
		[DataRow(19, true)]
		[DataRow(1, true)]
		[DataTestMethod]
		public void TestMethod1(int n, bool expected)
		{
			// Arrange
			HappyNumber question = new HappyNumber();

			// Act
			bool actual = question.IsHappy(n);

			// Assert
			Assert.AreEqual(expected, actual);
		}
	}
}
