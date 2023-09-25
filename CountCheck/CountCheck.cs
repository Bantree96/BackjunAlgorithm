using System;

namespace CountCheck
{
	class CountCheck
	{
		static void Main(string[] args)
		{
			int count = int.Parse(Console.ReadLine());
			int wantCount = 0;
			string[] inputs = new string[count];
			inputs = Console.ReadLine().Split();

			string want = Console.ReadLine();

			for(int i=0; i<count; i++)
			{
				if(inputs[i] == want)
				{
					wantCount++;
				}
			}

			//_ = Array.FindAll(inputs, x => x == want).Length;
			Console.WriteLine(wantCount);
		}
	}
}
