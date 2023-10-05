using System;

namespace CharWithString
{
	class CharWithString
	{
		static void Main(string[] args)
		{
			string text = Console.ReadLine();
			int count = int.Parse(Console.ReadLine());

			Console.WriteLine(text[count-1]);
		}
	}
}
