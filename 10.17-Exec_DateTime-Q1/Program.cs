using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10._17_Exec_DateTime_Q1
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//Exec_DateTime
			//Q1: 計算三天後DVD應歸還的時間?

			//A1-1(方式一): 假設是現在租借
			DateTime now = DateTime.Now;
			DateTime returnDate = now.AddDays(3);
			Console.WriteLine($"您租借的時間是 {now}，應該歸還在{returnDate}前歸還。");
			Console.WriteLine();

			//A2-2(方式二): 假設是自動刷入，並帶入現在時間
			Console.Write("請確認是否為現在租借(y/n): ");
			string check = Console.ReadLine();

			//防呆
			if (string.IsNullOrEmpty(check))
			{
				Console.WriteLine("您沒有確認是否為現在租借。");
				return;
			}

			//如果此次不租借
			if (check == "n")
			{
				Console.WriteLine("此次不租借，再見。");
				return;
			}

			//只能在營業時間租借9:00 - 17:00，其餘則無法租借
			TimeSpan start = new TimeSpan(9, 0, 0);
			TimeSpan end = new TimeSpan(17, 0, 0);
			DateTime rentDate = DateTime.Now;
			//DateTime rentDate = new DateTime(2022, 10, 18, 9, 30, 0);
			TimeSpan rentTime = rentDate.TimeOfDay;
			DateTime returnTime = rentDate.AddDays(3);

			if ((rentTime > start) && (rentTime < end))
			{
				Console.WriteLine($"您租借的時間是{rentDate}，並且在{returnTime}之前歸還。");
				return;
			}
			//營業時間外則無法租借
			Console.WriteLine("目前無法借還，請於營業時間再來。");
		}
	}
}
