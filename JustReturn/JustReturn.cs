using System;

namespace JustReturn
{
	class JustReturn
	{
		static void Main(string[] args)
		{
			try
			{
				int count = 0;
				while (count < 100)
				{
					string input = Console.ReadLine();

					// 빈 줄인지 확인
					if (input == null || input == "") return;

					// 각 줄이 100글자를 넘지 않는지 확인
					//if (input.Length > 100) throw new ArgumentOutOfRangeException();

					// 공백으로 끝나지 않는다.
					Console.WriteLine(input.Trim());

					count++;
				}
			}
			catch (Exception)
			{
				throw;
			}
		}
	}
}
