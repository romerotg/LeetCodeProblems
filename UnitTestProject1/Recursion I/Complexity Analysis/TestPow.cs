using LeetCodeProblems.Recursion_I.Complexity_Analysis;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Tests.Recursion_I.Complexity_Analysis
{
	[TestClass]
	public class TestPow
	{
		//[DataRow(2.00000, 10, 1024.00000)]
		[DataRow(2.10000, 3, 9.26100)]
		//[DataRow(9.26100, -2, 0.25000)]
		[DataTestMethod]
		public void TestMethod1(double x, int n, double expected)
		{
			// Arrange
			Pow question = new Pow();

			// Act
			double actual = question.MyPow(x, n);

			// Assert
			Assert.AreEqual(expected, Math.Round(actual, 5));
		}
	}
}
