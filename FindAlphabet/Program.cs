using System;

namespace FindAlphabet
{
	class Program
	{
		static void Main(string[] args)
		{
			string input = Console.ReadLine();

			// 배열에 알파벳 넣기
			char[] alphabet = new char[26];

			int arrayPoint = 0;
			for(int j = 97; j <= 122; j++)
			{
				alphabet[arrayPoint] = Convert.ToChar(j);
				arrayPoint++;
			}

			// 알파벳 배열을 돌면서 해당 문자열에 있는지 확인
			for(int i = 0; i<26; i++)
			{
				Console.Write(input.IndexOf(alphabet[i]));
				Console.Write(' ');
			}
		}
	}
}
