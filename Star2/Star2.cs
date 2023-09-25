using System;
using System.Text;

namespace Star2
{
	class Star2
	{
		static void Main(string[] args)
		{
			int count = int.Parse(Console.ReadLine());
			int count2 = count;
			StringBuilder sb = new StringBuilder();

			for(int i=1; i<=count; i++)
			{
				for(int k=count2; k>1; k--)
				{
					sb.Append(' ');
				}
				for(int j=0; j<i; j++)
				{
					sb.Append('*');
				}

				count2 -= 1;
				sb.AppendLine();
			}

			Console.Write(sb.ToString());

		}
	}
}
