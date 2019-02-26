using System;
using System.Collections.Generic;

namespace LeetCodeProblems.Binary_Search.TemplateIII
{
	public class FindKClosestElements
	{
		public IList<int> FindClosestElements(int[] arr, int k, int x)
		{
			if (arr == null)
				return null;

			List<int> result = new List<int>();

			if (arr.Length == 0)
				return result;

			if (arr.Length == k)
				return new List<int>(arr);

			int left = 0;
			int right = arr.Length - 1;
			int index = -1;

			while (left + 1 < right)
			{
				int middle = left + (right - left) / 2;

				if (arr[middle] == x)
				{
					index = middle;
					break;
				}
				if (Math.Abs(arr[middle] - x) < Math.Abs(arr[middle - 1] - x) && Math.Abs(arr[middle] - x) < Math.Abs(arr[middle + 1] - x))
				{
					index = middle;
					break;
				}

				if (arr[middle] < x)
				{
					if (arr[middle + 1] > x)
					{
						if (Math.Abs(arr[middle] - x) < Math.Abs(arr[middle + 1] - x))
							index = middle;
						else
							index = middle + 1;
						break;
					}
					else
						left = middle + 1;
				}
				else
				{
					if (arr[middle - 1] < x)
					{
						if (Math.Abs(arr[middle] - x) < Math.Abs(arr[middle - 1] - x))
							index = middle;
						else
							index = middle - 1;
						break;
					}
					else
						right = middle - 1;
				}
			}

			if (index == -1)
			{
				if (arr[left] >= x)
					index = left;
				else if (arr[right] <= x)
					index = right;
				else if (Math.Abs(arr[left] - x) <= Math.Abs(arr[right] - x))
					index = left;
				else
					index = right;
			}


			int min = index;
			int max = index;
			if (k-- > 0)
				result.Add(arr[index]);

			while (k > 0)
			{
				if (min == 0)
					result.Add(arr[++max]);
				else if (max == arr.Length - 1)
					result.Add(arr[--min]);
				else
				{
					if (Math.Abs(arr[min - 1] - x) <= Math.Abs(arr[max + 1] - x))
						result.Add(arr[--min]);
					else
						result.Add(arr[++max]);
				}

				k--;
			}

			result.Sort();

			return result;
		}
	}
}
