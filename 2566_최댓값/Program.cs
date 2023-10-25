using System;

namespace _2566_최댓값
{
	class Program
	{
		static void Main(string[] args)
		{
			int[,] array = new int[9, 9];

			// 2차원 배열 입력
			for (int i = 0; i < 9; i++)
			{
				int[] inputs = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

				for(int j=0; j < 9; j++)
				{
					array[i, j] = inputs[j];
				}
			}

			// maxValue, rows, cols 값 확인
			int maxValue = 0;
			int rows = 1;
			int cols = 1;
			for (int i = 0; i < 9; i++)
			{
				for (int j = 0; j < 9; j++)
				{
					if(maxValue < array[i, j])
					{
						maxValue = array[i, j];
						rows = i + 1;
						cols = j + 1;
					}
				}
			}

			// 결과 출력
			Console.WriteLine(maxValue);
			Console.Write($"{rows} {cols}");
		}
	}
}
