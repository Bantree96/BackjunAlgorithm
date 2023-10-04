using System;
using System.Collections.Generic;

namespace BasketReverse
{
	class BasketReverse
	{
		static void Main(string[] args)
		{
			int[] inputs = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
			Stack<int> reversed = new Stack<int>();
			// 바구니의 갯수
			int basketCounts = inputs[0];

			// 반복 횟수
			int counts = inputs[1];

			// 바구니 생성
			int[] baskets = new int[basketCounts];

			// 바구니 값 대입
			for(int i = 0; i < basketCounts; i++)
			{
				baskets[i] = i + 1;
			}

			// 바구니 역순(reverse)
			for(int i = 0; i < counts; i++)
			{
				int[] reverseNum = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

				int start = reverseNum[0] - 1;
				int end = reverseNum[1] - 1;

				for(int j = start; j <= end; j++)
				{
					reversed.Push(baskets[j]);
				}

				for (int j = start; j <= end; j++)
				{
					baskets[j] = reversed.Pop();
				}
			}

			// 출력
			for (int i = 0; i < baskets.Length; i++)
			{
				Console.Write(baskets[i]);
				Console.Write(' ');
			}
		}
	}
}
