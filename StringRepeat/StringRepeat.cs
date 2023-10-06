using System;
using System.Text;

namespace StringRepeat
{
	class StringRepeat
	{
		static void Main(string[] args)
		{
			int count = int.Parse(Console.ReadLine());

			StringBuilder sb = new StringBuilder();
			for(int i = 0; i < count; i++)
			{
				string[] inputs = Console.ReadLine().Split(' ');

				int repeatCount = int.Parse(inputs[0]);
				string text = inputs[1];

				for(int j = 0; j < text.Length; j++)
				{

					for(int k = 0; k < repeatCount; k++)
					{
						sb.Append(text[j]);
					}
					
				}
				sb.AppendLine();
			}

			Console.WriteLine(sb.ToString());
		}
	}
}
