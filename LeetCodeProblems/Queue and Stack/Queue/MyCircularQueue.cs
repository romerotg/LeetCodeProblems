namespace LeetCodeProblems.Queue_and_Stack.Queue
{
	public class MyCircularQueue
	{
		/** Initialize your data structure here. Set the size of the queue to be k. */
		public MyCircularQueue(int k)
		{
			_Queue = new int[k];
			_HeadIndex = _TailIndex = -1;
			_QueueSize = k;
		}

		private int[] _Queue;
		private int _HeadIndex;
		private int _TailIndex;
		private int _QueueSize;

		/** Insert an element into the circular queue. Return true if the operation is successful. */
		public bool EnQueue(int value)
		{
			if (IsFull())
				return false;

			int index = (_TailIndex + 1) % _QueueSize;
			_Queue[index] = value;
			_TailIndex = index;

			// Inserindo o primeiro elemento
			if (_HeadIndex == -1)
				_HeadIndex = index;

			return true;
		}

		/** Delete an element from the circular queue. Return true if the operation is successful. */
		public bool DeQueue()
		{
			if (IsEmpty())
				return false;

			// Removendo o último elemento
			if (_HeadIndex == _TailIndex)
				_HeadIndex = _TailIndex = -1;
			else
				_HeadIndex = (_HeadIndex + 1) % _QueueSize;

			return true;
		}

		/** Get the front item from the queue. */
		public int Front()
		{
			if (IsEmpty())
				return -1;

			return _Queue[_HeadIndex];
		}

		/** Get the last item from the queue. */
		public int Rear()
		{
			if (IsEmpty())
				return -1;

			return _Queue[_TailIndex];
		}

		/** Checks whether the circular queue is empty or not. */
		public bool IsEmpty()
		{
			return _HeadIndex == -1 && _TailIndex == -1;
		}

		/** Checks whether the circular queue is full or not. */
		public bool IsFull()
		{
			if (IsEmpty())
				return false;

			int index = (_HeadIndex + _QueueSize - 1) % _QueueSize;
			return index == _TailIndex;
		}
	}
}
