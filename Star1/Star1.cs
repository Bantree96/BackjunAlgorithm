using System;
using System.Text;

namespace Star1
{
	class Star1
	{
		static void Main(string[] args)
		{
			int count = int.Parse(Console.ReadLine());
			StringBuilder sb = new StringBuilder();
			for(int i=1; i<=count; i++)
			{
				for (int j = 0; j < i; j++)
				{
					sb.Append('*');
				}
				sb.AppendLine();
			}

			Console.Write(sb.ToString());
		}
	}
}
