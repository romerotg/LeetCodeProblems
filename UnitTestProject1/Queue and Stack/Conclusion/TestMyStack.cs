using LeetCodeProblems.Queue_and_Stack.Conclusion;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Reflection;

namespace Tests.Queue_and_Stack.Conclusion
{
	[TestClass]
	public class TestMyStack
	{
		[TestMethod]
		public void TestMethod1()
		{
			string[] methods = new string[] { "Push", "Push", "Top", "Pop", "Empty" };
			object[][] param = new object[][] { new object[] { 1 }, new object[] { 2 }, null, null, null };
			object[] expected = new object[] { null, null, 2, 2, false };
			Type type = typeof(MyStack);
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
