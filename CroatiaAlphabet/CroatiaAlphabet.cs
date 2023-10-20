using System;

/// <summary>
/// 옛날엔 크로아티아 알파벳을 입력할 수 없어서 대체문자를 사용했음
/// 몇 개의 크로아티아 알파벳으로 이루어져있는지 출력한다.
/// </summary>
namespace CroatiaAlphabet
{
	class CroatiaAlphabet
	{
		static void Main(string[] args)
		{
			string input = Console.ReadLine();
			int inputLength = input.Length;

			for(int i = 0; i < input.Length; i++)
			{
				// 2개짜리 알파벳 비교
				if (input.Length - i >= 2)
				{
					switch(input.Substring(i, 2))
					{
						case "c=":
						case "c-":
						case "d-":
						case "lj":
						case "nj":
						case "s=":
						case "z=":
							inputLength -= 1;
							i++;
							continue;
					}
				}

				// 3개짜리 알파벳 비교
				if(input.Length - i >= 3)
				{
					switch (input.Substring(i, 3))
					{
						case "dz=":
							inputLength -= 2;
							i += 2;
							continue;
					}
				}
			}

			Console.WriteLine(inputLength);
		}
	}
}
