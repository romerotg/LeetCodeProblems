using LeetCodeProblems.Binary_Search.TemplateI;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests.Binary_Search.TemplateI
{
	[TestClass]
	public class TestSqrtX
	{
		[DataRow(4, 2)]
		[DataRow(8, 2)]
		[DataTestMethod]
		public void TestMethod1(int x, int expected)
		{
			// Arrange
			SqrtX question = new SqrtX();

			// Act
			int actual = question.MySqrt(x);

			// Assert
			Assert.AreEqual(expected, actual);
		}
	}
}
