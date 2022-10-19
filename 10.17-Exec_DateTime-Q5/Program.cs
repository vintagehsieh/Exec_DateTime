using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace _10._17_Exec_DateTime_Q5
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//Exec_DateTime
			//Q5: 列出指定年份的每一個星期日?

			//A5-1(方法一): 指定2022年

			//從今天取得2022的年分
			DateTime day = DateTime.Now;
			int year = day.Year;

			//判斷今年有幾天，取決於閏年
			int daysOfYears = (DateTime.IsLeapYear(year) == true) ? 366 : 365;

			//列出該年分的每一個星期日
			//先找出該年分第一天
			DateTime firstDay = new DateTime(day.Year, 1, 1);


			for (int i = 0; i < daysOfYears; i++)
			{
				DateTime testDate1 = firstDay.AddDays( );

				if ( testDate1.DayOfWeek == DayOfWeek.Sunday)
				{
					Console.WriteLine($"{year} 年的第 {i/7+1,2} 個星期天是 {testDate1.ToString("yyyy/MM/dd")}");
				}
			}
			Console.WriteLine();


			//A5-2: 取得任意指定的年份所有星期天的日期
			Console.Write("請輸入想到所有禮拜天日期的年份: ");
			string input = Console.ReadLine();
			DateTime firstDayOfRanYear = new DateTime(Convert.ToInt32(input), 1, 1); //設定任意輸入年度的第一天


			//防呆
			if ( string.IsNullOrEmpty(input) )
			{
				Console.WriteLine("您沒有輸入數值。");
				return;
			}

			//求取當年天數
			DateTime randomYear = Convert.ToDateTime(firstDayOfRanYear);
			int daysOfRandomYear = (DateTime.IsLeapYear(randomYear.Year)) ? 366 : 365;

			//列出該年所有星期日的日期
			for (int i = 0; i < daysOfRandomYear; i++)
			{
				DateTime testDate = firstDayOfRanYear.AddDays(i);


				if ( testDate.DayOfWeek == DayOfWeek.Sunday)
				{
					Console.WriteLine($"{randomYear.Year} 年的第 {i/7+1,2} 個星期日的日期是 {testDate.ToString("yyyy/MM/dd")}");
				}
			}

		}
	}
}
