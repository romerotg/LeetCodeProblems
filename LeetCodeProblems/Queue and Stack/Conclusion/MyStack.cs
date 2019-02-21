using System.Collections.Generic;

namespace LeetCodeProblems.Queue_and_Stack.Conclusion
{
	public class MyStack
	{
		/** Initialize your data structure here. */
		public MyStack()
		{
			_Queue = new Queue<int>();
		}

		private Queue<int> _Queue;

		/** Push element x onto stack. */
		public void Push(int x)
		{
			_Queue.Enqueue(x);
		}

		/** Removes the element on top of the stack and returns that element. */
		public int Pop()
		{
			if (_Queue.Count == 1)
				return _Queue.Dequeue();

			Queue<int> queue = new Queue<int>();

			int result = 0;
			while (_Queue.Count > 0)
			{
				result = _Queue.Dequeue();

				if (_Queue.Count > 0)
					queue.Enqueue(result);
			}

			while (queue.Count > 0)
				_Queue.Enqueue(queue.Dequeue());

			return result;
		}

		/** Get the top element. */
		public int Top()
		{
			if (_Queue.Count == 1)
				return _Queue.Peek();

			Queue<int> queue = new Queue<int>();

			int result = 0;
			while (_Queue.Count > 0)
			{
				result = _Queue.Dequeue();
				queue.Enqueue(result);
			}

			while (queue.Count > 0)
				_Queue.Enqueue(queue.Dequeue());

			return result;
		}

		/** Returns whether the stack is empty. */
		public bool Empty()
		{
			return _Queue.Count == 0;
		}
	}
}
