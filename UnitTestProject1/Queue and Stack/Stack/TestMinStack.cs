using LeetCodeProblems.Queue_and_Stack.Stack;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Reflection;

namespace Tests.Queue_and_Stack.Stack
{
	[TestClass]
	public class TestMinStack
	{
		[TestMethod]
		public void TestMethod1()
		{
			string[] methods = new string[] { "Push", "Push", "Push", "GetMin", "Pop", "Top", "GetMin" };
			object[][] param = new object[][] { new object[] { -2 }, new object[] { 0 }, new object[] { -3 }, null, null, null, null };
			object[] expected = new object[] { null, null, null, -3, null, 0, -2 };
			Type type = typeof(MinStack);
			object classInstance = Activator.CreateInstance(type, null);

			for (int i = 0; i < methods.Length; i++)
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
