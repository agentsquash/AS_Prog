using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using AS_Prog;
using Xunit;

namespace AS_Prog_Tests
{
	public class Strings01_Tests
	{
		[Theory]
		[InlineData("Bob", "3")]
		[InlineData("Marge", "5")]
		[InlineData("QWERTYUIOPASDFGHJKLZXCVBNM", "26")]
		public void Q1_Passing_SimpleValues(string name, string expected)
		{
			// capture console output
			var output = new StringWriter();
			Console.SetOut(output);

			// setup console input
			var data = string.Join(Environment.NewLine, new[]
			{
				name
			});
			Console.SetIn(new System.IO.StringReader(data));

			// run the test
			Strings01.Question1();
			Assert.Contains(expected, output.ToString());
		}

		[Theory]
		[InlineData("", "0")]
		public void Q1_Passing_BoundaryValues(string name, string expected)
		{
			// capture console output
			var output = new StringWriter();
			Console.SetOut(output);

			// setup console input
			var data = string.Join(Environment.NewLine, new[]
			{
				name
			});
			Console.SetIn(new System.IO.StringReader(data));

			// run the test
			Strings01.Question1();
			Assert.Contains(expected, output.ToString());
		}

		[Theory]
		[InlineData("Barry", "Hello Barry. Your name has 5 characters and your initial is B")]
		[InlineData("Q", "Hello Q. Your name has 1 character and your initial is Q")]
		[InlineData("SuperCoolName", "Hello SuperCoolName. Your name has 13 characters and your initial is S")]
		public void Q2_Passing_SimpleValues(string name, string expected)
		{
			// capture console output
			var output = new StringWriter();
			Console.SetOut(output);

			// setup console input
			var data = string.Join(Environment.NewLine, new[]
			{
				name
			});
			Console.SetIn(new System.IO.StringReader(data));

			// run the test
			Strings01.Question2();
			Assert.Contains(expected, output.ToString());
		}

		/*
         * Checking for the difference in character(s)
         * when a name only has 1 letter
         */
		[Theory]
		[InlineData("Barry", "Hello Barry. Your name has 5 characters and your initial is B")]
		[InlineData("Q", "Hello Q. Your name has 1 character and your initial is Q")]
		public void Q2_Passing_BoundaryValues(string name, string expected)
		{
			// capture console output
			var output = new StringWriter();
			Console.SetOut(output);

			// setup console input
			var data = string.Join(Environment.NewLine, new[]
			{
				name
			});
			Console.SetIn(new System.IO.StringReader(data));

			// run the test
			Strings01.Question2();
			Assert.Contains(expected, output.ToString());
		}

		[Theory]
		[InlineData("01229 483900", "+44 1229 483900")]
		[InlineData("01274 569487", "+44 1274 569487")]
		[InlineData("000", "+44 00")]
		public void Q3_Passing_SimpleValues(string phone, string expected)
		{
			// capture console output
			var output = new StringWriter();
			Console.SetOut(output);

			// setup console input
			var data = string.Join(Environment.NewLine, new[]
			{
				phone
			});
			Console.SetIn(new System.IO.StringReader(data));

			// run the test
			Strings01.Question3();
			Assert.Contains(expected, output.ToString());
		}

		[Theory]
		[InlineData("12/08/1971", "You were born on the 12th day of the 08th month in 1971")]
		[InlineData("01/08/2001", "You were born on the 01th day of the 08th month in 2001")]
		public void Q4_Passing_SimpleValues(string dob, string expected)
		{
			// capture console output
			var output = new StringWriter();
			Console.SetOut(output);

			// setup console input
			var data = string.Join(Environment.NewLine, new[]
			{
				dob
			});
			Console.SetIn(new System.IO.StringReader(data));

			// run the test
			Strings01.Question4();
			Assert.Contains(expected, output.ToString());
		}

		[Theory]
		[InlineData("12/08/1971", "You were born on the 12th day of Aug in 1971")]
		[InlineData("01/01/2001", "You were born on the 01st day of Jan in 2001")]
		[InlineData("28/02/2019", "You were born on the 28th day of Feb in 2019")]
		public void Q5_Passing_SimpleValues(string dob, string expected)
		{
			// capture console output
			var output = new StringWriter();
			Console.SetOut(output);

			// setup console input
			var data = string.Join(Environment.NewLine, new[]
			{
				dob
			});
			Console.SetIn(new System.IO.StringReader(data));

			// run the test
			Strings01.Question5();
			Assert.Contains(expected, output.ToString());
		}

		/*
         * This builds on the previous test suite.
         * It introduces inconsistent data and you are expected
         * to handle it in a sensible way.
         */
		[Theory]
		[InlineData("02?15?2001", "Invalid date")] // invalid format
		[InlineData("AA/15/2001", "Invalid date")] // invalid data
		[InlineData("5/15/2001", "Invalid date")] // invalid format
		[InlineData("05/15/2001", "Invalid date")] // month invalid
		[InlineData("35/01/2001", "Invalid date")] // date invalid
		[InlineData("29/02/2016", "You were born on the 29th day of Feb in 2016")] // is leap year
		[InlineData("29/02/2019", "2019 was not a leap year")] // is not leap year
		public void Q5_Passing_Ext_VeryStrict(string dob, string expected)
		{
			// capture console output
			var output = new StringWriter();
			Console.SetOut(output);

			// setup console input
			var data = string.Join(Environment.NewLine, new[]
			{
				dob
			});
			Console.SetIn(new System.IO.StringReader(data));

			// run the test
			Strings01.Question5();
			Assert.Contains(expected, output.ToString());
		}
	}
}
