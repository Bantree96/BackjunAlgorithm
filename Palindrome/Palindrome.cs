using System;
using System.Linq;

/// <summary>
/// 팰린드롬 = 회문
/// 뒤집어도 같은말이되는 말
/// ex. 거꾸로해도 우영우 기러기 별똥별
/// </summary>
namespace Palindrome
{
	class Palindrome
	{
		static void Main(string[] args)
		{
			string input = Console.ReadLine();
			char[] inputArray = input.ToArray();
			char[] copyArray = new char[inputArray.Length];

			inputArray.CopyTo(copyArray, 0);
			Array.Reverse(inputArray);

			if(IsPalindrome(inputArray, copyArray))
			{
				Console.WriteLine(1);
			} 
			else
			{
				Console.WriteLine(0);
			}
		}

		static bool IsPalindrome(char[] input, char[] reverse)
		{
			for(int i = 0; i < input.Length; i++)
			{
				if (input[i] != reverse[i])
				{
					return false;
				}
			}
			return true;
		}

		// reverse의 뒤쪽 인덱스 부터 비교하는 방법도 있음
	}
}
