using System;
using System.Text;

namespace AB_Sum4
{
	class AB_Sum4
	{
		static void Main(string[] args)
		{
			string inputs;
			string[] inputArray = new string[2];
			StringBuilder sb = new StringBuilder();
			while (true)
			{
				inputs = Console.ReadLine();
				if (inputs == null) break;

				inputArray = inputs.Split(' ');
				int a = int.Parse(inputArray[0]);
				int b = int.Parse(inputArray[1]);

				sb.AppendLine($"{a + b}");
			}

			Console.Write(sb.ToString());
		}
	}
}
