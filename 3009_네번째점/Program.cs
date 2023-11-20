using System;
using System.Collections.Generic;

namespace _3009_네번째점
{
	class Program
	{
		static void Main(string[] args)
		{
			Queue<int> x = new Queue<int>();
			Queue<int> y = new Queue<int>();

			// 3점의 좌표를 입력받는다.
			for (int i = 0; i < 3; i++)
			{
				int[] xy = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

				x.Enqueue(xy[0]);
				y.Enqueue(xy[1]);
			}

			// x가 두번 나오지 않은 수.
			int resultX = DistinctValue(x);
			int resultY = DistinctValue(y);

			Console.WriteLine($"{resultX} {resultY}");
		}

		/// <summary>
		/// 리스트에서 중복되지 않는 수를 찾는 함수
		/// </summary>
		/// <param name="list"></param>
		/// <returns></returns>
		static int DistinctValue(Queue<int> list)
		{
			int value = 0;

			for(int i = 0; i < list.Count; i++)
			{
				int num = list.Dequeue();
				if(!list.Contains(num))
				{
					value = num;
				}
				list.Enqueue(num);
			}

			return value;
		}
	}
}
