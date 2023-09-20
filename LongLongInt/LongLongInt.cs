using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LongLongInt
{
	class LongLongInt
	{
		static void Main(string[] args)
		{
			int n = int.Parse(Console.ReadLine());

			int count = n / 4;

			for(int i = 0; i<count; i++)
			{
				Console.Write("long ");
			}

			Console.Write("int");
		}
	}
}
