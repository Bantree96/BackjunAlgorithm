using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Receipt
{
	/// <summary>
	/// 25304 : 영수증
	/// 영수증의 값과 계산한 값이 맞는지 확인하는 문제
	/// </summary>
	class Receipt
	{
		static void Main(string[] args)
		{
			int receiptPrice = int.Parse(Console.ReadLine());
			int itemCount = int.Parse(Console.ReadLine());
			Item[] items = new Item[itemCount];
			string[] item = new string[2];

			for(int i=0; i<itemCount; i++)
			{
				item = Console.ReadLine().Split(' ');
				items[i] = new Item(int.Parse(item[0]), int.Parse(item[1]));
			}

			Calc(items, receiptPrice);
		}

		// 영수증의 값과 계산한 값이 맞는지 확인한다.
		static void Calc(Item[] items, int receiptPrice)
		{
			int finalPrice = 0;
			for (int i = 0; i < items.Length; i++)
			{
				finalPrice += (items[i].Count * items[i].Price);
			} 

			if(finalPrice == receiptPrice)
			{
				Console.WriteLine("Yes");
			}
			else
			{
				Console.WriteLine("No");
			}
		}
	}

	public class Item
	{
		public int Price;
		public int Count;

		public Item(int price, int count)
		{
			Price = price;
			Count = count;
		}
	}
}
