using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.Hash_Table.Design_a_Hash_Table
{
	public class MyHashMap
	{
		/** Initialize your data structure here. */
		public MyHashMap()
		{
			_Keys = new bool[1000001];
			_Values = new int[1000001];
		}

		private bool[] _Keys;
		private int[] _Values;

		/** value will always be non-negative. */
		public void Put(int key, int value)
		{
			_Keys[key] = true;
			_Values[key] = value;
		}

		/** Returns the value to which the specified key is mapped, or -1 if this map contains no mapping for the key */
		public int Get(int key)
		{
			if (_Keys[key])
				return _Values[key];
			else
				return -1;
		}

		/** Removes the mapping of the specified value key if this map contains a mapping for the key */
		public void Remove(int key)
		{
			_Keys[key] = false;
		}
	}
}
