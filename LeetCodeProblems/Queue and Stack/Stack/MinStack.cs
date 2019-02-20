using System;
using System.Collections.Generic;

namespace LeetCodeProblems.Queue_and_Stack.Stack
{
	public class MinStack
	{
		/** initialize your data structure here. */
		public MinStack()
		{
			_Stack = new Stack<int>();
			_MinValue = int.MaxValue;
		}

		private Stack<int> _Stack;
		private int _MinValue;

		public void Push(int x)
		{
			if (x <= _MinValue)
			{
				_Stack.Push(_MinValue);
				_MinValue = x;
			}
			_Stack.Push(x);
		}

		public void Pop()
		{
			if (_Stack.Pop() == _MinValue)
				_MinValue = _Stack.Pop();
		}

		public int Top()
		{
			return _Stack.Peek();
		}

		public int GetMin()
		{
			return _MinValue;
		}
	}
}
