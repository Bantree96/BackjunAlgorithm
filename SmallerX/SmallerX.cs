using System;
using System.Text;

namespace SmallerX
{
	class SmallerX
	{
		static void Main(string[] args)
		{
			string[] inputs = new string[2];
			inputs = Console.ReadLine().Split();

			int count = int.Parse(inputs[0]);
			int standard = int.Parse(inputs[1]);

			string[] values = new string[count];
			int[] valuesInt = new int[count];
			values = Console.ReadLine().Split();

			valuesInt = Array.ConvertAll<string, int>(values, int.Parse);
			FindSmaller(valuesInt, standard);

			StringBuilder sb = new StringBuilder();

			for (int i = 0; i<count; i++)
			{
				if(valuesInt[i] < standard)
				{
					sb.Append($"{valuesInt[i]}");
					sb.Append($" ");
				}
			}

			Console.WriteLine(sb.ToString());
		}

		private static void FindSmaller(int[] array, int standard)
		{
			int[] a = Array.FindAll(array, x => x < standard);

			for(int i =0; i<a.Length; i++)
			{
				Console.Write($"{a[i]} ");
			}
		}
	}

	
}
