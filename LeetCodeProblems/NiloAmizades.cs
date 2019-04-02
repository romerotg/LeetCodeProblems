using System;
using System.Collections.Generic;

namespace LeetCodeProblems
{
	public class NiloAmizades
	{
		public List<Tuple<string, int>> CheckFriends(List<Tuple<string, string>> tuples)
		{
			Dictionary<string, HashSet<string>> hashmap = new Dictionary<string, HashSet<string>>();
			Dictionary<string, HashSet<string>> newHashmap = new Dictionary<string, HashSet<string>>();

			foreach (var tuple in tuples)
			{
				if (!hashmap.TryGetValue(tuple.Item1, out var hash1))
				{
					hash1 = new HashSet<string>();
					hashmap.Add(tuple.Item1, hash1);
				}
				hash1.Add(tuple.Item2);

				if (!hashmap.TryGetValue(tuple.Item2, out var hash2))
				{
					hash2 = new HashSet<string>();
					hashmap.Add(tuple.Item2, hash2);
				}
				hash2.Add(tuple.Item1);
			}

			foreach (var pair in hashmap)
			{
				HashSet<string> visited = new HashSet<string>();
				visited.Add(pair.Key);
				_AddFriendsDeep(hashmap, newHashmap, pair.Key, pair.Value, visited);
			}

			return null;
		}

		private void _AddFriendsDeep(Dictionary<string, HashSet<string>> hashmap, Dictionary<string, HashSet<string>> newHashmap, string person, HashSet<string> friends, HashSet<string> visited)
		{
			foreach (string friend in friends)
			{
				if (!visited.Contains(friend))
				{
					visited.Add(friend);
					if (!newHashmap.TryGetValue(person, out var hash))
					{
						hash = new HashSet<string>();
						newHashmap[person] = hash;
					}
					hash.Add(friend);
					_AddFriendsDeep(hashmap, newHashmap, person, hashmap[friend], visited);
				}
			}
		}
	}
}
