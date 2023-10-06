using System;
using System.Linq;

namespace Sangsu
{
	/// <summary>
	/// 상수는 숫자를 반대로 본다.
	/// </summary>
	class Sansu
	{
		static void Main(string[] args)
		{
			string[] inputs = Console.ReadLine().Split(' ');

			int a = ReverseNumber(inputs[0]);
			int b = ReverseNumber(inputs[1]);

			if(a > b)
			{
				Console.WriteLine(a);
			}
			else
			{
				Console.WriteLine(b);
			}
		}
		
		/// <summary>
		/// 문자열을 받아서 Reverse 후 int로 반환
		/// </summary>
		/// <param name="number">문자열</param>
		/// <returns></returns>
		static int ReverseNumber(string number)
		{
			var a = number.Reverse();
			return int.Parse(string.Concat(a));
		}
	}
}
