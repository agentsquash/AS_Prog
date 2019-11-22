using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Xunit;
using AS_Prog;

namespace AS_Prog_Tests
{
	public class Selection02_Tests
	{
		[Theory]
		[InlineData("1", "odd", "even")]
		[InlineData("2", "even", "odd")]
		[InlineData("27", "odd", "even")]
		[InlineData("68", "even", "odd")]
		public void Q1_Passing_SimpleValues(string number, string expected, string invalid)
		{
			// capture console output
			var output = new StringWriter();
			Console.SetOut(output);

			// setup console input
			var data = string.Join(Environment.NewLine, new[]
			{
				number
			});
			Console.SetIn(new System.IO.StringReader(data));

			// run the test
			Selection02.Question1();
			Assert.Contains(expected, output.ToString());
			Assert.DoesNotContain(invalid, output.ToString());
		}

		[Theory]
		[InlineData("2", "Y", "You are not allowed to drive the minibus")]
		[InlineData("2", "N", "You are not allowed to drive the minibus")]
		[InlineData("21", "N", "You are not allowed to drive the minibus")]
		[InlineData("21", "Y", "You are not allowed to drive the minibus")]
		[InlineData("22", "Y", "You are allowed to drive the minibus")]
		[InlineData("22", "N", "You are not allowed to drive the minibus")]
		[InlineData("52", "Y", "You are allowed to drive the minibus")]
		[InlineData("52", "N", "You are not allowed to drive the minibus")]
		public void Q2_Passing_SimpleValues(string age, string test, string expected)
		{
			// capture console output
			var output = new StringWriter();
			Console.SetOut(output);

			// setup console input
			var data = string.Join(Environment.NewLine, new[]
			{
				age, test
			});
			Console.SetIn(new System.IO.StringReader(data));

			// run the test
			Selection02.Question2();
			Assert.Contains(expected, output.ToString());
		}

		[Theory]
		[InlineData("a", "b", "c", "a b c")]
		[InlineData("A", "B", "C", "A B C")]
		[InlineData("Ann", "Bob", "Chris", "Ann Bob Chris")]
		[InlineData("Chris", "Ann", "Jo", "Ann Chris Jo")]
		public void Q3_Passing_SimpleValues(string name1, string name2, string name3, string expected)
		{
			// capture console output
			var output = new StringWriter();
			Console.SetOut(output);

			// setup console input
			var data = string.Join(Environment.NewLine, new[]
			{
				name1, name2, name3
			});
			Console.SetIn(new System.IO.StringReader(data));

			// run the test
			Selection02.Question3();
			Assert.Contains(expected, output.ToString());
		}

		/*
         * ### These are not essential to have them passing ###
         * 
         * They are more awkward values.
         * You may run in to an issue if you've used
         * an else in your outer selection statement.
         */
		[Theory]
		[InlineData("A", "A", "B", "A A B")]
		[InlineData("A", "B", "A", "A A B")]
		[InlineData("B", "A", "A", "A A B")]
		[InlineData("A", "A", "A", "A A A")]
		public void Q3_Passing_BoundaryValues(string name1, string name2, string name3, string expected)
		{
			// capture console output
			var output = new StringWriter();
			Console.SetOut(output);

			// setup console input
			var data = string.Join(Environment.NewLine, new[]
			{
				name1, name2, name3
			});
			Console.SetIn(new System.IO.StringReader(data));

			// run the test
			Selection02.Question3();
			Assert.Contains(expected, output.ToString());
		}
	}
}