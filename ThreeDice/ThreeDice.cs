using System;
using System.Linq;

namespace ThreeDice
{
	/// <summary>
	/// 2480번 문제
	/// </summary>
	class ThreeDice
	{
		static string[] _dice_string = new string[3]; 
		static int[] _dice = new int[3]; 
		static void Main(string[] args)
		{
			// 주사위 3개를 입력받는다.
			string dice = Console.ReadLine();
			_dice_string = dice.Split(' ');

			_dice = Array.ConvertAll<string, int>(_dice_string, int.Parse);

			// 주사위 3개가 같은지 확인
			if (ThreeDiceSame(_dice))
			{
			}
			else if (TwoDiceSame(_dice))
			{
			}
			else
			{
				DiceNotSame(_dice);
			}
		}
		private static void DiceNotSame(int[] dice)
		{
			Console.WriteLine(dice.Max() * 100);
		}

		private static bool TwoDiceSame(int[] dice)
		{
			if (dice[0] == dice[1])
			{
				Console.WriteLine(1000 + dice[0] * 100);
				return true;
			}

			if (dice[0] == dice[2])
			{
				Console.WriteLine(1000 + dice[0] * 100);
				return true;
			}

			if (dice[1] == dice[2])
			{
				Console.WriteLine(1000 + dice[1] * 100);
				return true;
			}

			return false;
		}

		private static bool ThreeDiceSame(int[] dice)
		{
			if (dice[0] == dice[1] && dice[1] == dice[2])
			{
				Console.WriteLine(10000 + dice[0] * 1000);

				return true;
			}
			else
			{
				return false;
			}
		}
	}
}
