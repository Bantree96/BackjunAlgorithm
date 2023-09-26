using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BallChange
{
	class Program
	{
		static void Main(string[] args)
		{
			int[] inputs = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
			int[] baskets = new int[inputs[0]];

			// 바구니 별로 공 넣기
			for(int i = 0; i<baskets.Length; i++)
			{
				baskets[i] = i + 1;
			}

			// 공 바꾸기
			for(int i = 0; i<inputs[1]; i++)
			{
				int[] ChangeBasket = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
				int temp = 0;

				temp = baskets[ChangeBasket[0] - 1];
				baskets[ChangeBasket[0] - 1] = baskets[ChangeBasket[1] - 1];
				baskets[ChangeBasket[1] - 1] = temp; 
			}

			// 결과 출력
			for(int i = 0; i<baskets.Length; i++)
			{
				Console.Write(baskets[i]);
				Console.Write(' ');
			}
		}
	}
}
