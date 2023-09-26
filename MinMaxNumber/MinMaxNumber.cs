using System;
using System.Linq;

namespace MinMaxNumber
{
	class MinMaxNumber
	{
		static void Main(string[] args)
		{
			int count = int.Parse(Console.ReadLine());

			string[] inputs = new string[count];
			inputs = Console.ReadLine().Split(' ');
			int[] numbers;
			numbers = Array.ConvertAll(inputs, int.Parse);

			Console.Write(numbers.Min());
			Console.Write(' ');
			Console.Write(numbers.Max());

		}
	}
}
