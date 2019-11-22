using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace AS_Prog
{
	class Codewars { 
		public static int[] CountBy(int x, int n)
		{
			int[] z = new int[n];
			for (int i = 1; i < n; i++)
			{
				z[i] = i * x;
			}
			return z;
		}
	}

}
