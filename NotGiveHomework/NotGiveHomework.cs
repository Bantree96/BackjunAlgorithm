using System;

namespace NotGiveHomework
{
	class NotGiveHomework
	{
		static void Main(string[] args)
		{
			int[] studentNumbers = new int[30];
			for(int i = 0; i < 28; i++)
			{
				int number = int.Parse(Console.ReadLine());
				studentNumbers[number - 1] = 1;
			}

			for(int i = 0; i < 30; i++)
			{
				if(studentNumbers[i] == 0)
				{
					Console.WriteLine(i + 1);
				}
			}

		}
	}
}
