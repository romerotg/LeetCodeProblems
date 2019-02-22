using System.Collections.Generic;

namespace LeetCodeProblems.Queue_and_Stack.Conclusion
{
	public class KeysandRooms
	{
		public bool CanVisitAllRooms(IList<IList<int>> rooms)
		{
			if (rooms == null)
				return true;
			if (rooms.Count == 1)
				return true;

			int roomsCount = rooms.Count;
			HashSet<int> visited = new HashSet<int>();
			int visitedRooms = _VisitAllRooms(rooms, 0, 0, visited);

			return roomsCount == visitedRooms;
		}

		private int _VisitAllRooms(IList<IList<int>> rooms, int currentRoom, int visitedRooms, HashSet<int> visited)
		{
			if (visited.Contains(currentRoom))
				return visitedRooms;

			visited.Add(currentRoom);
			visitedRooms++;

			foreach (int key in rooms[currentRoom])
				visitedRooms = _VisitAllRooms(rooms, key, visitedRooms, visited);

			return visitedRooms;
		}
	}
}
