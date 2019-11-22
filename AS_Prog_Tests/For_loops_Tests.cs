using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using Xunit.Abstractions;
using AS_Prog;
using System.IO;

namespace AS_Prog_Tests
{
	public class For_loops_Tests
	{
		[Theory]
		[InlineData("Ee, that plate of chips looks okay.", "3")]
		[InlineData("Ee", "2")]
		[InlineData("!Ee$", "2")]
		[InlineData("Nothing", "0")]
		[InlineData("\n", "0")]
		public void Q1_Passing_SimpleValues(string sent, string expected)
		{
			// capture console output
			var output = new StringWriter();
			Console.SetOut(output);

			// setup console input
			var data = string.Join(Environment.NewLine, new[]
			{
				sent
			});
			Console.SetIn(new System.IO.StringReader(data));

			// run the test
			For_loops.Question1();
			Assert.Contains(expected, output.ToString());
		}

		[Theory]
		[InlineData("Ee, that plate of chips looks okay.", "11")]
		[InlineData("Ee", "2")]
		[InlineData("!Ee$", "2")]
		[InlineData("Nothing", "2")]
		[InlineData("\n", "0")]
		public void Q2_Passing_SimpleValues(string sent, string expected)
		{
			// capture console output
			var output = new StringWriter();
			Console.SetOut(output);

			// setup console input
			var data = string.Join(Environment.NewLine, new[]
			{
				sent
			});
			Console.SetIn(new System.IO.StringReader(data));

			// run the test
			For_loops.Question2();
			Assert.Contains(expected, output.ToString());
		}


		[Theory]
		[InlineData("Ee, that plate of chips looks okay.", "7")]
		[InlineData("Ee", "1")]
		[InlineData("!Ee$", "1")]
		[InlineData("\n", "0")]
		[InlineData("Hi there", "2")]
		public void Q3_Passing_SimpleValues(string sent, string expected)
		{
			// capture console output
			var output = new StringWriter();
			Console.SetOut(output);

			// setup console input
			var data = string.Join(Environment.NewLine, new[]
			{
				sent
			});
			Console.SetIn(new System.IO.StringReader(data));

			// run the test
			For_loops.Question3();
			Assert.Contains(expected, output.ToString());
		}


		[Theory]
		[InlineData(new string[] { "0", "2", "0", "0", "4", "6" }, "12")]
		[InlineData(new string[] { "0", "0", "0", "0", "0", "0" }, "0")]
		[InlineData(new string[] { "4", "3", "6", "2", "5", "1" }, "21")]
		public void Q4_Passing_SimpleValues(string[] scores, string expected)
		{
			// capture console output
			var output = new StringWriter();
			Console.SetOut(output);

			// setup console input
			var data = string.Join(Environment.NewLine, scores);
			Console.SetIn(new System.IO.StringReader(data));

			// run the test
			For_loops.Question4();
			Assert.Contains(expected, output.ToString());
		}


		[Theory]
		[InlineData(new string[] { "-1", "0", "0", "0", "0", "0" }, "Error: negative score")] // cannot score negative runs
		[InlineData(new string[] { "1234", "3", "6", "2", "5", "1" }, "Error: invalid score")] // invalid # runs. You'll need to pick a sensible max
		public void Q4_Passing_BoundaryValues(string[] scores, string expected)
		{
			// capture console output
			var output = new StringWriter();
			Console.SetOut(output);

			// setup console input
			var data = string.Join(Environment.NewLine, scores);
			Console.SetIn(new System.IO.StringReader(data));

			// run the test
			For_loops.Question4();
			Assert.Contains(expected, output.ToString());
		}
	}
}