using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.Array_and_String.Introduction_to_Array
{
	public class PlusOneQ
	{
		public int[] PlusOne(int[] digits)
		{
			int[] result = new int[digits.Length];

			bool carry = false;
			if (digits[digits.Length - 1] == 9)
			{
				carry = true;
				result[digits.Length - 1] = 0;
			}
			else
				result[digits.Length - 1] = digits[digits.Length - 1] + 1;

			for (int i = digits.Length - 2; i >= 0; i--)
			{
				if (carry)
				{
					if (digits[i] == 9)
						result[i] = 0;
					else
					{
						result[i] = digits[i] + 1;
						carry = false;
					}
				}
				else
					result[i] = digits[i];
			}

			if (carry)
			{
				int[] temp = new int[digits.Length + 1];
				temp[0] = 1;
				for (int i = 1; i < temp.Length; i++)
					temp[i] = result[i - 1];
				result = temp;
			}

			return result;
		}
	}
}
