using System;
using System.Text;

namespace AB_Sum2
{
	class AB_Sum2
	{
		static void Main(string[] args)
		{
			int count = int.Parse(Console.ReadLine());
			string[] numbers = new string[2];
			StringBuilder sb = new StringBuilder();

			for(int i=1; i<=count; i++)
			{
				numbers = Console.ReadLine().Split(' ');
				sb.AppendLine($"Case #{i}: {int.Parse(numbers[0]) + int.Parse(numbers[1])}");
			}

			Console.WriteLine(sb.ToString());
		}
	}
}
