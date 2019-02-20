using LeetCodeProblems.Array_and_String.Two_Pointer_Technique;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests.Array_and_String.Two_Pointer_Technique
{
	[TestClass]
	public class TestReverseStringQ
	{
		[DataRow(new char[] { 'h', 'e', 'l', 'l', 'o' }, new char[] { 'o', 'l', 'l', 'e', 'h' })]
		[DataRow(new char[] { 'H', 'a', 'n', 'n', 'a', 'h' }, new char[] { 'h', 'a', 'n', 'n', 'a', 'H' })]
		[DataTestMethod]
		public void TestMethod1(char[] s, char[] expected)
		{
			// Arrange
			ReverseStringQ question = new ReverseStringQ();

			// Act
			question.ReverseString(s);

			// Assert
			CollectionAssert.AreEqual(expected, s);
		}
	}
}
