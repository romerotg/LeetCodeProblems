using LeetCodeProblems.Linked_List.Singly_Linked_List;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Reflection;

namespace Tests.Linked_List.Singly_Linked_List
{
	[TestClass]
	public class TestMyLinkedList
	{
		[TestMethod]
		public void TestMethod1()
		{
			string[] methods = new string[] { "AddAtHead", "AddAtTail", "AddAtIndex", "Get", "DeleteAtIndex", "Get" };
			object[][] param = new object[][] { new object[] { 1 }, new object[] { 3 }, new object[] { 1, 2 }, new object[] { 1 }, new object[] { 1 }, new object[] { 1 } };
			object[] expected = new object[] { null, null, null, 2, null, 3 };
			Type type = typeof(MyLinkedList);
			object classInstance = Activator.CreateInstance(type, null);

			for (int i = 0; i < methods.Length; i++)
			{
				MethodInfo methodInfo = type.GetMethod(methods[i]);
				if (methodInfo != null)
				{
					object result = null;
					ParameterInfo[] parameters = methodInfo.GetParameters();

					if (parameters.Length == 0)
						result = methodInfo.Invoke(classInstance, null);
					else
						result = methodInfo.Invoke(classInstance, param[i]);

					Assert.AreEqual(expected[i], result);
				}
			}
		}

		[TestMethod]
		public void TestMethod2()
		{
			string[] methods = new string[] { "AddAtHead", "Get", "AddAtTail", "DeleteAtIndex", "AddAtHead", "DeleteAtIndex", "Get", "AddAtTail", "AddAtHead", "AddAtTail", "AddAtTail", "AddAtTail", "AddAtIndex", "Get", "AddAtIndex", "AddAtHead", "DeleteAtIndex", "AddAtIndex", "AddAtHead", "AddAtIndex", "DeleteAtIndex", "Get", "AddAtTail", "DeleteAtIndex", "DeleteAtIndex", "AddAtTail", "AddAtTail", "AddAtIndex", "AddAtHead", "Get", "Get", "AddAtTail", "AddAtTail", "AddAtTail", "AddAtTail", "AddAtIndex", "AddAtIndex", "AddAtHead", "AddAtIndex", "AddAtTail", "AddAtHead", "AddAtHead", "AddAtHead", "AddAtHead", "AddAtHead", "AddAtHead", "AddAtTail", "AddAtHead", "DeleteAtIndex", "AddAtHead", "Get", "AddAtHead", "Get", "AddAtHead", "AddAtHead", "AddAtHead", "AddAtIndex", "DeleteAtIndex", "AddAtTail", "DeleteAtIndex", "Get", "AddAtIndex", "AddAtHead", "AddAtTail", "DeleteAtIndex", "AddAtHead", "AddAtIndex", "DeleteAtIndex", "DeleteAtIndex", "DeleteAtIndex", "AddAtHead", "AddAtTail", "AddAtTail", "AddAtHead", "AddAtTail", "AddAtIndex", "DeleteAtIndex", "DeleteAtIndex", "AddAtIndex", "AddAtHead", "AddAtHead", "AddAtTail", "Get", "AddAtIndex", "Get", "AddAtHead", "AddAtHead", "AddAtHead", "AddAtIndex", "AddAtIndex", "Get", "AddAtHead", "Get", "Get", "AddAtTail", "AddAtHead", "AddAtHead", "AddAtTail", "AddAtTail", "Get", "AddAtTail" };
			object[][] param = new object[][] { new object[] { 8 }, new object[] { 1 }, new object[] { 81 }, new object[] { 2 }, new object[] { 26 }, new object[] { 2 }, new object[] { 1 }, new object[] { 24 }, new object[] { 15 }, new object[] { 0 }, new object[] { 13 }, new object[] { 1 }, new object[] { 6, 33 }, new object[] { 6 }, new object[] { 2, 91 }, new object[] { 82 }, new object[] { 6 }, new object[] { 4, 11 }, new object[] { 3 }, new object[] { 7, 14 }, new object[] { 1 }, new object[] { 6 }, new object[] { 99 }, new object[] { 11 }, new object[] { 7 }, new object[] { 5 }, new object[] { 92 }, new object[] { 7, 92 }, new object[] { 57 }, new object[] { 2 }, new object[] { 6 }, new object[] { 39 }, new object[] { 51 }, new object[] { 3 }, new object[] { 22 }, new object[] { 5, 26 }, new object[] { 9, 52 }, new object[] { 69 }, new object[] { 5, 58 }, new object[] { 79 }, new object[] { 7 }, new object[] { 41 }, new object[] { 33 }, new object[] { 88 }, new object[] { 44 }, new object[] { 8 }, new object[] { 72 }, new object[] { 93 }, new object[] { 18 }, new object[] { 1 }, new object[] { 9 }, new object[] { 46 }, new object[] { 9 }, new object[] { 92 }, new object[] { 71 }, new object[] { 69 }, new object[] { 11, 54 }, new object[] { 27 }, new object[] { 83 }, new object[] { 12 }, new object[] { 20 }, new object[] { 19, 97 }, new object[] { 77 }, new object[] { 36 }, new object[] { 3 }, new object[] { 35 }, new object[] { 16, 68 }, new object[] { 22 }, new object[] { 36 }, new object[] { 17 }, new object[] { 62 }, new object[] { 89 }, new object[] { 61 }, new object[] { 6 }, new object[] { 92 }, new object[] { 28, 69 }, new object[] { 23 }, new object[] { 28 }, new object[] { 7, 4 }, new object[] { 0 }, new object[] { 24 }, new object[] { 52 }, new object[] { 1 }, new object[] { 23, 3 }, new object[] { 7 }, new object[] { 6 }, new object[] { 68 }, new object[] { 79 }, new object[] { 45, 90 }, new object[] { 41, 52 }, new object[] { 28 }, new object[] { 25 }, new object[] { 9 }, new object[] { 32 }, new object[] { 11 }, new object[] { 90 }, new object[] { 24 }, new object[] { 98 }, new object[] { 36 }, new object[] { 34 }, new object[] { 26 } };
			object[] expected = new object[] { null, -1, null, null, null, null, 8, null, null, null, null, null, null, 33, null, null, null, null, null, null, null, 14, null, null, null, null, null, null, null, 15, 8, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, 57, null, 69, null, null, null, null, null, null, null, 11, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, 0, null, 71, null, null, null, null, null, 91, null, 77, 14, null, null, null, null, null, 14, null };
			Type type = typeof(MyLinkedList);
			object classInstance = Activator.CreateInstance(type, null);

			for (int i = 0; i < methods.Length; i++)
			{
				MethodInfo methodInfo = type.GetMethod(methods[i]);
				if (methodInfo != null)
				{
					object result = null;
					ParameterInfo[] parameters = methodInfo.GetParameters();

					if (parameters.Length == 0)
						result = methodInfo.Invoke(classInstance, null);
					else
						result = methodInfo.Invoke(classInstance, param[i]);

					Assert.AreEqual(expected[i], result);
				}
			}
		}
	}
}
