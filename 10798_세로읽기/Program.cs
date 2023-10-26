using System;

namespace _10798_세로읽기
{
	class Program
	{
		static void Main(string[] args)
		{
			int rows = 5;
			int cols = 15;

			string[,] text = new string[rows, cols];
			text.Initialize();

			// 입력
			for(int i = 0; i < rows; i++)
			{
				string input = Console.ReadLine();

				for(int j = 0; j < input.Length; j++)
				{
					text[i, j] = input[j].ToString();
				}
			}


			// 출력
			for(int j = 0; j < cols; j++)
			{
				for(int i = 0; i < rows; i++)
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
