using LeetCodeProblems.Linked_List.Conclusion;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using static LeetCodeProblems.Linked_List.Conclusion.FlattenaMultilevelDoublyLinkedList;

namespace UnitTestProject1.Linked_List.Conclusion
{
	[TestClass]
	public class TestFlattenaMultilevelDoublyLinkedList
	{
		[TestMethod]
		public void TestMethod1()
		{
			// Arrange
			FlattenaMultilevelDoublyLinkedList question = new FlattenaMultilevelDoublyLinkedList();
			Node head = new Node(4201);
			head.child = new Node(1937);
			head.child.child = new Node(1);

			int[] expected = new int[] { 4201, 1937, 1 };

			// Act
			Node actual = question.Flatten(head);
			List<int> actualList = null;
			if (actual != null)
			{
				actualList = new List<int>();
				while (actual != null)
				{
					actualList.Add(actual.val);
					actual = actual.next;
				}
			}

			// Assert
			CollectionAssert.AreEqual(expected, actualList?.ToArray());
		}
	}
}
