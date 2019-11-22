using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using Xunit.Abstractions;
using AS_Prog;
using System.IO;

namespace AS_Prog_Tests
{
	public class Selection_Tests
	{
		[Theory]
		[InlineData("1", "U")]
		[InlineData("39", "U")]
		[InlineData("40", "E")]
		[InlineData("49", "E")]
		[InlineData("50", "D")]
		[InlineData("59", "D")]
		[InlineData("60", "C")]
		[InlineData("69", "C")]
		[InlineData("70", "B")]
		[InlineData("79", "B")]
		[InlineData("80", "A")]
		[InlineData("100", "A")]
		public void Q1_Passing_SimpleValues(string grade, string expected)
		{
			// capture console output
			var output = new StringWriter();
			Console.SetOut(output);

			// setup console input
			var data = string.Join(Environment.NewLine, new[]
			{
				grade
			});
			Console.SetIn(new System.IO.StringReader(data));

			// run the test
			Selection.Question1();
			Assert.Contains(expected, output.ToString());
		}

		[Theory]
		[InlineData("999", "999")] // no discount
		[InlineData("1000", "950")] // 5%
		[InlineData("2499", "2374.05")] // 5%
		[InlineData("2500", "2250")] // 10%
		[InlineData("4999", "4499.1")] // 10%
		[InlineData("5000", "4250")] // 15%
		[InlineData("9999", "8499.15")] // 15%
		[InlineData("10000", "8000")] // 20%
		[InlineData("20000", "16000")] // 20%
		public void Q2_Passing_SimpleValues(string order, string expected)
		{
			// capture console output
			var output = new StringWriter();
			Console.SetOut(output);

			// setup console input
			var data = string.Join(Environment.NewLine, new[]
			{
				order
			});
			Console.SetIn(new System.IO.StringReader(data));

			// run the test
			Selection.Question2();
			Assert.Contains(expected, output.ToString());
		}

		[Theory]
		[InlineData("1", "U")] // check program still works as expected
		[InlineData("39", "U")]
		[InlineData("40", "E")]
		[InlineData("49", "E")]
		[InlineData("50", "D")]
		[InlineData("59", "D")]
		[InlineData("60", "C")]
		[InlineData("69", "C")]
		[InlineData("70", "B")]
		[InlineData("79", "B")]
		[InlineData("80", "A")]
		[InlineData("100", "A")]
		[InlineData("-1", "error")] // now, boundary/erroneous data
		[InlineData("0", "error")]
		[InlineData("101", "error")]
		public void Q3_Passing_ErroneousValues(string grade, string expected)
		{
			// capture console output
			var output = new StringWriter();
			Console.SetOut(output);

			// setup console input
			var data = string.Join(Environment.NewLine, new[]
			{
				grade
			});
			Console.SetIn(new System.IO.StringReader(data));

			// run the test
			Selection.Question3();
			Assert.Contains(expected, output.ToString());
		}

		[Theory]
		[InlineData("999", "999")] // no discount
		[InlineData("1000", "950")] // 5%
		[InlineData("2499", "2374.05")] // 5%
		[InlineData("2500", "2250")] // 10%
		[InlineData("4999", "4499.1")] // 10%
		[InlineData("5000", "4250")] // 15%
		[InlineData("9999", "8499.15")] // 15%
		[InlineData("10000", "8000")] // 20%
		[InlineData("20000", "16000")] // 20%
		[InlineData("0", "0")] // no discount   boundary/erroneous data
		[InlineData("-1", "error")] // error
		[InlineData("25000", "20000")] // 20%
		[InlineData("25001", "error")] // error
		public void Q4_Passing_ErroneousValues(string order, string expected)
		{
			// capture console output
			var output = new StringWriter();
			Console.SetOut(output);

			// setup console input
			var data = string.Join(Environment.NewLine, new[]
			{
				order
			});
			Console.SetIn(new System.IO.StringReader(data));

			// run the test
			Selection.Question4();
			Assert.Contains(expected, output.ToString());
		}
	}
}
