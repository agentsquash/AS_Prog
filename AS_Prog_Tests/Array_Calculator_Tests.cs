using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using Xunit.Abstractions;
using AS_Prog;
using System.IO;

namespace AS_Prog_Tests
{
	public class Array_Calculator_Tests
	{
		[Theory]
		[InlineData(new int[] { 0, 2, 0, 0, 4, 6 }, 0)]
		[InlineData(new int[] { 23, 1024, 14, 600, 22, 46, 2, 23, 512 }, 2)]
		[InlineData(new int[] { 71396, 92693, 90871, 27759, 81859, 27816 }, 27759)]
		[InlineData(new int[] { 44, 42, 66, 16, 187, 6, 12, 65, 19, 109, 69, 8, 22, 15, 17, 17, 22, 98 }, 6)]
		[InlineData(new int[] { 1, 1, 8, 9, 9, 9, 8, 8, 1, 9, 9, 9, 1, 1,9,7,2,5,3 }, 1)]
		[InlineData(new int[] { 0, 1, 1, 8, 9, 9, 9, 8, 8, 1, 9, 9, 9, 1, 1, 9, 7, 2, 5, 3,5,3,18,17,22,18,19,0,0,0,0,5,2 }, 0)]

		public void Min_Int(int[] sort, int expected)
		{
			Assert.Equal(expected, Array_Calculator.Min_Int(sort));
		}

		[Theory]
		[InlineData(new string[] { "Bob", "Barry", "Barbara", "bob", "Beth", "Basil", "Bryn" }, "Barbara")]
		[InlineData(new string[] { "Aa", "AA", "Ab", "AB", "BAA", "BC", "ABC" }, "Aa")]
		[InlineData(new string[] { "OO", "HJ", "JJ", "hh", "hj", "HH", "HA", "Ha" }, "Ha")]
		[InlineData(new string[] { "01","02","00","A0","0." }, "0.")]
		[InlineData(new string[] { "..", "00", "AA", "Ab", "Aa" }, "..")]
		public void Min_Str(string[] sort, string expected)
		{
			Assert.Equal(expected, Array_Calculator.Min_Str(sort));
		}

		[Theory]
		[InlineData(new int[] { 0, 2, 0, 0, 4, 6 }, 12)]
		[InlineData(new int[] { 23, 1024, 14, 600, 22, 46, 2, 23, 512 }, 2266)]
		[InlineData(new int[] { 71396, 92693, 90871, 27759, 81859, 27816 }, 392394)]
		[InlineData(new int[] { 44, 42, 66, 16, 187, 6, 12, 65, 19, 109, 69, 8, 22, 15, 17, 17, 22, 98 }, 834)]
		[InlineData(new int[] { 1, 1, 8, 9, 9, 9, 8, 8, 1, 9, 9, 9, 1, 1, 9, 7, 2, 5, 3 }, 109)]
		public void Sum(int[] sort, int expected)
		{
			Assert.Equal(expected, Array_Calculator.Sum(sort));
		}

		[Theory]
		[InlineData(new int[] { 0, 2, 0, 0, 4, 6 }, 0)]
		[InlineData(new int[] { 23, 1024, 14, 600, 22, 46, 2, 23, 512 }, 22)]
		[InlineData(new int[] { 71396, 92693, 90871, 27759, 81859, 27816, 1118 }, 27759)]
		[InlineData(new int[] { 44, 42, 66, 16, 187, 6, 12, 65, 19, 109, 69, 8, 22, 15, 17, 17, 22, 98, 22 }, 109)]
		[InlineData(new int[] { 1, 1, 8, 9, 9, 9, 8, 8, 1, 9, 9, 9, 1, 1, 9, 7, 2, 5, 3 }, 9)]
		public void Median(int[] sort, int expected)
		{
			Assert.Equal(expected, Array_Calculator.Median(sort));
		}

