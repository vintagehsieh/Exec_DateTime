using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10._17_Exec_DateTime_Q3
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//Exec_DateTime
			//Q3: 取得本月第一天?

			//A3-1: 以現在時間來取得當月第一天
			DateTime date = DateTime.Now;
			//DateTime date = new DateTime(2020, 3, 5); //給定某天日奇來取得
			string firstDayOfMonth = date.ToString("yyyy/MM/01");
			Console.WriteLine(firstDayOfMonth);
			Console.WriteLine();

			//A3-2: 給定隨便一天來取得當月第一天
			Console.Write("請輸入想取得該月第一天的日期(範例: 2022/1/1): ");
			string input = Console.ReadLine();
			bool isDate = DateTime.TryParse(input, out DateTime ranDay);

			//防呆
			if ( string.IsNullOrEmpty(input) )
			{
				Console.WriteLine("您沒有輸入日期。");
				return;
			}

			//取得第一天
			DateTime randomDay = Convert.ToDateTime(input); //要確定使用者輸入的格式和數值正確
			firstDayOfMonth = randomDay.ToString($"{randomDay: yyyy/MM/01}");
			Console.WriteLine($"{randomDay.Year} 年 {randomDay.Month} 月的第一天是{firstDayOfMonth}");

		}
	}
}
