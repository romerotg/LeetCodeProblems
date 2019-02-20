using LeetCodeProblems.Hash_Table.Practical_Application___Hash_Map;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests.Hash_Table.Practical_Application___Hash_Map
{
	[TestClass]
	public class TestMinimumIndexSumofTwoLists
	{
		[DataRow(new string[] { "Shogun", "Tapioca Express", "Burger King", "KFC" }, new string[] { "Piatti", "The Grill at Torrey Pines", "Hungry Hunter Steakhouse", "Shogun" }, new string[] { "Shogun" })]
		[DataRow(new string[] { "Shogun", "Tapioca Express", "Burger King", "KFC" }, new string[] { "KFC", "Shogun", "Burger King" }, new string[] { "Shogun" })]
		[DataTestMethod]
		public void TestMethod1(string[] list1, string[] list2, string[] expected)
		{
			// Arrange
			MinimumIndexSumofTwoLists question = new MinimumIndexSumofTwoLists();

			// Act
			string[] actual = question.FindRestaurant(list1, list2);

			// Assert
			CollectionAssert.AreEqual(expected, actual);
		}
	}
}
