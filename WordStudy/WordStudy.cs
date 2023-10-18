using System;
using System.Collections.Generic;

/// <summary>
/// 단어에서 가장 많이 사용된 알파벳을 알아보는 문제
/// 배열로 처리하는게 훨씬 빠르고 좋다고 판단됨.
/// </summary>
namespace WordStudy
{
	class WordStudy
	{
		static void Main(string[] args)
		{
			string input = Console.ReadLine().ToUpper();
			Dictionary<string, int> inputDict = new Dictionary<string, int>();

			string _maxChar = "";
			int _maxCount = 0;

			// 딕셔너리에 각 문자의 갯수를 입력
			for (int i = 0; i < input.Length; i++)
			{
				if (inputDict.ContainsKey(input[i].ToString()))
				{
					inputDict[input[i].ToString()] = inputDict[input[i].ToString()] + 1;
				}
				else
				{
					inputDict.Add(input[i].ToString(), 1);
				}
			}

			// 어떤 값이 가장 많이 나왔는지 확인
			foreach(var data in inputDict)
			{
				if (data.Value == _maxCount)
				{
					_maxChar = "?";
				}
				if (data.Value > _maxCount)
				{
					_maxCount = data.Value;
					_maxChar = data.Key;
				}
				
			}

			Console.WriteLine(_maxChar);
		}
	}
}
