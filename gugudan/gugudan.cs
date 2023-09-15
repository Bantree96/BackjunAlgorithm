using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gugudan
{
	class gugudan
	{
		static void Main(string[] args)
		{
			int number = int.Parse(Console.ReadLine());

			for(int i = 1; i<=9; i++)
			{
				Console.WriteLine($"{number} * {i} = {number * i}");
			}
		}
	}
}
