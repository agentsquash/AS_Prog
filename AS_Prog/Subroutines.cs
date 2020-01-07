using System;
using System.Collections.Generic;
using System.Text;

namespace AS_Prog
{
	public class Subroutines
	{
		public static void RunImproved()
		{
			List<string> Programs = new List<string>() { "Coronation Street", "Emmerdale", "Hollyoaks" };
			List<string> Times = new List<string>() { "20:00", "19:00", "18:30" };

			string cont = "";

			do
			{
				Console.Write("Do you want to add a program (Y/N): ");
				cont = Console.ReadLine();

				if (cont == "Y")
				{
					string Prog = GetData(message[0], 4, 256);
					Programs.Add(Prog);
					Times.Add(GetData(message[1], 5, 5));
				}

			} while (cont == "Y");

			// Print all programs
			for (int i = 0; i < Programs.Count; i++)
			{
				Greeting();
				NextProg(Programs[i], Times[i]);
			}
		}

		//public static string GetProg()
		//{
		//	Console.WriteLine("Enter the name for a TV program: ");
		//	return Console.ReadLine();
		//}

		//public static string GetTime(string Prog)
		//{
		//	string Time = "";
		//	do
		//	{
		//		Console.WriteLine("Enter the start time for {0}:", Prog);
		//		return Console.ReadLine();
		//	} while (Time.Length != 5);
		//}

		static readonly string[] message =
			{
				"Enter the name for a TV program: ",
				"Enter program start time: "
			};

		public static string GetData(string msg, int min, int max) // ID: data message reference
		{
			string input;
			
			do
			{
				Console.WriteLine(msg);
				input = Console.ReadLine();
			} while (input.Length >= min || input.Length <= max);

			return input;
		}
		public static void Greeting()
		{
			Console.WriteLine("========================================");
			Console.WriteLine("Welcome to the TV Listings Program");
			Console.WriteLine("Today's date: {0}", DateTime.Now.ToString("dd/M/yyyy"));
			Console.WriteLine("Current time: {0}", DateTime.Now.ToString("h:mm:ss tt"));
			Console.WriteLine("========================================");
		}

		public static void NextProg(string Program, string Time)
		{
			Console.WriteLine();
			Console.WriteLine("{0} is on tomorrow at {1}", Program, Time);
			Console.WriteLine("Press 'Enter' to get the next program");
			Console.ReadLine();
			Console.WriteLine();
		}
		public static void Run()
		{
			List<string> Programs = new List<string>() { "Coronation Street", "Emmerdale", "Hollyoaks" };
			List<string> Times = new List<string>() { "20:00", "19:00", "18:30" };
			string Program, Time;

			// add a program

			// display a program
			Console.WriteLine("========================================");
			Console.WriteLine("Welcome to the TV Listings Program");
			Console.WriteLine("Today's date: {0}", DateTime.Now.ToString("dd/M/yyyy"));
			Console.WriteLine("Current time: {0}", DateTime.Now.ToString("h:mm:ss tt"));
			Console.WriteLine("========================================");

			Program = Programs[0];
			Time = Times[0];

			Console.WriteLine();
			Console.WriteLine("{0} is on tomorrow at {1}", Program, Time);
			Console.WriteLine("Press 'Enter' to get the next program");
			Console.ReadLine();
			Console.WriteLine();

			// Next program
			Console.WriteLine("========================================");
			Console.WriteLine("Welcome to the TV Listings Program");
			Console.WriteLine("Today's date: {0}", DateTime.Now.ToString("dd/M/yyyy"));
			Console.WriteLine("Current time: {0}", DateTime.Now.ToString("h:mm:ss tt"));
			Console.WriteLine("========================================");

			Program = Programs[1];
			Time = Times[1];

			Console.WriteLine();
			Console.WriteLine("{0} is on tomorrow at {1}", Program, Time);
			Console.WriteLine("Press 'Enter' to get the next program");
			Console.ReadLine();
			Console.WriteLine();

			// Next program
			Console.WriteLine("========================================");
			Console.WriteLine("Welcome to the TV Listings Program");
			Console.WriteLine("Today's date: {0}", DateTime.Now.ToString("dd/M/yyyy"));
			Console.WriteLine("Current time: {0}", DateTime.Now.ToString("h:mm:ss tt"));
			Console.WriteLine("========================================");

			Program = Programs[2];
			Time = Times[2];

			Console.WriteLine();
			Console.WriteLine("{0} is on tomorrow at {1}", Program, Time);
			Console.WriteLine("Press 'Enter' to get the next program");
			Console.ReadLine();
			Console.WriteLine();

			// Next program
			Console.WriteLine("========================================");
			Console.WriteLine("Welcome to the TV Listings Program");
			Console.WriteLine("Today's date: {0}", DateTime.Now.ToString("dd/M/yyyy"));
			Console.WriteLine("Current time: {0}", DateTime.Now.ToString("h:mm:ss tt"));
			Console.WriteLine("========================================");

			Program = Programs[3];
			Time = Times[3];

			Console.WriteLine();
			Console.WriteLine("{0} is on tomorrow at {1}", Program, Time);
			Console.WriteLine("Press 'Enter' to get the next program");
			Console.ReadLine();
			Console.WriteLine();
		}
	}
}
