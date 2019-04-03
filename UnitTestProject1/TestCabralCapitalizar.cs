using LeetCodeProblems;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests
{
	[TestClass]
	public class TestCabralCapitalizar
	{
		[DataRow("the conference has people who have come from Moscow,Idaho;Paris,Texas;London,Ohio; and other places as well.", "The conference has people who have come from Moscow, Idaho; Paris, Texas; London, Ohio; and other places as well.")]
		[DataRow("oi...tudo bom?", "Oi... Tudo bom?")]
		[DataRow("mas o que é isso!?você está louco?!", "Mas o que é isso!? Você está louco?!")]
		[DataTestMethod]
		public void TestMethod1(string s, string expected)
		{
			// Arrange
			CabralCapitalizar question = new CabralCapitalizar();

			// Act
			string actual = question.CapitalizeString(s);

			// Assert
			Assert.AreEqual(expected, actual);
		}
	}
}
