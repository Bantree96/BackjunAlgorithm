using System;

namespace _10798_세로읽기
{
	class Program
	{
		static void Main(string[] args)
		{
			string[,] text = new string[5,15];
			text.Initialize();

			// 입력
			for(int i = 0; i < 5; i++)
			{
				string input = Console.ReadLine();

				for(int j = 0; j < input.Length; j++)
				{
					text[i, j] = input[j].ToString();
				}
			}


			// 출력
			for(int j = 0; j < 15; j++)
			{
				for(int i = 0; i < 5; i++)
				{
					if(text[i,j] == null)
					{
						continue;
					}
					else
					{
						Console.Write(text[i, j]);
					}
				}
			}
		}
	}
}
