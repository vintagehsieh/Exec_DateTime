using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10._17_Exec_DateTime_Q6
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//Exec_DateTime
			//Q6: 根據日期，傳回今天是本月的上旬、中旬或下旬?


			//A6-1(方法一): 判斷當下時間為當月的上、中、下旬?
			DateTime today = DateTime.Today;
			int day = today.Day;

			//判斷
			if (day > 0 && day < 10)
			{
				Console.WriteLine($"{today.Month} 月 {day} 號為 {today.Month} 月的上旬");
			}
			else if (day >= 10 && day < 20)
			{
				Console.WriteLine($"{today.Month} 月 {day} 號為 {today.Month} 月的中旬");
			}
			else
			{
				Console.WriteLine($"{today.Month} 月 {day} 號為 {today.Month} 月的下旬");
			}
			Console.WriteLine();


			//A6-2(方法二): 透過輸入日期判斷為該月上、中、下旬的日期
			Console.Write("請輸入想要判斷為上中下期的日期(範例: 2020/1/1): ");
			string input = Console.ReadLine();

			//將輸入字串改成時間，並宣告該日期的狀態變數
			bool isDateTime = DateTime.TryParse(input, out DateTime phaseOfDay);

			//防呆
			if (string.IsNullOrEmpty(input))
			{
				Console.WriteLine("您沒有輸入任何值。");
				return;
			}

			//判斷
			if (phaseOfDay.Day > 0 && phaseOfDay.Day < 10)
			{
				Console.WriteLine($"{phaseOfDay.Month} 月 {phaseOfDay.Day} 號是 {phaseOfDay.Month} 月的上旬");
			}
			else if (phaseOfDay.Day >= 10 && phaseOfDay.Day < 20)
			{
				Console.WriteLine($"{phaseOfDay.Month} 月 {phaseOfDay.Day} 號是 {phaseOfDay.Month} 月的中旬");
			}
			else
			{
				Console.WriteLine($"{phaseOfDay.Month} 月 {phaseOfDay.Day} 號是 {phaseOfDay.Month} 月的下旬");
			}
		}
	}
}
