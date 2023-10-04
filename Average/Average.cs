using System;
using System.Linq;

namespace Average
{
	class Average
	{
		static void Main(string[] args)
		{
			int counts = int.Parse(Console.ReadLine());
			double[] score = Array.ConvertAll(Console.ReadLine().Split(' '), double.Parse);

			double max = score.Max();
			for(int i = 0; i<counts; i++)
			{
				score[i] = score[i] / max * 100;
			}

			Console.WriteLine(score.Average());
		}
	}
}
