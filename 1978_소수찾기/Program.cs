using System;

namespace _1978_소수찾기
{
	class Program
	{
		static void Main(string[] args)
		{
			int count = int.Parse(Console.ReadLine());
			int[] numbers = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

			int primeNumberCount = 0;

			for(int i = 0; i < count; i++)
			{
				if (IsPrimeNumber(numbers[i]))
				{
					primeNumberCount++;
				}
			}

			Console.WriteLine(primeNumberCount);
		}

		static bool IsPrimeNumber(int number)
		{
			if (number == 1) return false;

			for(int i = 2; i * i <= number; i++)
			{
				if(number % i == 0)
				{
					return false;
				}
			}
			return true;
		}
	}
}
