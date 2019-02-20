using System.Collections.Generic;

namespace LeetCodeProblems.Queue_and_Stack.Stack
{
	public class EvaluateReversePolishNotation
	{
		public int EvalRPN(string[] tokens)
		{
			Stack<int> stack = new Stack<int>();

			foreach (string token in tokens)
			{
				if (token == "+" || token == "-" || token == "/" || token == "*")
				{
					int right = stack.Pop();
					int left = stack.Pop();
					int result = 0;

					if (token == "+")
						result = left + right;
					else if (token == "-")
						result = left - right;
					else if (token == "/")
						result = left / right;
					else if (token == "*")
						result = left * right;

					stack.Push(result);
				}
				else
					stack.Push(int.Parse(token));
			}

			return stack.Pop();
		}
	}
}
