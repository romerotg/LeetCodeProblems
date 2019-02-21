using System.Collections.Generic;

namespace LeetCodeProblems.Queue_and_Stack.Conclusion
{
	public class MyQueue
	{
		/** Initialize your data structure here. */
		public MyQueue()
		{
			_Stack = new Stack<int>();
		}

		private Stack<int> _Stack;

		/** Push element x to the back of queue. */
		public void Push(int x)
		{
			_Stack.Push(x);
		}

		/** Removes the element from in front of queue and returns that element. */
		public int Pop()
		{
			if (_Stack.Count == 1)
				return _Stack.Pop();

			Stack<int> stack = new Stack<int>();

			while (_Stack.Count > 0)
				stack.Push(_Stack.Pop());

			int result = stack.Pop();

			while (stack.Count > 0)
				_Stack.Push(stack.Pop());

			return result;
		}

		/** Get the front element. */
		public int Peek()
		{
			if (_Stack.Count == 1)
				return _Stack.Peek();

			Stack<int> stack = new Stack<int>();

			while (_Stack.Count > 0)
				stack.Push(_Stack.Pop());

			int result = stack.Peek();

			while (stack.Count > 0)
				_Stack.Push(stack.Pop());

			return result;
		}

		/** Returns whether the queue is empty. */
		public bool Empty()
		{
			return _Stack.Count == 0;
		}
	}
}
