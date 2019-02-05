using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.Array_and_String.Introduction_to_2D_Array
{
	public class SpiralMatrix
	{
		public IList<int> SpiralOrder(int[,] matrix)
		{
			int[] result = new int[matrix.Length];

			int lengthX = matrix.GetLength(0);
			int lengthY = matrix.GetLength(1);

			int minBoundaryX = -1;
			int maxBoundaryX = lengthX;
			int minBoundaryY = -1;
			int maxBoundaryY = lengthY;
			int posX = 0;
			int posY = 0;

			bool moveRight = true;
			bool moveLeft = false;
			bool moveUp = false;
			bool moveDown = false;

			for (int i = 0; i < matrix.Length; i++)
			{
				result[i] = matrix[posX, posY];

				if (moveRight)
				{
					if (posY + 1 == maxBoundaryY)
					{
						minBoundaryX++;
						posX++;
						moveRight = false;
						moveDown = true;
					}
					else
						posY++;
				}
				else if (moveDown)
				{
					if (posX + 1 == maxBoundaryX)
					{
						maxBoundaryY--;
						posY--;
						moveDown = false;
						moveLeft = true;
					}
					else
						posX++;
				}
				else if (moveLeft)
				{
					if (posY - 1 == minBoundaryY)
					{
						maxBoundaryX--;
						posX--;
						moveLeft = false;
						moveUp = true;
					}
					else
						posY--;
				}
				else if (moveUp)
				{
					if (posX - 1 == minBoundaryX)
					{
						minBoundaryY++;
						posY++;
						moveUp = false;
						moveRight = true;
					}
					else
						posX--;
				}
			}

			return result;
		}
	}
}
