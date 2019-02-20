using System.Collections.Generic;

namespace LeetCodeProblems.Queue_and_Stack.Stack
{
	public class DailyTemperaturesQ
	{
		public int[] DailyTemperatures(int[] T)
		{
			if (T == null)
				return null;
			if (T.Length == 0)
				return new int[] { };
			if (T.Length == 1)
				return new int[] { 0 };

			Stack<int[]> stack = new Stack<int[]>();
			stack.Push(new int[] { 0, T[0] });
			int[] daysList = new int[T.Length];

			for (int i = 1; i < T.Length; i++)
			{
				if (stack.Count > 0)
				{
					int[] peek = stack.Peek();
					while (T[i] > peek[1])
					{
						daysList[peek[0]] = i - peek[0];
						stack.Pop();
						if (stack.Count == 0)
							break;
						peek = stack.Peek();
					}
				}

				stack.Push(new int[] { i, T[i] });
			}

			while (stack.Count > 0)
			{
				int[] t = stack.Pop();
				daysList[t[0]] = 0;
			}

			return daysList;
		}
	}
}
