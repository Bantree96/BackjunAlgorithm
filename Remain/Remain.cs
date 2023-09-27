using System;
using System.Linq;

namespace Remain
{
	/// <summary>
	/// 서로 다른 값이 몇 개 있는지 출력하는 프로그램을 작성하시오.
	/// => 중복을 제거하는게 목적인 프로그램임
	/// set, Distinct를 해도 상관없으며, 배열로도 처리가 가능함
	/// </summary>
	class Remain
	{
		static void Main(string[] args)
		{
			// 42의 나머지를 하게되면 그 값은 무조건 42안에 들어오게됨.
			int[] inputs = new int[42];

			// 값을 입력받아서 해당 값 인덱스에 1을 입력
			for(int i = 0; i < 10; i++)
			{
				int value = int.Parse(Console.ReadLine()) % 42;

				inputs[value] = 1;
			}

			// 1이 있는 인덱스만 찾으면 해당 값
			var array = Array.FindAll(inputs, x => x == 1);
			Console.WriteLine(array.Length);
		}


		static int ArrayDistinct()
		{
			int[] inputs = new int[10];

			for(int i = 0; i < 10; i++)
			{
				int value = int.Parse(Console.ReadLine()) % 42;
				inputs[i] = value;
			}
			var array2 = inputs.Distinct();

			return array2.Count();
		}

		/*
		static int ArrayIf()
		{
			for (int i = 0; i < 10; i++)
			{
				nums[i] = int.Parse(Console.ReadLine()) % 42;

				if (i > 0)
				{
					bool check = true;
					for (int j = 0; j < i; j++)
					{
						if (nums[i] == nums[j]) check = false;
					}
					if (check) count++;
				}
			}
		}
		*/

	}
}
