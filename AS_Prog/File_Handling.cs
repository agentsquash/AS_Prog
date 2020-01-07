using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace AS_Prog
{
	class File_Handling
	{
		const string fileName = "N:/12CP1_19-21/Alex Ashley/Console.txt";
		public static void Question1()
		{
			StreamReader file = new StreamReader(fileName);

			string[] text = file.ReadToEnd().Split("\n");
			Console.WriteLine("{0}", string.Join("\n", text));
		}

		public static void Question2()
		{
			StreamReader file = new StreamReader(fileName);
			StreamWriter newFile = new StreamWriter("N:/12CP1_19-21/Alex Ashley/LineConsole.txt");

			string[] text = file.ReadToEnd().Split("\n");
			for (int i = 0; i < text.Length; i++)
			{
				newFile.WriteLine("{0} {1}", i + 1, text[i]);
			}
		}

		public static void Question3a()
		{
			StreamReader file = new StreamReader(fileName);

			string[] ConsoleArray = file.ReadToEnd().Split("\n");
			Console.WriteLine(ConsoleArray[8]);
			Console.WriteLine(ConsoleArray[2]);
			Console.WriteLine(ConsoleArray.Length);
		}

		public static void Question3b()
		{
			StreamReader file = new StreamReader(fileName);
			List<string> ConsoleList = new List<string>();

			string line = file.ReadLine();

			while (line != null)
			{
				ConsoleList.Add(line);
				line = file.ReadLine();
			}
		}
	}
}
