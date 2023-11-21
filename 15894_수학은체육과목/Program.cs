using System;

namespace _15894_수학은체육과목
{
	/// <summary>
	/// 입력이 1 <= n <= 10의 9승인데 10의9승을 넣으면 int.max보다 커 예외 발생
	/// </summary>
	class Program
	{
		static void Main(string[] args)
		{
			long boxCount = int.Parse(Console.ReadLine());
			long result = 0;

			//for (int i = 0; i < boxCount; i++)
			//{
			//	result += 3;
			//}

			//result += boxCount;

			result = 4 * boxCount;

			Console.WriteLine(result);
		}
	}
}
