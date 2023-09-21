using System;
using System.Text;

/// <summary>
/// 1초 이내에 A + B를 입력받아 결과를 출력하는 문제
/// </summary>
namespace FastSum
{
	class FastSum
	{
		static void Main(string[] args)
		{
			int count = int.Parse(Console.ReadLine());
			string[] value = new string[2];
			StringBuilder sb = new StringBuilder();
			int a = 0;
			int b = 0;

			for(int i = 0; i<count; i++)
			{
				// Read 부분은 크게 문제가 되지않음
				value = Console.ReadLine().Split(' ');
				a = int.Parse(value[0]);
				b = int.Parse(value[1]);
				sb.AppendLine($"{a + b}");
			}
			// 출력부분이 문제가 되기 때문에 StringBuilder를 사용했음
			Console.WriteLine(sb.ToString());
		}
	}
}
