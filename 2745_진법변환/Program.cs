using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2745_진법변환
{
	class Program
	{
		static void Main(string[] args)
		{
			string index = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZ";
			string[] inputs = Console.ReadLine().Split(' ');

			string num = inputs[0];
			int based = int.Parse(inputs[1]);

			int based10 = 0;
			int p = num.Length -1;
			for(int i = 0; i < num.Length; i++)
			{
				based10 += index.IndexOf(num[i]) * based ^ p--;
			}

			Console.WriteLine(based10);
		}
	}
}
