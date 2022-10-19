using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10._17_Exec_DateTime_Q4
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//Exec_DateTime
			//Q4: 取得本月最後一天?

			//A4-1(方法一): 以當下時間取得本月最後一天
			DateTime date = DateTime.Now;
			//DateTime date = new DateTime(2022, 4, 6); //可以指定某一天
			
			//該日期加一個月
			DateTime nextMonthOfDay = date.AddMonths(1);

			//設定下一個月的第一天
			string firstDayOfNextMonth = nextMonthOfDay.ToString("yyyy/MM/01"); //轉成字串，將幾號轉乘字串01
			//DateTime firstDayOfNextMonth = new DateTime(nextMonthOfDay.Year, nextMonthOfDay.Month, 01); //用時間，直接設定新的時間

			DateTime lastDayOfMonth = Convert.ToDateTime(firstDayOfNextMonth).AddDays(-1);
			Console.WriteLine($"{date.Year} 年 {date.Month} 月的最後一天為 {lastDayOfMonth: yyyy/MM/dd}");
			Console.WriteLine();


			//A4-2(方法二): 輸入任何時間來取得當月最後一天
			Console.Write("請輸入任一時間來取得當月最後一天(範例: 2022/1/1): ");
			string input = Console.ReadLine();

			if ( string.IsNullOrEmpty(input) )
			{
				Console.WriteLine("您沒有輸入任何值");
				return;
			}

			//加一個月
			nextMonthOfDay = Convert.ToDateTime(input).AddMonths(1);

			//獲得下個月的第一天
			DateTime firstDayOfNextMonth2 = new DateTime(nextMonthOfDay.Year, nextMonthOfDay.Month, 01);

			//再減一天獲得本月最後一天
			lastDayOfMonth = firstDayOfNextMonth2.AddDays(-1);
			Console.WriteLine($"{nextMonthOfDay.Year} 年 {nextMonthOfDay.Month - 1 } 月的最後一天是 {lastDayOfMonth: yyyy/MM/dd}");
		}
	}
}
