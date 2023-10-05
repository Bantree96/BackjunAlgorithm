using System;
using System.Text;

namespace ASCIICode
{
	class ASCIICode
	{
		static void Main(string[] args)
		{
			string input = Console.ReadLine();
			if (input == null) return;

			ASCIIEncoding ascii = new ASCIIEncoding();
			byte[] text = ascii.GetBytes(input);

			Console.WriteLine(text[0]);
		}
	}
}
