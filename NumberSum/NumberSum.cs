using System;

namespace NumberSum
{
	/// <summary>
	/// Char를 Int로 변환하는 방법이 다양한듯 하다.
	/// </summary>
	class NumberSum
	{
		static void Main(string[] args)
		{
			int count = int.Parse(Console.ReadLine());
			string numbers = Console.ReadLine();

			int result = 0;
			for(int i = 0; i < count; i++)
			{
				result += int.Parse(numbers[i].ToString());
			}
			Console.WriteLine(result);
		}
	}
}
