using System;

namespace WordCounts
{
	class WordCounts
	{
		static void Main(string[] args)
		{
			
			string inputs = Console.ReadLine();
			string[] texts;
			inputs = inputs.Trim();

			texts = inputs.Split(' ');

			if(texts.Length == 1 && texts[0].Equals(""))
			{
				Console.WriteLine(0);
				return;
			}

			Console.WriteLine(texts.Length);
		}
	}
}
