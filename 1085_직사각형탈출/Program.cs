using System;
using System.Linq;

/// <summary>
/// 직사각형에서 탈출하는 문제
/// </summary>
namespace _1085_직사각형탈출
{
	class Program
	{
		static void Main(string[] args)
		{
			int[] inputs = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
			int[] exits = new int[4];
			// 현재 좌표
			int x = inputs[0];
			int y = inputs[1];

			// 직사각형의 사이즈
			int w = inputs[2];
			int h = inputs[3];

			// 0,0에 가깝게 나갈 수 있는지 확인
			exits[0] = x - 0;
			exits[1] = y - 0;

			// 직사각형의 크기에서 가깝게 나갈 수 있는지 확인
			exits[2] = w - x;
			exits[3] = h - y;

			// 가장 가까운 값 출력
			Console.WriteLine(exits.Min());
		}
	}
}
