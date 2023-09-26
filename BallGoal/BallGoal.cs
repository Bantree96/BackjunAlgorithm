using System;

namespace BallGoal
{
	class BallGoal
	{
		static void Main(string[] args)
		{
			string[] CountInputs = new string[2];
			CountInputs = Console.ReadLine().Split();

			int basketCount = int.Parse(CountInputs[0]);
			int ballCount = int.Parse(CountInputs[1]);

			int[] baskets = new int[basketCount];
			string[] valueInputs = new string[3];
			
			// 공이 있는 만큼 던짐
			for(int i=1; i<=ballCount; i++)
			{
				valueInputs = Console.ReadLine().Split();
				int first = int.Parse(valueInputs[0]);
				int last = int.Parse(valueInputs[1]);
				int ballNumber = int.Parse(valueInputs[2]);

				for(int j = first-1; j < last; j++)
				{
					baskets[j] = ballNumber;
				}
			}

			for(int i=0; i<baskets.Length; i++)
			{
				Console.Write(baskets[i]);
				Console.Write(' ');
			}
		}
	}
}
