using System;
using System.IO;
using System.Text;

namespace ANSItoUTF8
{
	class Program
	{
		static void Main(string[] args)
		{
			if (args.Length != 1)
			{
				Console.WriteLine("Unexpected situation! Check parameters.");
				Console.ReadKey();
				return;
			}
			string path = args[0]; // source and target path are the same

			string[] faultyLines = File.ReadAllLines(path, Encoding.UTF8); // ANSI input, in fact it is UTF8 but is recorded as ANSI
			File.WriteAllLines(path, faultyLines, Encoding.UTF8);

		}

	}
}
