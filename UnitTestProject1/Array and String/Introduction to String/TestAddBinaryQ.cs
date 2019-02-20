using LeetCodeProblems.Array_and_String.Introduction_to_String;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests.Array_and_String.Introduction_to_String
{
	[TestClass]
	public class TestAddBinaryQ
	{
		[DataRow("11", "1", "100")]
		[DataRow("1010", "1011", "10101")]
		[DataTestMethod]
		public void TestMethod1(string a, string b, string expected)
		{
			// Arrange
			AddBinaryQ question = new AddBinaryQ();

			// Act
			string actual = question.AddBinary(a, b);

			// Assert
			Assert.AreEqual(expected, actual);
		}
	}
}
