using System;

namespace Chess
{
	class Chess
	{
		static void Main(string[] args)
		{
			// 킹1, 퀸1, 룩2, 비숍2, 나이트2, 폰8
			int[] chess = new int[] { 1, 1, 2, 2, 2, 8 };

			int[] inputs = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

			Console.Write($"{chess[0] - inputs[0]} ");
			Console.Write($"{chess[1] - inputs[1]} ");
			Console.Write($"{chess[2] - inputs[2]} ");
			Console.Write($"{chess[3] - inputs[3]} ");
			Console.Write($"{chess[4] - inputs[4]} ");
			Console.Write($"{chess[5] - inputs[5]}");

		}
	}
}
