using System;

namespace YourGrade
{
	class YourGrade
	{
		static void Main(string[] args)
		{
			// 이수시간의 총합
			float totalScore = 0.0f;
			// 이수시간 * 등급
			float gradeScore = 0.0f;

			for(int i = 0; i < 20; i++)
			{

				string[] inputs = Console.ReadLine().Split(' ');

				// 등급 더하기
				switch (inputs[2])
				{
					case "A+":
						// 학점 더하기
						totalScore += float.Parse(inputs[1]);
						gradeScore += float.Parse(inputs[1]) * 4.5f;
						break;
					case "A0":
						// 학점 더하기
						totalScore += float.Parse(inputs[1]);
						gradeScore += float.Parse(inputs[1]) * 4.0f;
						break;
					case "B+":
						// 학점 더하기
						totalScore += float.Parse(inputs[1]);
						gradeScore += float.Parse(inputs[1]) * 3.5f;
						break;
					case "B0":
						// 학점 더하기
						totalScore += float.Parse(inputs[1]);
						gradeScore += float.Parse(inputs[1]) * 3.0f;
						break;
					case "C+":
						// 학점 더하기
						totalScore += float.Parse(inputs[1]);
						gradeScore += float.Parse(inputs[1]) * 2.5f;
						break;
					case "C0":
						// 학점 더하기
						totalScore += float.Parse(inputs[1]);
						gradeScore += float.Parse(inputs[1]) * 2.0f;
						break;
					case "D+":
						// 학점 더하기
						totalScore += float.Parse(inputs[1]);
						gradeScore += float.Parse(inputs[1]) * 1.5f;
						break;
					case "D0":
						// 학점 더하기
						totalScore += float.Parse(inputs[1]);
						gradeScore += float.Parse(inputs[1]) * 1.0f;
						break;
					case "P":
						break;
					case "F":
						totalScore += float.Parse(inputs[1]);
						gradeScore += float.Parse(inputs[1]) * 0.0f;
						break;
				}
			}

			if(gradeScore == 0 && totalScore == 0)
			{
				Console.WriteLine("0.000000");
			}
			else
			{
				Console.WriteLine(gradeScore / totalScore);
			}
		}
	}
}
