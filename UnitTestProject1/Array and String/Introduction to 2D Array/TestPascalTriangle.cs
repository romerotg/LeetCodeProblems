﻿using LeetCodeProblems.Array_and_String.Introduction_to_2D_Array;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests.Array_and_String.Introduction_to_2D_Array
{
	[TestClass]
	public class TestPascalTriangle
	{
		[TestMethod]
		public void TestMethod1()
		{
			// Arrange
			PascalTriangle question = new PascalTriangle();
			int numRows = 5;
			int[][] expected = new int[][]
			{
				new int[] { 1 },
				new int[] { 1, 1 },
				new int[] { 1, 2, 1 },
				new int[] { 1, 3, 3, 1 },
				new int[] { 1, 4, 6, 4, 1 },
			};

			// Act
			int[][] actual = question.Generate(numRows) as int[][];

			// Assert
			Assert.AreEqual(expected.Length, actual.Length);
			for (int i = 0; i < expected.Length; i++)
				CollectionAssert.AreEqual(expected[i], actual[i]);
		}
	}
}
