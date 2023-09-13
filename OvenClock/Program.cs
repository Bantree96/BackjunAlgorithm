using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OvenClock
{
	class Program
	{
		static string[] _time = new string[2];
		static double _min;

		static DateTime _nowTime = new DateTime();
		static DateTime _cookedTime = new DateTime();

		static void Main(string[] args)
		{
			// 시, 분을 입력받는다.
			string time = Console.ReadLine();
			_time = time.Split(' ');

			// 요리하는데 필요한 분을 입력받는다.
			string cooktime = Console.ReadLine();
			_min = double.Parse(cooktime);

			// 시 분에 요리하는데 필요한 시간을 더한다.
			_nowTime = DateTime.Parse($"2023/09/13 {_time[0]}:{_time[1]}");
			_nowTime = _nowTime.AddMinutes(_min);

			// 더한 시간을 출력한다.

			Console.WriteLine($"{_nowTime.Hour} {_nowTime.Minute}");

		}
	}
}
