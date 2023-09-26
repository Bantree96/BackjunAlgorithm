using System;
using System.Linq;

namespace MaxValue
{
	class MaxValue
	{
		static void Main(string[] args)
		{
			int[] numbers = new int[9];
			for(int i=0; i<9; i++)
			{
				numbers[i] = int.Parse(Console.ReadLine());
			}

			Console.WriteLine(numbers.Max());
			Console.WriteLine(Array.FindIndex(numbers, x => x == numbers.Max())+1);
		}
	}
}
