using LeetCodeProblems.Queue_and_Stack.Conclusion;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Tests.Queue_and_Stack.Conclusion
{
	[TestClass]
	public class TestKeysandRooms
	{
		[TestMethod]
		public void TestMethod1()
		{
			// Arrange
			KeysandRooms question = new KeysandRooms();
			IList<IList<int>> rooms = new List<IList<int>>();
			rooms.Add(new List<int>() { 1 });
			rooms.Add(new List<int>() { 2 });
			rooms.Add(new List<int>() { 3 });
			rooms.Add(new List<int>() { });
			bool expected = true;

			// Act
			bool actual = question.CanVisitAllRooms(rooms);

			// Assert
			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void TestMethod2()
		{
			// Arrange
			KeysandRooms question = new KeysandRooms();
			IList<IList<int>> rooms = new List<IList<int>>();
			rooms.Add(new List<int>() { 1, 3 });
			rooms.Add(new List<int>() { 3, 0, 1 });
			rooms.Add(new List<int>() { 2 });
			rooms.Add(new List<int>() { 0 });
			bool expected = false;

			// Act
			bool actual = question.CanVisitAllRooms(rooms);

			// Assert
			Assert.AreEqual(expected, actual);
		}
	}
}
