using System;

namespace _11653_소인수분해
{
	class Program
	{

		static void Main(string[] args)
		{
			int number = int.Parse(Console.ReadLine());

			if (number == 1) return;

			for (int i = 2; i <= number; i++)
			{
				while (number % i == 0)
				{
					Console.WriteLine(i);
					number /= i;
				}
			}

		}

	}
}
