using System;
using System.Collections.Generic;

namespace AB_Sum
{
	class AB_Sum
	{
		static void Main(string[] args)
		{
			int count = int.Parse(Console.ReadLine());

			string[] readLine = new string[2];
			List<int> a = new List<int>();
			List<int> b = new List<int>();

			// 입력
			for(int i=0; i<count; i++)
			{
				readLine = Console.ReadLine().Split(' ');

				a.Add(int.Parse(readLine[0]));
				b.Add(int.Parse(readLine[1]));

			}

			// 출력
			for(int i=0; i<count; i++)
			{
				Console.WriteLine($"{a[i] + b[i]}");
			}
		}
	}
}
