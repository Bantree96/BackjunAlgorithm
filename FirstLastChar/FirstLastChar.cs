using System;
using System.Linq;
using System.Text;

namespace FirstLastChar
{
	class FirstLastChar
	{
		static void Main(string[] args)
		{
			int count = int.Parse(Console.ReadLine());
			StringBuilder sb = new StringBuilder();

			for(int i = 0; i < count; i++)
			{
				string text = Console.ReadLine();

				sb.Append(text.First());
				sb.Append(text.Last());
				sb.AppendLine();
			}

			Console.WriteLine(sb.ToString());
		}
	}
}
