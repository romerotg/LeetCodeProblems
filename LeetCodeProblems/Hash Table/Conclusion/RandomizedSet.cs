using System;
using System.Collections.Generic;

namespace LeetCodeProblems.Hash_Table.Conclusion
{
	public class RandomizedSet
	{
		/** Initialize your data structure here. */
		public RandomizedSet()
		{
			_Values = new List<int>();
			_Indexes = new Dictionary<int, int>();
		}

		private Random _Random = new Random();
		private List<int> _Values;
		private Dictionary<int, int> _Indexes;

		/** Inserts a value to the set. Returns true if the set did not already contain the specified element. */
		public bool Insert(int val)
		{
			if (_Indexes.ContainsKey(val))
				return false;

			_Indexes.Add(val, _Values.Count);
			_Values.Add(val);
			return true;
		}

		/** Removes a value from the set. Returns true if the set contained the specified element. */
		public bool Remove(int val)
		{
			if (!_Indexes.ContainsKey(val))
				return false;

			int index = _Indexes[val];
			int lastElementIndex = _Values.Count - 1;
			int lastElement = _Values[lastElementIndex];
			_Values[index] = lastElement;
			_Values.RemoveAt(lastElementIndex);
			_Indexes[lastElement] = index;
			return _Indexes.Remove(val);
		}

		/** Get a random element from the set. */
		public int GetRandom()
		{
			if (_Values.Count == 0)
				return -1;

			return _Values[_Random.Next(_Values.Count)];
		}
	}
}
