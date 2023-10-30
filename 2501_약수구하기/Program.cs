using System;
using System.Collections.Generic;

namespace _2501_약수구하기
{
	class Program
	{
		static void Main(string[] args)
		{
			int[] inputs = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

			int number = inputs[0];
			int index = inputs[1];

			// divisor = 약수
			List<int> divisors = new List<int>();
			for(int i = number; i > 0; i--)
			{
				if(number % i == 0)
				{
					divisors.Add(i);
				}
			}
			divisors.Sort();

			// try-catch사용한것보다 메모리에 이점이 있음
			if(divisors.Count < index)
			{
				Console.WriteLine(0);
			}
			else
			{
				Console.WriteLine(divisors[index - 1]);
			}
		}
	}
}
