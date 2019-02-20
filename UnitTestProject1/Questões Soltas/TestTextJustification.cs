using LeetCodeProblems.Questões_Soltas;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;

namespace Tests.Questões_Soltas
{
	[TestClass]
	public class TestTextJustification
	{
		[DataRow(new string[] { "This", "is", "an", "example", "of", "text", "justification." }, 16, new string[] { "This    is    an", "example  of text", "justification.  " })]
		[DataTestMethod]
		public void TestMethod1(string[] words, int maxWidth, string[] expected)
		{
			// Arrange
			TextJustification question = new TextJustification();

			// Act
			IList<string> actual = question.FullJustify(words, maxWidth);

			// Assert
			CollectionAssert.AreEqual(expected, actual?.ToArray());
		}

		[DataRow(new string[] { "What", "must", "be", "acknowledgment", "shall", "be" }, 16, new string[] { "What   must   be", "acknowledgment  ", "shall be        " })]
		[DataTestMethod]
		public void TestMethod2(string[] words, int maxWidth, string[] expected)
		{
			// Arrange
			TextJustification question = new TextJustification();

			// Act
			IList<string> actual = question.FullJustify(words, maxWidth);

			// Assert
			CollectionAssert.AreEqual(expected, actual?.ToArray());
		}

		[DataRow(new string[] { "Science", "is", "what", "we", "understand", "well", "enough", "to", "explain", "to", "a", "computer.", "Art", "is", "everything", "else", "we", "do" }, 20, new string[] { "Science  is  what we", "understand      well", "enough to explain to", "a  computer.  Art is", "everything  else  we", "do                  " })]
		[DataTestMethod]
		public void TestMethod3(string[] words, int maxWidth, string[] expected)
		{
			// Arrange
			TextJustification question = new TextJustification();

			// Act
			IList<string> actual = question.FullJustify(words, maxWidth);

			// Assert
			CollectionAssert.AreEqual(expected, actual?.ToArray());
		}
	}
}
