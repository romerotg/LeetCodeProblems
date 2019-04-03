using LeetCodeProblems;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests
{
	[TestClass]
	public class TestCabralCapitalizar
	{
		[DataRow("the conference has people who have come from Moscow,Idaho;Paris,Texas;London,Ohio; and other places as well.", "The conference has people who have come from Moscow, Idaho; Paris, Texas; London, Ohio; and other places as well.")]
		[DataRow("inri!?mas que feze?!", "Inri!? Mas que feze?!")]
		[DataRow("oi...tudo bom?", "Oi... Tudo bom?")]
		[DataRow("e ai boy?  blz?", "E ai boy? Blz?")]
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
