using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quadrant
{
	class Quadrant
	{
		private static int _x, _y;
		static void Main(string[] args)
		{

			// 1줄 읽어서 정수 X받기(-1000 <= x <= 1000, x!=0)
			_x = int.Parse(Console.ReadLine());
			if(!IsWithinRange(_x,-1000,1000))
			{
				return;
			}

			if(_x == 0)
			{
				return;
			}


			// 1줄 읽어서 정수 Y받기(-1000 <= x <= 1000, x!=0)
			_y = int.Parse(Console.ReadLine());
			if (!IsWithinRange(_y, -1000, 1000))
			{
				return;
			}

			if (_y == 0)
			{
				return;
			}

			Console.WriteLine(CalcQuadrant(_x, _y));
		}

		static bool IsWithinRange(int x, int minRange, int maxRange)
		{
			return x >= minRange && x <= maxRange;
		}

		static int CalcQuadrant(int x, int y)
		{
			if(x > 0 && y > 0)
			{
				return 1;
			} 
			if(x < 0 && y > 0)
			{
				return 2;
			}
			if(x < 0 && y < 0)
			{
				return 3;
			}
			if(x > 0 && y < 0)
			{
				return 4;
			}
			return 0;
		}
	}
}
