using System;

namespace _2738_행렬덧셈
{
	class Program
	{
		static void Main(string[] args)
		{
			int[] inputs = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

			int rows = inputs[0];
			int cols = inputs[1];

			int[,] a = new int[rows, cols];
			int[,] b = new int[rows, cols];
			int[,] c = new int[rows, cols];
		
			// 행렬 A 입력
			for (int i = 0; i < rows; i++)
			{
				int[] nums = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

				for (int j = 0; j < cols; j++)
				{
					a[i, j] = nums[j];
				}
			}
		

			// 행렬 B 입력
			for (int i = 0; i < rows; i++)
			{
				int[] nums = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

				for (int j = 0; j < cols; j++)
				{
					b[i, j] = nums[j];
				}
			}

			// 행렬 A + B
			for (int i = 0; i < rows; i++)
			{
				for (int j = 0; j < cols; j++)
				{
					c[i, j] = a[i, j] + b[i, j];
				}
			}

			// 출력
			for (int i = 0; i < rows; i++)
			{
				for (int j = 0; j < cols; j++)
				{
					Console.Write($"{c[i, j]} ");
				}
				Console.WriteLine();
			}

		}
	}
}
