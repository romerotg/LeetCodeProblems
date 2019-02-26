using LeetCodeProblems.Binary_Search.TemplateIII;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;

namespace Tests.Binary_Search.TemplateIII
{
	[TestClass]
	public class TestFindKClosestElements
	{
		[DataRow(new int[] { 1, 2, 3, 4, 5 }, 4, 3, new int[] { 1, 2, 3, 4 })]
		[DataRow(new int[] { 1, 2, 3, 4, 5 }, 4, -1, new int[] { 1, 2, 3, 4 })]
		[DataTestMethod]
		public void TestMethod(int[] arr, int k, int x, int[] expected)
		{
			// Arrange
			FindKClosestElements question = new FindKClosestElements();

			// Act
			IList<int> actual = question.FindClosestElements(arr, k, x);

			// Assert
			CollectionAssert.AreEqual(expected, actual?.ToArray());
		}
	}
}
