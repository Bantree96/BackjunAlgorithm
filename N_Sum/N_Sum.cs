using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N_Sum
{
	/// <summary>
	/// 1부터 n 까지 합을 구해 출력하는 문제
	/// </summary>
	class N_Sum
	{
		static void Main(string[] args)
		{
			int sumResult = 0;
			int n = int.Parse(Console.ReadLine());
			for(int i=1; i<=n; i++)
			{
				sumResult += i;
			}

			Console.WriteLine(sumResult);
		}
	}
}
