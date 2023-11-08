using System;
using System.Collections.Generic;
using System.Linq;

namespace _2581_소수
{
	class Program
	{
		static List<int> _primeSum = new List<int>();
		static void Main(string[] args)
		{
			int number1 = int.Parse(Console.ReadLine());
			int number2 = int.Parse(Console.ReadLine());

			for (int i = number1; i <= number2; i++)
			{
				if (IsPrimeNumber(i))
				{
					_primeSum.Add(i);
				}
			}

			if(_primeSum.Count == 0)
			{
				Console.WriteLine(-1);
			}
			else
			{
				Console.WriteLine(_primeSum.Sum());
				Console.WriteLine(_primeSum.Min());
			}
		}

		static bool IsPrimeNumber(int number)
		{
			if (number == 1) return false;

			for (int i = 2; i * i <= number; i++)
			{
				if (number % i == 0)
				{
					return false;
				}
			}
			return true;
		}
	}
}
