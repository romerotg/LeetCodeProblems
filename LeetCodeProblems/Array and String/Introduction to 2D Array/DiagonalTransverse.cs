using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.Array_and_String.Introduction_to_2D_Array
{
	public class DiagonalTransverse
	{
		public int[] FindDiagonalOrder(int[,] matrix)
		{
			int[] result = new int[matrix.Length];

			bool upright = true;
			int posX = 0;
			int posY = 0;
			int lengthX = matrix.GetLength(0);
			int lengthY = matrix.GetLength(1);

			for (int i = 0; i < matrix.Length; i++)
			{
				result[i] = matrix[posX, posY];

				if (upright)
				{
					if (posY + 1 > lengthY - 1)
					{
						posX++;
						upright = false;
					}
					else if (posX - 1 < 0)
					{
						posY++;
						upright = false;
					}
					else
					{
						posX--;
						posY++;
					}
				}
				else
				{
					if (posX + 1 > lengthX - 1)
					{
						posY++;
						upright = true;
					}
					else if (posY - 1 < 0)
					{
						posX++;
						upright = true;
					}
					else
					{
						posX++;
						posY--;
					}
				}
			}

			return result;
		}
	}
}
