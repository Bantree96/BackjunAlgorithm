using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5073_삼각형과세변
{
	class Program
	{
		static void Main(string[] args)
		{
			int[] triangle = new int[3];
			bool isRun = true;
			while (isRun)
			{

				triangle = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

				// 세 변이 0 일 때
				if (IsZero(triangle))
				{
					return;
				}

				// 삼각형인지 확인
				if (!IsTriangle(triangle))
				{
					Console.WriteLine("Invalid");
					continue;
				}

				SortedSet<int> set = new SortedSet<int>();

				foreach(var line in triangle)
				{
					set.Add(line);
				}


				if (set.Count == 1)
				{
					Console.WriteLine("Equilateral");
				}
				else if(set.Count == 2)
				{
					Console.WriteLine("Isosceles");
				}
				else if(set.Count == 3)
				{
					Console.WriteLine("Scalene");
				}
			}


		}

		private static bool IsTriangle(int[] triangle)
		{
			// 가장 긴 변의 길이보다 나머지 두 변의 길이의 합이 길지 않으면 삼각형이 아니다.
			int maxIndex = Array.IndexOf(triangle, triangle.Max());

			if(maxIndex == 0)
			{
				if(triangle[maxIndex] < triangle[1] + triangle[2])
				{
					return true;
				}
			}
			else if(maxIndex == 1)
			{
				if (triangle[maxIndex] < triangle[0] + triangle[2])
				{
					return true;
				}
			}
			else if (maxIndex == 2)
			{
				if (triangle[maxIndex] < triangle[0] + triangle[1])
				{
					return true;
				}
			}

			return false;
		}

		static bool IsZero(int[] triangle)
		{
			if (triangle[0] == 0 && triangle[1] == 0 && triangle[2] == 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}

	
	}
}
