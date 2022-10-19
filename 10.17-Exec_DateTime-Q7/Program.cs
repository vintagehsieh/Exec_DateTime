using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10._17_Exec_DateTime_Q7
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//Exec_DateTime
			//Q7: 根據不同時間，傳回不同問安方式?
			
			//A7-1(方法一): 根據系統時間，自動問安
			//早安: 早上六點到早上十二點， 午安:早上十二點到下午二十三點， 晚安: 下午二十三點到早上六
			//找出現在的時分秒，並轉換成int
			DateTime now = DateTime.Now;
			int hourOfNow = now.Hour;
			int minuteOfNow = now.Minute;	
			int secondOfNow = now.Second;
	
			//設定早、午、晚安開始的時間
			DateTime morningStart = new DateTime(now.Year, now.Month, now.Day, 12, 0, 0);
			int[] morningStartTime = { morningStart.Hour, morningStart.Minute, morningStart.Second };

			DateTime noonStart = new DateTime(now.Year, now.Month, now.Day, 12, 0, 0);
			int[] noonStartTime = { noonStart.Hour, noonStart.Minute, noonStart.Second };

			DateTime nightStart = new DateTime(now.Year, now.Month, now.Day, 23, 0, 0);
			int[] nightStartTime = { nightStart.Hour, nightStart.Minute, nightStart.Second };
		

			//注意!DateTime不能比較，都要換成時間
			if ( hourOfNow >= morningStartTime[0] && hourOfNow < noonStartTime[0])
			{
				if (minuteOfNow >= morningStartTime[1] && secondOfNow >= morningStartTime[2])
				{
					Console.WriteLine("早安!");
				}
			} 
			else if (hourOfNow >= noonStartTime[0] && hourOfNow < nightStartTime[0])
			{
				if (minuteOfNow >= noonStartTime[1] && secondOfNow >= noonStartTime[2])
				{
					Console.WriteLine("午安!");
				}
			}
			else
			{
				if (minuteOfNow >= nightStartTime[1] && secondOfNow >= nightStartTime[2])
				{
					Console.WriteLine("晚安!");
				}
			}
			Console.WriteLine();

			//A7-2(方法二): 自動輸入來判斷
			Console.Write("請輸入您要判斷的時間(範例: 2022/1/1 16:00:00): ");
			string input = Console.ReadLine();

			//防呆
			if ( string.IsNullOrEmpty(input))
			{
				Console.WriteLine("您沒有輸入正確時間");
				return;
			}

			//把字串轉成時間型別，並取得小時
			int hourOfInputTime = Convert.ToDateTime(input).Hour;
			int minuteourOfInputTime = Convert.ToDateTime(input).Minute;
			int secondOfInputTime = Convert.ToDateTime(input).Second;

			//判斷，用上面的
			if (hourOfInputTime >= morningStartTime[0] && hourOfInputTime < noonStartTime[0])
			{
				if (minuteourOfInputTime >= morningStartTime[1] && secondOfInputTime >= morningStartTime[2])
				{
					Console.WriteLine("早安!");
					return;
				}
			}
			else if (hourOfInputTime >= noonStartTime[0] && hourOfInputTime < nightStartTime[0])
			{
				if (minuteourOfInputTime >= noonStartTime[1] && secondOfInputTime >= noonStartTime[2])
				{
					Console.WriteLine("午安!");
					return;
				}
			}
			else
			{
				if (minuteourOfInputTime >= nightStartTime[1] && secondOfInputTime >= nightStartTime[2])
				{
					Console.WriteLine("晚安!");
				}
			}
		}
	}
}
