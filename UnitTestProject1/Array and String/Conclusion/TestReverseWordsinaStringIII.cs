using LeetCodeProblems.Array_and_String.Conclusion;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests.Array_and_String.Conclusion
{
	[TestClass]
	public class TestReverseWordsinaStringIII
	{
		[DataRow("Let's take LeetCode contest", "s'teL ekat edoCteeL tsetnoc")]
		[DataTestMethod]
		public void TestMethod1(string s, string expected)
		{
			// Arrange
			ReverseWordsinaStringIII question = new ReverseWordsinaStringIII();

			// Act
			string actual = question.ReverseWords(s);

			// Assert
			Assert.AreEqual(expected, actual);
		}
	}
}
