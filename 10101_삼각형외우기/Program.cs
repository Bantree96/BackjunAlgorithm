using System;

namespace _10101_삼각형외우기
{
	class Program
	{
		static void Main(string[] args)
		{
			int[] triangle = new int[3];
			for(int i = 0; i < 3; i++)
			{
				triangle[i] = int.Parse(Console.ReadLine());
			}

			int angle = triangle[0] + triangle[1] + triangle[2];
			if(triangle[0] == 60 && triangle[1] == 60 && triangle[2] == 60)
			{
				Console.WriteLine("Equilateral");
				return;

			}	
			
			if(angle == 180)
			{
				if(triangle[0] == triangle[1] || triangle[1] == triangle[2] || triangle[0] == triangle[2])
				{
					Console.WriteLine("Isosceles");
					return;
				}
				
				if(triangle[0] != triangle[1] && triangle[1] != triangle[2] && triangle[0] != triangle[2])
				{
					Console.WriteLine("Scalene");
					return;
				}
			}
			else
			{
				Console.WriteLine("Error");
			}

		}

	}
}
