using System;
using System.Collections.Generic;
using System.Linq;

namespace _9506_약수들의합
{
	class Program
	{
		static void Main(string[] args)
		{
			while (true)
			{
				int number = int.Parse(Console.ReadLine());
				if (number == -1) return;

				// 약수 구하는 공식
				List<int> divisors = new List<int>();
				// 자기 자신을 제외한다.
				for (int i = number-1; i > 0; i--)
				{
					if (number % i == 0)
					{
						divisors.Add(i);
					}
				}
				divisors.Sort();
				
				// 출력
				if (divisors.Sum() == number)
				{
					string divi = string.Join($" + ", divisors);
					Console.WriteLine($"{number} = {divi}");
				}
				else
				{
					Console.WriteLine($"{number} is NOT perfect.");
				}
			}
		}
	}
}
