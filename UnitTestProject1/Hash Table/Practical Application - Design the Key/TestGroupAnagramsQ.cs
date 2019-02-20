using LeetCodeProblems.Hash_Table.Practical_Application___Design_the_Key;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Tests.Hash_Table.Practical_Application___Design_the_Key
{
	[TestClass]
	public class TestGroupAnagramsQ
	{
		[TestMethod]
		public void TestMethod1()
		{
			// Arrange
			GroupAnagramsQ question = new GroupAnagramsQ();
			string[] strs = new string[] { "eat", "tea", "tan", "ate", "nat", "bat" };
			List<List<string>> expected = new List<List<string>>();
			expected.Add(new List<string>() { "ate", "eat", "tea" });
			expected.Add(new List<string>() { "nat", "tan" });
			expected.Add(new List<string>() { "bat" });

			// Act
			List<List<string>> actual = question.GroupAnagrams2(strs);

			// Assert
			Assert.IsTrue(expected.Count == actual.Count);
			for (int i = 0; i < expected.Count; i++)
				CollectionAssert.AreEquivalent(expected[i], actual[i]);
		}
	}
}
