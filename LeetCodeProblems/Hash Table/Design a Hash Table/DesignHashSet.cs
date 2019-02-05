using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.Hash_Table.Design_a_Hash_Table
{
	public class MyHashSet
	{
		/** Initialize your data structure here. */
		public MyHashSet()
		{
			_Keys = new bool[1000001];
		}

		private bool[] _Keys;

		public void Add(int key)
		{
			_Keys[key] = true;
		}

		public void Remove(int key)
		{
			_Keys[key] = false;
		}

		/** Returns true if this set contains the specified element */
		public bool Contains(int key)
		{
			return _Keys[key];
		}
	}
}