		[Theory]
		[InlineData(new int[] { 0, 2, 0, 0, 4, 6 }, 6)]
		[InlineData(new int[] { 23, 1024, 14, 600, 22, 46, 2, 23, 512 }, 1024)]
		[InlineData(new int[] { 71396, 92693, 90871, 27759, 81859, 27816 }, 92693)]
		[InlineData(new int[] { 44, 42, 66, 16, 187, 6, 12, 65, 19, 109, 69, 8, 22, 15, 17, 17, 22, 98 }, 187)]
		[InlineData(new int[] { 1, 1, 8, 9, 9, 9, 8, 8, 1, 9, 9, 9, 1, 1, 9, 7, 2, 5, 3 }, 9)]
		[InlineData(new int[] { 0, 1, 1, 8, 9, 9, 9, 8, 8, 1, 9, 9, 9, 1, 1, 9, 7, 2, 5, 3, 5, 3, 18, 17, 22, 18, 19, 0, 0, 0, 0, 5, 2 },22)]

		public void MaxInt(int[] sort, int expected)
		{
			Assert.Equal(expected, Array_Calculator.MaxInt(sort));
		}

		[Theory]
		[InlineData(new string[] { "Bob", "Barry", "Barbara", "bob", "Beth", "Basil", "Bryn" }, "Bryn")]
		[InlineData(new string[] { "Aa", "AA", "Ab", "AB", "BAA", "BC", "ABC" }, "BC")]
		[InlineData(new string[] { "OO", "HJ", "JJ", "hh", "hj", "HH", "HA", "Ha" }, "OO")]
		[InlineData(new string[] { "01", "02", "00", "A0", "0." }, "A0")]
		[InlineData(new string[] { "..", "00", "AA", "Ab", "Aa" }, "Ab")]
		public void MaxStr(string[] sort, string expected)
		{
			Assert.Equal(expected, Array_Calculator.MaxStr(sort));
		}

		[Theory]
		[InlineData(new int[] { 0, 1, 2, 3, 4, 5}, 2)]
		[InlineData(new int[] { 0, 1, 1, 8, 9, 9, 9, 8, 8, 1, 9, 9, 9, 1, 1, 9, 7, 2, 5, 3}, 5)]
		[InlineData(new int[] { 23, 1024, 14, 600, 22, 46, 16, 20, 512 }, 253)]
		[InlineData(new int[] { 71396, 92693, 90871, 27759, 81859, 27816 }, 65399)]
		[InlineData(new int[] { 44, 42, 66, 16, 187, 6, 12, 65, 19, 109, 69, 8, 22, 15, 17, 17, 22, 92 }, 46)]
		public void Mean(int[] sort, int expected)
		{
			Assert.Equal(expected, Array_Calculator.Mean(sort));
		}

		[Theory]
		[InlineData(new int[] { 0, 1, 2, 3, 4, 5 }, new int[] { 0, 1, 2, 3, 4, 5 })]
		[InlineData(new int[] { 0, 1, 1, 8, 9, 9, 9, 8, 8, 1, 9, 9, 9, 1, 1, 9, 7, 2, 5, 3 }, new int[] { 0, 1, 1, 1, 1, 1, 2, 3, 5, 7, 8, 8, 8, 9, 9, 9, 9, 9, 9, 9 })]
		[InlineData(new int[] { 23, 1024, 14, 600, 22, 46, 16, 20, 512 }, new int[] { 14, 16, 20, 22, 23, 46, 512, 600, 1024 })]
		[InlineData(new int[] { 71396, 92693, 90871, 27759, 81859, 27816 }, new int[] { 27759, 27816, 71396, 81859, 90871, 92693})]
		[InlineData(new int[] { 44, 42, 66, 16, 187, 6, 12, 65, 19, 109, 69, 8, 22, 15, 17, 17, 22, 92 }, new int[] { 6, 8, 12, 15, 16, 17, 17, 19, 22, 22, 42, 44, 65, 66, 69, 92, 109, 187 })]
		public void Sort(int[] sort, int[] expected)
		{
			Assert.Equal(expected, Array_Calculator.Sort(sort));
		}

		[Theory]
		[InlineData("1", "Min")]
		[InlineData("2", "Max")]
		[InlineData("3", "Sum")]
		[InlineData("4", "Sort")]
		[InlineData("5", "Mean")]
		[InlineData("6", "Median")]
		public void Menu_Inputs(string input, string expected)
		{
			// capture console output
			var output = new StringWriter();
			Console.SetOut(output);
			// Input
			var data = string.Join(Environment.NewLine, input);
			Console.SetIn(new System.IO.StringReader(data));
			// run the test
			Array_Calculator.Run();
			Assert.Contains(expected, output.ToString());
		}
	}
}
