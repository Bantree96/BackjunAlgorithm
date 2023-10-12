using System;

namespace Star7
{
	class Star7
	{
		static void Main(string[] args)
		{
			int input = int.Parse(Console.ReadLine());

			int starCount = 1;
			int spaceCount = input - 1;
			for(int i = 0; i < input; i++)
			{
				for(int j = 0; j < spaceCount; j++)
				{
					Console.Write(" ");
				}
				for (int s = 0; s < starCount; s++)
				{
					Console.Write("*");
				}

				Console.WriteLine();
				
				if(i == input - 1) { break; }

				starCount += 2;
				spaceCount -= 1;

			}

			for (int i = input -1; i > 0; i--)
			{
				starCount -= 2;
				spaceCount += 1;

				for (int j = 0; j < spaceCount; j++)
				{
					Console.Write(" ");
				}
				for (int s = 0; s < starCount; s++)
				{
					Console.Write("*");
				}

				Console.WriteLine();
			}

		}
	}
}
