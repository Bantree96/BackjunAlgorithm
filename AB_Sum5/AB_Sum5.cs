using System;
using System.Text;

namespace AB_Sum5
{
	class AB_Sum5
	{
		static void Main(string[] args)
		{
			string[] value = new string[2];
			StringBuilder sb = new StringBuilder();

			while (true)
			{
				value = Console.ReadLine().Split(' ');
				int a = int.Parse(value[0]);
				int b = int.Parse(value[1]);

				if (a == 0 && b == 0) break;

				sb.AppendLine($"{a + b}");
			}

			Console.Write(sb.ToString());
		}
	}
}
