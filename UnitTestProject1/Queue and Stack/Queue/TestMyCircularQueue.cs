using LeetCodeProblems.Queue_and_Stack.Queue;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Reflection;

namespace UnitTestProject1.Queue_and_Stack.Queue
{
	[TestClass]
	public class TestMyCircularQueue
	{
		[TestMethod]
		public void TestMethod1()
		{
			string[] methods = new string[] { "MyCircularQueue", "EnQueue", "EnQueue", "EnQueue", "EnQueue", "Rear", "IsFull", "DeQueue", "EnQueue", "Rear" };
			object[][] param = new object[][] { new object[] { 3 }, new object[] { 1 }, new object[] { 2 }, new object[] { 3 }, new object[] { 4 }, null, null, null, new object[] { 4 }, null };
			object[] expected = new object[] { null, true, true, true, false, 3, true, true, true, 4 };
			Type type = typeof(MyCircularQueue);
			object classInstance = Activator.CreateInstance(type, param[0]);

			for (int i = 1; i < methods.Length; i++)
			{
				MethodInfo methodInfo = type.GetMethod(methods[i]);
				if (methodInfo != null)
				{
					object result = null;
					ParameterInfo[] parameters = methodInfo.GetParameters();

					if (parameters == null || parameters.Length == 0)
						result = methodInfo.Invoke(classInstance, null);
					else
						result = methodInfo.Invoke(classInstance, param[i]);

					Assert.AreEqual(expected[i], result);
				}
			}
		}
	}
}
