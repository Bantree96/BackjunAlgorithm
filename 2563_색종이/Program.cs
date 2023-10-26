using System;

namespace _2563_색종이
{
	class Program
	{
		static void Main(string[] args)
		{
			int[,] box = new int[100, 100];

			int paperCount = int.Parse(Console.ReadLine());
			int area = 0;

			// 종이의 갯수만큼 반복
			for(int i = 0; i < paperCount; i++)
			{
				int[] inputs = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

				int x = inputs[0];
				int y = inputs[1];

				// 도화지에 색종이를 붙인다.
				for(int j = y; j < y + 10; j++)
				{
					for(int k = x; k < x + 10; k++)
					{
						// 붙어있지 않다면
						if(box[j,k] != 1)
						{ 
							box[j, k] = 1;
							area++;
						}
					}
				}
			}

			Console.WriteLine(area);
		}
	}
}
