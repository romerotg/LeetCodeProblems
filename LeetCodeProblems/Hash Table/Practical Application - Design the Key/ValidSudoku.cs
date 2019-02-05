using System.Collections.Generic;

namespace LeetCodeProblems.Hash_Table.Practical_Application___Design_the_Key
{
	public class ValidSudoku
	{
		public bool IsValidSudoku(char[,] board)
		{
			Dictionary<int, HashSet<char>> rowsHashmap = new Dictionary<int, HashSet<char>>();
			Dictionary<int, HashSet<char>> columnsHashmap = new Dictionary<int, HashSet<char>>();
			Dictionary<int, HashSet<char>> boxesHashmap = new Dictionary<int, HashSet<char>>();

			int totalRows = board.GetLength(0);
			int totalColumns = board.GetLength(1);

			for (int row = 0; row < totalRows; row++)
			{
				HashSet<char> currentRowHashset = new HashSet<char>();
				rowsHashmap.Add(row, currentRowHashset);

				for (int column = 0; column < totalColumns; column++)
				{
					char currentChar = board[row, column];

					if (currentChar != '.')
					{
						// Checa se linha é válida
						if (currentRowHashset.Contains(currentChar))
							return false;
						else
							currentRowHashset.Add(currentChar);

						// Checa se coluna é válida
						if (!columnsHashmap.TryGetValue(column, out var currentColumnHashset))
						{
							currentColumnHashset = new HashSet<char>();
							columnsHashmap.Add(column, currentColumnHashset);
						}
						if (currentColumnHashset.Contains(currentChar))
							return false;
						else
							currentColumnHashset.Add(currentChar);

						// Checa se o bloco é válido
						int boxIndex = (row / 3) * 3 + column / 3;
						if (!boxesHashmap.TryGetValue(boxIndex, out var boxesColumnHashset))
						{
							boxesColumnHashset = new HashSet<char>();
							boxesHashmap.Add(boxIndex, boxesColumnHashset);
						}
						if (boxesColumnHashset.Contains(currentChar))
							return false;
						else
							boxesColumnHashset.Add(currentChar);
					}
				}
			}

			return true;
		}
	}
}
