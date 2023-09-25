using System;
using System.Text;

namespace AB_Sum3
{
	class AB_Sum3
	{
		static void Main(string[] args)
		{
			int count = int.Parse(Console.ReadLine());
			string[] value = new string[2];
			StringBuilder sb = new StringBuilder();

			for (int i = 1; i <= count; i++)
			{
				value = Console.ReadLine().Split(' ');
				int a = int.Parse(value[0]);
				int b = int.Parse(value[1]);
				sb.AppendLine($"Case #{i}: {a} + {b} = {a + b}");
			}

			Console.Write(sb.ToString());
		}
	}
}
