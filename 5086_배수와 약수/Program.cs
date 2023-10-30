using System;

namespace _5086_배수와_약수
{
	class Program
	{
		static void Main(string[] args)
		{
			while (true)
			{
				int[] inputs = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

				int a = inputs[0];
				int b = inputs[1];

				if(a == 0 && b == 0)
				{
					break;
				}

				int c = a % b;
				if(c == a)
				{
					Console.WriteLine("factor");
				}
				else if(c == 0)
				{
					Console.WriteLine("multiple");
				}
				else
				{
					Console.WriteLine("neither");
				}
			}
		}
	}
}
