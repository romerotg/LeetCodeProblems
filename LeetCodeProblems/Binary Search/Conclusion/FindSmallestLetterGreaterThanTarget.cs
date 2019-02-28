namespace LeetCodeProblems.Binary_Search.Conclusion
{
	public class FindSmallestLetterGreaterThanTarget
	{
		public char NextGreatestLetter(char[] letters, char target)
		{
			int left = 0;
			int right = letters.Length - 1;

			while (left < right)
			{
				int middle = left + (right - left) / 2;

				if (letters[middle] <= target)
				{
					if (letters[middle + 1] > target)
						return letters[middle + 1];

					left = middle + 1;
				}
				else
					right = middle - 1;
			}

			if (letters[left] > target)
				return letters[left];
			else if (left < letters.Length - 1)
				return letters[left + 1];

			return letters[0];
		}
	}
}
