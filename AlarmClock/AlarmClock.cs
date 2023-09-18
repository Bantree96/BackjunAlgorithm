using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// 입력받은 시간보다 45분 앞서는 시간으로 바꾸는 알고리즘
/// </summary>
namespace AlarmClock
{
	class AlarmClock
	{
		static string[] _time = new string[2];
		static DateTime _dateTime = new DateTime();
		static void Main(string[] args)
		{
			// H시, M분을 입력받는다.
			string time = Console.ReadLine();
			_time = time.Split(' ');

			if (!IsWithinRange(_time[0], 0, 24))
			{
				Console.WriteLine("입력된 시간이 맞지 않습니다.");
			}

			if (!IsWithinRange(_time[1], 0, 60))
			{
				Console.WriteLine("입력된 시간이 맞지 않습니다.");
			}

			_dateTime = CalcTime(_time);

			Console.WriteLine($"{_dateTime.Hour} {_dateTime.Minute}");

		}

		static bool IsWithinRange(string x, int minRange, int maxRange)
		{
			int time = int.Parse(x);
			return time >= minRange && time < maxRange;
		}

		/// <summary>
		/// 입력받은 시간에서 -45분을 한 시간을 반환하는 함수
		/// </summary>
		/// <param name="time"></param>
		/// <returns></returns>
		static DateTime CalcTime(string[] time)
		{
			_dateTime = DateTime.Parse($"2023/09/08 {_time[0]}:{_time[1]}");
			return _dateTime.AddMinutes(-45);
		} 

		
		
	}
}
