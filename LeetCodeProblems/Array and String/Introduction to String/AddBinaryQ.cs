using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.Array_and_String.Introduction_to_String
{
	public class AddBinaryQ
	{
		public string AddBinary(string a, string b)
		{
			StringBuilder strBuilder = new StringBuilder();
			bool carry = false;

			int maxLength = a.Length > b.Length ? a.Length : b.Length;
			int lastA = a.Length - 1;
			int lastB = b.Length - 1;

			for (int i = 0; i < maxLength; i++)
			{
				if (lastA < 0)
				{
					if (carry)
					{
						if (b[lastB] == '1')
							strBuilder.Insert(0, '0');
						else
						{
							strBuilder.Insert(0, '1');
							carry = false;
						}
					}
					else
						strBuilder.Insert(0, b[lastB]);
				}
				else if (lastB < 0)
				{
					if (carry)
					{
						if (a[lastA] == '1')
							strBuilder.Insert(0, '0');
						else
						{
							strBuilder.Insert(0, '1');
							carry = false;
						}
					}
					else
						strBuilder.Insert(0, a[lastA]);
				}
				else
				{
					if (carry)
					{
						if ((a[lastA] == '1' && b[lastB] == '1'))
							strBuilder.Insert(0, '1');
						else if (a[lastA] == '1' || b[lastB] == '1')
							strBuilder.Insert(0, '0');
						else
						{
							strBuilder.Insert(0, '1');
							carry = false;
						}
					}
					else
					{
						if ((a[lastA] == '1' && b[lastB] == '1'))
						{
							strBuilder.Insert(0, '0');
							carry = true;
						}
						else if (a[lastA] == '1' || b[lastB] == '1')
							strBuilder.Insert(0, '1');
						else
							strBuilder.Insert(0, '0');
					}
				}

				lastA--;
				lastB--;
			}

			if (carry)
				strBuilder.Insert(0, '1');

			return strBuilder.ToString();
		}
	}
}
