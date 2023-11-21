using System;
using System.Collections.Generic;
using System.Linq;

/// <summary>
/// 좌표를 입력받아 직사각형 땅의 넓이를 구하는 문제
/// </summary>
namespace _9063_대지
{
	class Program
	{
		static void Main(string[] args)
		{
			int dotCount = int.Parse(Console.ReadLine());
			
			List<int> x = new List<int>();
			List<int> y = new List<int>();

			// 옥구슬 좌표 입력
			int[] coordinate = new int[2];
			for (int i = 0; i< dotCount; i++)
			{
				coordinate = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

				x.Add(coordinate[0]);
				y.Add(coordinate[1]);
			}

			// 점의 갯수가 부족해 계산 할 수 없을 때 
			if(dotCount <= 1)
			{
				Console.WriteLine(0);
				return;
			}

			// 사각형의 넓이 계산
			int result = (x.Max() - x.Min()) * (y.Max() - y.Min());
			Console.WriteLine(result);
		}
	}
}
